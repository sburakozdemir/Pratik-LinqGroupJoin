using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_LinqGroupJoin
{
    internal class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public Class(int classID, string className) 
        
        {
            ClassId = classID;
            ClassName = className;

        }
    }
}
