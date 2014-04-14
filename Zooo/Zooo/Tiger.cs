using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooo
{
    class Tiger: Zoo
    {
        public string ownerCircus { get; set; }

        public Tiger()  {} 

        public Tiger(string name, string kind, int age, int limit, int id, string owner)
            :base(name, kind, age, limit, id)
        {
            ownerCircus = owner;
        }
    }
}
