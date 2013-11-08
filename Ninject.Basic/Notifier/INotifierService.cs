using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Basic
{
    public interface INotifierService
    {
        void NotifyByEmail(string mobileNumber, string body);
    }
}
