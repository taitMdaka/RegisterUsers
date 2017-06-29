using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst.data_Access
{
    class Class2 : DbContext
    {
        public Class2() : base("codefirst")
        {
            
        }
        public DbSet<Class1> MyProperty { get; set; }

    }
}
