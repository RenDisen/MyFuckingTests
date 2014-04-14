using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooo
{
    class Elephant: Zoo
    {
        public int lengthTusks { get; set; }

        public Elephant()   {}

        public Elephant(string name, string kind, int age, int limit,int id, int length)
            :base(name, kind, age, limit, id)
        {
            lengthTusks = length;
        }
    }
}
