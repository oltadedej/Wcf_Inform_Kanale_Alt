using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClientInf
{
    class Program
    {
        static void Main(string[] args)
        {
            var wcfClient = new WcfInformatike.Service1Client();

            var output = wcfClient.GetPhoneBookListAsync();

            while (!output.IsCompleted)
            {
                Console.WriteLine("Kerkesa po procesohet");
            }

            if (output.IsCompleted)
            {
                Console.WriteLine("Pergjigja erdhi");
            }

            long id = 17;
            var outputGetByID = wcfClient.GetByIdAsync(id);

            while (!outputGetByID.IsCompleted)
            {
                Console.WriteLine("Kerkesa GetByID po procesohet");
            }

            if (outputGetByID.IsCompleted)
            {
                Console.WriteLine("Pergjigja GetByID erdhi");
            }

            WcfInformatike.PhoneBookModel model = new WcfInformatike.PhoneBookModel();
            model.firstName = "Test10";
            model.lastName = "Surname10";
            var outputSave = wcfClient.InsertAsync(model);

            while (!outputSave.IsCompleted)
            {
                Console.WriteLine("Kerkesa e insertit po procesohet");
            }


            if (outputSave.IsCompleted)
            {
                if (outputSave.Result != null)
                    Console.WriteLine($"Pergjigja nga sherbimi eshte: {outputSave.Result.response.responseCode.ToString()}");
            }



        }
    }
}
