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
        List<InventoryModelclass> inventoryModelclasses = new List<InventoryModelclass>();
        List<secondmodelclass> Rice;
        List<secondmodelclass> Pulse;
        List<secondmodelclass> Wheat;
        

        public void group(string jsonFilePath)
        {
            using (StreamReader reader = new StreamReader(jsonFilePath))
            {
                var json = reader.ReadToEnd();
                InventoryModelclass items = JsonConvert.DeserializeObject<InventoryModelclass>(json);
                InventoryModelclass inventoryModelclass = new InventoryModelclass();
                Rice = items.Rice;
                Pulse = items.Pulse;
                Wheat = items.Wheat;
                Console.WriteLine("Enter 1 for Rice");
                Console.WriteLine("Enter 2 for Pulse");
                Console.WriteLine("Enter 3 for Wheat");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        foreach (var contact in Rice)
                            Console.WriteLine(contact.Name + " " + contact.price + " " + contact.weight);
                        break;
                    case 2:
                        foreach (var contact  in Pulse)
                            Console.WriteLine(contact.Name + " " + contact.price + " " + contact.weight);
                        break;
                    case 3:
                        foreach (var contact  in Wheat)
                            Console.WriteLine(contact.Name + " " + contact.price + " " + contact.weight);
                        break;
                }
            }
        }
    }
}