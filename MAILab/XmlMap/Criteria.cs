﻿using System.Xml.Serialization;

namespace MAILab.XmlMap
{
    public class Criteria
    {
        [XmlAttribute]
        public string ID;
        [XmlAttribute]
        public string Name;
        [XmlAttribute]
        public CriteriaType Type;
        [XmlAttribute]
        public bool Exclusion;

        public object Value;
    }
}
