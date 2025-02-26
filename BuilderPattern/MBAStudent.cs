using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class MBAStudent : StudentBuilder
    {
        public override StudentBuilder setSubjects()
        {
            List<String> subs = new List<string>();
            subs.Add("Micro Economics");
            subs.Add("Business Studies");
            subs.Add("Operations Management");
            this.sub = subs;
            return this;

        }
    }
}
