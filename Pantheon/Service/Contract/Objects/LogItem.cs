using System;
using System.Runtime.Serialization;

namespace Pantheon.Service.Contract.Objects
{
    [DataContract]
    public class LogItem
    {
        [DataMember]
        public DateTime EventOccuredAtDateTime { get; set; }

        
    }
}
