using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.Vendors
{
    public class LoaderToDB
    {
        public string fileName { get; set; }
        public int numLoaded { get; set; }
        public int numError { get; set; }
    }
}
