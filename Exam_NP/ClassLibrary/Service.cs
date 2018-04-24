using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Service
    {
        public Database Database { get; set; }

        public Service()
        {
            Database = new Database();
        }
    }
}
