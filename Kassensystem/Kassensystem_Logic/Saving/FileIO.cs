using Kassensystem_Logic.Dining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Web;

namespace Kassensystem_Logic.Saving {
    public class FileIO {


        #region DiningPlan
        public static DiningPlan LoadDiningPlan(string filePath) {
            XDocument doc = XDocument.Load(filePath);
            List<MealGroup> outMealList = new List<MealGroup>();
            _MealToAmount = new Dictionary<string, int>();
            // jede Gruppe
            foreach (XElement groupNode in doc.Descendants("group")) {
                int id = 0;
                List<Meal> groupList = new List<Meal>();

                // jedes Gericht
                foreach (XElement mealNode in groupNode.Descendants("meal")){
                    Console.WriteLine(mealNode.Attribute("name").Value);
                    string name = mealNode.Attribute("name").Value;
                    decimal price = Convert.ToDecimal( mealNode.Descendants("price").First().Value);
                    decimal halfPrice;
                    if (mealNode.Descendants("halfPrice").Any()) {
                        halfPrice = Convert.ToDecimal(mealNode.Descendants("halfPrice").First().Value);
                    } else {
                        halfPrice = 0;
                    }
                    groupList.Add(new Meal(id, name, price, halfPrice));
                    id++;
                }
                outMealList.Add(new MealGroup(groupList.ToArray(), groupNode.Attribute("name").Value, groupNode.Attribute("color").Value, groupNode.Attribute("tab").Value));
            }
            DiningPlan dp = new DiningPlan(outMealList.ToArray());
            return dp;
        }

        public static void saveDiningPlan(string filePath, DiningPlan d) {
            XElement root = new XElement("diningPlan");
            foreach (var MG in d.Groups)
            {
                XElement MGXML = new XElement("group");
                MGXML.SetAttributeValue("name", MG.Name);
                MGXML.SetAttributeValue("color", MG.BgColor);
                MGXML.SetAttributeValue("tab", MG.tab);
                foreach (var M in MG.Meals)
                {
                    XElement price = new XElement("price");
                    price.Value = M.Price.ToString();
                    XElement MXML = new XElement("meal", price);
                    MXML.SetAttributeValue("name", M.Name);
                    MGXML.Add(MXML);
                }
                root.Add(MGXML);
            }
            XDocument doc = new XDocument();
            doc.Add(root);
            doc.Save(filePath);
        }
        #endregion

        #region Statistic

        private const char separator = ';';
        private static string _OrderPath;
        private static bool _OrderOpen = false;
        private static Dictionary<string, int> _MealToAmount;

        public static bool OrderOpen
        {
            get
            {
                return _OrderOpen;
            }
        }

        public static string OrderFilePath
        {
            get
            {
                return _OrderPath;
            }
            set
            {
                _OrderPath = value;
            }
        }

        public static void saveOrders()
        {
            saveOrders(_OrderPath);
        }

        /// <summary>
        /// xmlStorage
        /// </summary>
        public static void saveOrders(string path) {
            if (path != null)
            {
                foreach (var MG in DiningPlan.DiningPlanInstance.Groups)
                {
                    foreach (var M in MG.Meals)
                    {
                        if (!_MealToAmount.ContainsKey(M.Name))
                        {
                            _MealToAmount.Add(M.Name, M.TotalAmount);
                        } else
                        {
                            _MealToAmount[M.Name] = M.TotalAmount;
                        }
                    }
                }
                using (var MyFile = new System.IO.StreamWriter(path, false))
                {
                    foreach (var item in _MealToAmount)
                    {
                        MyFile.WriteLine(item.Key + separator + item.Value + separator);
                    }
                }
                _OrderPath = path;
                _OrderOpen = true;
            }
        }

        public static bool loadOrders()
        {
            return loadOrders(_OrderPath);
        }
        public static bool loadOrders(string path)
        {
            var DP = DiningPlan.DiningPlanInstance;
            if (DP == null)
            {
                return false;
            }
            string[] lines = File.ReadAllLines(path);
            _MealToAmount = new Dictionary<string, int>();
            foreach(var line in lines)
            {
                string name = line.Split(separator)[0];
                int totalAmount = Int32.Parse(line.Split(separator)[1]);
                _MealToAmount.Add(name, totalAmount);
                foreach(var MG in DP.Groups)
                {
                    foreach(var M in MG.Meals)
                    {
                        if (M.Name.Equals(name))
                        {
                            M.TotalAmount = totalAmount;
                            goto NextLine;
                        }
                    }
                }
            NextLine:
                totalAmount = totalAmount; //just do anything to be able to jump here
            }
            _OrderPath = path;
            _OrderOpen = true;
            return true;
        }
    }
    #endregion
}
