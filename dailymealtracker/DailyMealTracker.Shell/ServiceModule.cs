using System;
using System.Collections.Generic;
using System.Text;
using DailyMeal.Gateway;
using Ninject.Core;

namespace MealTracker.Shell
{
    public class ServiceModule : StandardModule
    {
        public override void Load()
        {
          Bind<IRepository>().To<MockRepository>();
        }
    }
}
