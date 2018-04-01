using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XML.Model;

namespace XML.Helper
{
    public static class ConvertByLinq
    {

        public static List<food> convert()
        {

            XDocument xdoc1 = XDocument.Load(@"C:\Code\XML\XML\Resources\Menu.xml");
            food food_s = new food();
            List<food> foods
           = (from _food in xdoc1.Element("a").Elements("food")
              select new food
              {
                  Name = _food.Element("name").Value,
                  Price = _food.Element("price").Value,
                  Description = _food.Element("description").Value,

                  Ingredients = (from _ingredients in _food.Elements("ingredients")
                                 select new ingredients
                                 {

                                     animalFat = _ingredients.Element("parent").Value,

                                 }).FirstOrDefault(),

                  /*
                   * objComment = (from _cmt in _marks.Elements("comments")
                                           select new Comment
                                           {
                                               TeacherComment = _cmt.Element("teacher").Value,
                                               ParentComment = _cmt.Element("parent").Value
                                           }).FirstOrDefault(),
                   * */

              }).ToList();

            return foods;

        }
    }
}
