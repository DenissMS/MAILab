using System;
using System.Xml.Serialization;

namespace MAILab
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
        public Facilities Facilities;
        public decimal Debt;
        public MaritalStatus MaritalStatus;
        public string Childrens;
        public string Description;
        public bool IsAlcoholic;
    }
}

