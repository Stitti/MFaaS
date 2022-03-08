using System.Runtime.Serialization;

namespace MFaaS.Models
{
    [DataContract]
    public class Actor
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "gender")]
        public string Gender { get; set; }
    }
}
