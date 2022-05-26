using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsjson
{
    internal class InventoryManagementSyatem
    {
        InventoryModelclass model = new InventoryModelclass();
        List<InventoryModelclass> inventoryList = new List<InventoryModelclass>();

        

        public void group(string jFilePath)
        {
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryModelclass>>(json);
                foreach (var objects in items)
                {
                    Console.WriteLine(objects.Name + " " + objects.price + " " + objects.weight);
                }
            }

        }   
    }
}
