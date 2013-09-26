using System.Xml.Serialization;

namespace MAILab
{
    public class Facilities
    {
        [XmlAttribute]
        public string DiscountPerCent { get; set; }
        public string List {get
        {
            var list = string.Empty;
            if (DiscountPerCent != null) list += DiscountPerCent;
            return list;
        }}
    }
}
