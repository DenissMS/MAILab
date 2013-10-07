using System;
using System.Collections.Generic;
using MAILab.XmlMap;

namespace MAILab
{
    class FilterRequest
    {
        public const int RetirementAge = 67;
        public List<Subscriber> Subscribers;
 
        public FilterRequest(Subscriber[] data, Criteria[] criterias)
        {
            Subscribers = GetResult(data, criterias);
        }

        public static List<Subscriber> GetResult(Subscriber[] data, Criteria[] criterias)
        {
            var list = new List<Subscriber>();
            //FieldInfo fi = typeof(YourClass).GetField("field_name_here");
            //object fieldValue = fi.GetValue(yourClassInstance);
                    foreach (var subscriber in data)
                    {
                        var weed = false;
                        foreach (var criteria in criterias)
                        {
                            switch (criteria.Type)
                            {

                                case CriteriaType.Boolean:
                                    if ((bool) criteria.Value &&
                                        (bool) typeof (Subscriber).GetField(criteria.ID).GetValue(subscriber))
                                    {
                                        weed = true;
                                    }

                                    break;
                                case CriteriaType.Enumeration:
                                    break;
                                case CriteriaType.Float:
                                case CriteriaType.Integer:
                                    if (Convert.ToInt32(criteria.Value) <=
                                        (int)typeof(Subscriber).GetField(criteria.ID).GetValue(subscriber))
                                    {
                                        weed = false;
                                    }
                                    break;
                            }
                        }

                        if (weed) list.Add(subscriber);
                        //var now = DateTime.Now;
                        //var span = now.AddYears(67) - now;
                        //if ((DateTime.Parse(subscriber.DateOfBirth) + span) > now)
                        //{
                        //    list.Add(subscriber);
                        //}
                    }
            return list;
        }
    }  
}
