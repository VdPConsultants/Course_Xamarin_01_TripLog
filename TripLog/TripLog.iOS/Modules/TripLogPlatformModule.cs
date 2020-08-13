using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ninject.Modules;

using TripLog.Services;
using TripLog.iOS.Services;

namespace TripLog.iOS.Modules
{
    public class TripLogPlatformModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILocationService>().To<LocationService>().InSingletonScope();
        }
    }
}