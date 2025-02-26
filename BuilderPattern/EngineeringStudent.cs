using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class EngineeringStudent : StudentBuilder
    {
        public override StudentBuilder setSubjects()
        {
            List<String> subs = new List<string>();
            subs.Add("DSA");
            subs.Add("OS");
            subs.Add("Computer Architecture");
            this.sub = subs;
            return this;

        }
    }
}
