using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Basic
{
   public class MockSMSService :ISMSService
    {
       private readonly INotifierService _NotifierService;

       public MockSMSService(INotifierService NotifierService)
        {
            _NotifierService = NotifierService;
        }

        public void SendSMS(string phoneNumber, string body)
        {
            SaveSMSToFile(phoneNumber,body);
            _NotifierService.NotifyByEmail(phoneNumber, body);
        }

        private void SaveSMSToFile(string mobileNumber, string body)
        {
            /*implementation for saving SMS to a file*/

            Console.WriteLine("Mocking SMS using file to mobile: {0}. SMS body: {1}", mobileNumber, body);
        }
    }
}
