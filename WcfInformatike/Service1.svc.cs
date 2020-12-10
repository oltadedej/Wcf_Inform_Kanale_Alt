using Phone_Book_Core;
using Phone_Book_Core.Service;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly PhoneBookService service1 = new PhoneBookService();


        #region Async Methods
        public IAsyncResult BeginGetPhoneBookList(AsyncCallback callback, object asyncState)
        {
            Output output = new Output();
            List<T_PHONE_BOOK> lst = new List<T_PHONE_BOOK>();
            try
            {


                lst = service1.Search().ToList();
                foreach (var item in lst)
                {
                    PhoneBookModel model = new PhoneBookModel();
                    model.Preselect(item);
                    output.phoneBookModels.Add(model);
                }
                output.response.responseCode = ResponseCode.OK;
            }
            catch (Exception ex)
            {
                output.response.responseCode = ResponseCode.KO;
                output.response.ErrorMessage = $"Mesazhi i gabimit eshte {ex.ToString()}";
            }
            return new CompletedAsyncResult<Output>(output);
        }
        public Output EndGetPhoneBookList(IAsyncResult r)
        {
            CompletedAsyncResult<Output> result = r as CompletedAsyncResult<Output>;
            return result.Data;

        }

        public IAsyncResult BeginGetById(long id, AsyncCallback callback, object asyncState)
        {
            Output output = new Output();
            try
            {
                if (id > 0)
                {
                    PhoneBookModel model = new PhoneBookModel();
                    var item= service1.GetById(id);
                    model.Preselect(item);
                    output.phoneBookModels.Add(model);
                }
                output.response.responseCode = ResponseCode.OK;
                


            }
            catch(Exception ex)
            {
                output.response.responseCode = ResponseCode.OK;
                output.response.ErrorMessage = $"Dicka nuk shkoi si duhet {ex.ToString()}";
            }
            return new CompletedAsyncResult<Output>(output);


        }
        public Output EndGetById(IAsyncResult r)
        {
            CompletedAsyncResult<Output> result = r as CompletedAsyncResult<Output>;
            return result.Data;
        }

        public IAsyncResult BeginInsert(PhoneBookModel model, AsyncCallback callback, object asyncState)
        {
            Output output = new Output();
            try
            {
                if(model != null)
                {
                    T_PHONE_BOOK item = new T_PHONE_BOOK();
                    model.Fill(item);
                    if (service1.Save(item))
                    {
                        output.response.responseCode = ResponseCode.OK;
                    }
                    else
                    {
                        output.response.responseCode = ResponseCode.KO;
                        output.response.ErrorMessage = "Probleme me shtimin ne baze te dhenash";
                    }
                }

            }
            catch(Exception ex)
            {
                output.response.ErrorMessage = $"Error: {ex.ToString()}";
            }

            return new CompletedAsyncResult<Output>(output);


        }

        public Output EndInsert(IAsyncResult r)
        {
            CompletedAsyncResult<Output> result = r as CompletedAsyncResult<Output>;
            return result.Data;
        }


        #endregion

        #region Sync Methods
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool IsConnected()
        {
            return service1.Connected();
        }

        public string Post(PhoneBookModel model)
        {
            throw new NotImplementedException();
        }
        #endregion 

    }
}
