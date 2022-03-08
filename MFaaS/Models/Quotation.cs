using System.Runtime.Serialization;

namespace MFaaS.Models
{
    [DataContract]
    public class Quotation
    {
        [DataMember(Name = "quote")]
        public string Quote { get; set; }
        [DataMember(Name = "actor")]
        public string Actor { get; set; }
    }
}
