using System.Runtime.Serialization;

namespace SampleWCFService
{
    [DataContract]
    public class Vehicle
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string type { get; set; }

        [DataMember]
        public string number { get; set; }
    }
}