using System.Xml.Serialization;

namespace XML.Model
{
    public class ingredients
    {

        [XmlElement("vegIngredients")]
        public vegIngredients vegIngredients { get; set; }
        [XmlElement("animalFat")]
        public string animalFat { get; set; }
    }
    public class vegIngredients
    {
        [XmlAttribute("vegan")]
        public bool vegan { get; set; }
        [XmlText]
        public string value { get; set; }
    }
}
