using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class DTEventArgs
    {
        public List<object> Params { get; set; }
        public DTEventArgs()
        {
            Params = new List<object>();
        }
    }
}
