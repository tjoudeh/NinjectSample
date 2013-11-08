using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Basic
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
#if DEBUG
            Bind<ISMSService>().To<MockSMSService>();
            Bind<INotifierService>().To<MockNotifierService>();
#else
            Bind<ISMSService>().To<SMSService>();
            Bind<INotifierService>().To<NotifierService>();
#endif

        }
    }
    
}
