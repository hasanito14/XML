using System.Xml.Serialization;

namespace XML.Model
{
    public class food
    {
        [XmlAttribute("category")]
        public string category { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("calories")]
        public int Calories { get; set; }
        [XmlElement("ingredients")]
        public ingredients Ingredients = new ingredients();
    }
}
