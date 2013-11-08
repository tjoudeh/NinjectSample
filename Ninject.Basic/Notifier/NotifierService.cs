using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Basic
{
    public class NotifierService :INotifierService
    {
        public void NotifyByEmail(string mobileNumber, string body)
        {
            /*implementation for resolving phone number 
             *to get email address and send notfication*/
        }
    }
}
