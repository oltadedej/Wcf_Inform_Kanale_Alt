using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfInformatike.Models
{
    [DataContract]
    [Serializable]
    public class PhoneBookModel
    {
        [DataMember]
        long? id { get; set; }

        [DataMember]
        string name { get; set; }
        [DataMember]
        string surname { get; set; }




    }
}