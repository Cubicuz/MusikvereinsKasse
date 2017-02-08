﻿using Kassensystem_Logic.Dining;
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

        public static MealGroup [] LoadDiningPlan(string filePath) {
            XDocument doc = XDocument.Load(filePath);
            List<MealGroup> outMealList = new List<MealGroup>();

            foreach (XElement groupNode in doc.Descendants("group")) {
                List<Meal> groupList = new List<Meal>();
                foreach (XElement mealNode in groupNode.Descendants("meal")){
                    Console.WriteLine(mealNode.Attribute("id").Value);
                    int id = Convert.ToInt32(mealNode.Descendants("id").First().Value);
                    decimal price = Convert.ToDecimal( mealNode.Descendants("price").First().Value);
                    decimal halfPrice;
                    if (mealNode.Descendants("halfPrice").Any()) {
                        halfPrice = Convert.ToDecimal(mealNode.Descendants("halfPrice").First().Value);
                    } else {
                        halfPrice = 0;
                    }
                    string name = mealNode.Attribute("name").Value;
                    groupList.Add(new Meal(id, name, price, halfPrice));
                    id++;
                }
                outMealList.Add(new MealGroup(groupList.ToArray(), groupNode.Attribute("name").Value, groupNode.Attribute("color").Value));
            }
            return outMealList.ToArray();
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