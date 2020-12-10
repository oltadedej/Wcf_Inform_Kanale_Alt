using Phone_Book_Core;
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
        string firstName { get; set; }
        [DataMember]
        string lastName { get; set; }

       public void Fill(T_PHONE_BOOK item)
        {
            if (this != null)
            {
                if (!String.IsNullOrEmpty(this.firstName))
                    item.NAME = this.firstName;
                if (!String.IsNullOrEmpty(this.lastName))
                    item.SURNAME = this.lastName;
            }

        }

        public void Preselect(T_PHONE_BOOK item)
        {
            if (item != null)
            {
               
                this.firstName = item.NAME;
                this.lastName = item.SURNAME    ;
            }

        }

    }
}