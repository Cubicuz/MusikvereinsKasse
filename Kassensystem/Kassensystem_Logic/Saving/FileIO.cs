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

        public static List<meal> loadDiningPlan(string filePath) {
            XDocument doc = XDocument.Load(filePath);
            List<meal> outMealList = new List<meal>();
            foreach (XElement groupNode in doc.Descendants("group")) {
                List<meal> groupList = new List<meal>();
                foreach (XElement mealNode in groupNode.Descendants("meal")){
                    Console.WriteLine(mealNode.Attribute("id").Value);
                    decimal price = Convert.ToDecimal( mealNode.Descendants("price").First().Value);
                }
            }
            return outMealList;
        }
    }
}
