using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Persons
{
    public class MyPersonManager : IPersonManager, ISingletonDependency
    {
    }
}
