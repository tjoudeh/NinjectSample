using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Basic
{
    public class MockNotifierService :INotifierService
    {
        public void NotifyByEmail(string mobileNumber, string body)
        {
            /*Mock implementation for resolving phone number 
             *to get email address and send notfication*/
        }
    }
}
