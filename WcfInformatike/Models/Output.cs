using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfInformatike.Models
{
    [DataContract]
    [Serializable]
    public class Output
    {
        [DataMember]
        public Response response {get;set;}

        [DataMember]
     public   List<PhoneBookModel> phoneBookModels { get; set; } = new List<PhoneBookModel>();
        public Output()
        {
            this.response = new Response();
        }
    }
}