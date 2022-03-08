using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MFaaS.Shared.Models
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
