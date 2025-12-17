using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IELTScalculator.Domain;

namespace IELTScalculator.Infrastucture
{
    public class DbContext
    {
        public IELTS[] ielts { get; set; }
        
        public DbContext() 
        {
            ielts = new IELTS[20];
        }
    }

    
}
