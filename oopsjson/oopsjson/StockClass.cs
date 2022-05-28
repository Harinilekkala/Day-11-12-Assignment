using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsjson
{
    public class StockClass
    {

        StockThirdModelClass model = new StockThirdModelClass();
        List<StockThirdModelClass> inventoryList = new List<StockThirdModelClass>();



        public void group(string jFilePath)
        {
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<StockThirdModelClass>>(json);
                foreach (var objects in items)
                {
                    Console.WriteLine(objects.StockName + " " + objects.Shareprice + " " + objects.NoOfShares);
                }
            }

        }
    }




}

