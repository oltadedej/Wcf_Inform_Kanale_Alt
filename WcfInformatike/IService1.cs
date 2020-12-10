using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfInformatike.Models;

namespace WcfInformatike
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        #region Sync Methods

        [OperationContract]
        [WebInvoke(Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "GetData?Id={value}")]
        string GetData(int value);

        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "IsConnected")]
        bool IsConnected();


        [OperationContract]
        [WebInvoke(Method ="POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "Post")]
        string Post(PhoneBookModel model);

        #endregion


        #region  Async Region


        [OperationContractAttribute(AsyncPattern = true)]
        IAsyncResult BeginGetPhoneBookList(AsyncCallback callback, object asyncState);

        //Note: There is no OperationContractAttribute for the end method.
        Output EndGetPhoneBookList(IAsyncResult result);


        [OperationContractAttribute(AsyncPattern = true)]
        IAsyncResult BeginGetById(long id,AsyncCallback callback, object asyncState);

        //Note: There is no OperationContractAttribute for the end method.
        Output EndGetById(IAsyncResult result);

        [OperationContractAttribute(AsyncPattern = true)]
        IAsyncResult BeginInsert(PhoneBookModel model, AsyncCallback callback, object asyncState);

        //Note: There is no OperationContractAttribute for the end method.
        Output EndInsert(IAsyncResult result);




        #endregion



    }


}
