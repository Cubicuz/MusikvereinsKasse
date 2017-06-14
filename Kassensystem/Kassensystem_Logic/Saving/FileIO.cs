using Kassensystem_Logic.Dining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Kassensystem_Logic.Saving {
    public class FileIO {

        public static string DiningPlanPath;
        public static string OrderPath;

        public static DiningPlan LoadDiningPlan(string filePath) {
            XDocument doc = XDocument.Load(filePath);
            List<MealGroup> outMealList = new List<MealGroup>();

            foreach (XElement groupNode in doc.Descendants("group")) {
                int id = 0;
                List<Meal> groupList = new List<Meal>();
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
                outMealList.Add(new MealGroup(groupList.ToArray(), groupNode.Attribute("name").Value, groupNode.Attribute("color").Value));
            }
            DiningPlan dp = new DiningPlan(outMealList.ToArray());
            return dp;
        }

        public static void saveDiningPlan(string filePath, DiningPlan d) {

        }

        /// <summary>
        /// this is just a human readable storage, not meant to be loaded again
        /// </summary>
        public static void saveOrder(DiningPlan d) {

        }
    }
}
