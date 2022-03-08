using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MFaaS.Shared.Models
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
