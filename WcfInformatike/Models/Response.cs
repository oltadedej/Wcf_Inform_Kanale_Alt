using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfInformatike.Models
{
    [DataContract]

    public class Response
    {
        [DataMember]
       public string ErrorMessage { get; set; }

        [DataMember]
        public ResponseCode responseCode { get; set; }
    }
}