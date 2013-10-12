using System.Xml.Serialization;

namespace MAILab.XmlMap
{
    public class Subscriber
    {
        [XmlAttribute]
        public string ID;
        [XmlAttribute]
        public string Name;
        [XmlAttribute]
        public string Surname;
        [XmlAttribute]
        public string Patronymic;
        public string Address;
        public string DateOfBirth;
        public bool Facilities;
        public bool Debt;
        public MaritalStatus MaritalStatus;
        public int Childrens;
        public string Description;
        public bool IsViolator;
        public bool IsRetirement;
    }
}
