using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionHowTos
{
    public class DependentThing
    {
        public DependentThing(IDependencyThing dependencyThing)
        {
        }
        public void DoSomething(DependencyThingB dep)
        {
            var _dep = dep;
        }
    }
}
