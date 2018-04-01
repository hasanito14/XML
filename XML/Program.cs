using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using XML.Model;
using XML.Helper;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodis = ConvertByLinq.convert();

            XmlSerializer xmlSrl = new XmlSerializer(typeof(List<food>), new XmlRootAttribute("a"));

            TextReader reader = new StreamReader(@"C:\Code\XML\XML\Resources\Menu.xml");

            List<food> foods = (List<food>)xmlSrl.Deserialize(reader);

            reader.Close();

            foreach (var _food in foods)
            {
                Console.WriteLine("");
                Console.WriteLine("Food category : {0} and food name is {1}, price is {2}", _food.category, _food.Name, _food.Price);
                Console.WriteLine("Description : {0}", _food.Description);
                Console.WriteLine(_food.Ingredients.vegIngredients.vegan);
                Console.WriteLine(_food.Ingredients.vegIngredients.value);
                Console.Write("Calories : {0} ", _food.Calories);


            }
            Console.ReadKey();


        }
    }
}
