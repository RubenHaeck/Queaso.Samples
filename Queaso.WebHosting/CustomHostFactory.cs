using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Description;
using System.Web;

namespace Queaso.WebHosting
{
    public class CustomHostFactory : ServiceHostFactory
    {
        private ILog _log = LogManager.GetLogger<CustomHostFactory>();

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            _log.Info(l => l("Start method"));
            ServiceHost host = new ServiceHost(serviceType, baseAddresses);

            ServiceDebugBehavior behavior = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            if (behavior == null)
            {
                behavior = new ServiceDebugBehavior();
                behavior.IncludeExceptionDetailInFaults = true;
                host.Description.Behaviors.Add(behavior);
            }

            _log.Info(l => l("End method"));

            return host;
        }
    }
}