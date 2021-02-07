using Autoshop1.Models.DB;
using Autoshop1.Models.MainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.Repositories
{
    public class DBPartSearch
    {

        private readonly MainDBContext mdbContext;

        public DBPartSearch(MainDBContext ctx)
        {
            mdbContext = ctx;

        }

        public List<Part> AddAnalogsToListPart(List<Part> parts)
        {
            List<Part> newlist = new List<Part>();
            foreach(Part part in parts)
            {
                var newparts = mdbContext.Parts.Where(p => p.Brand == part.Brand && p.PartNumber == part.PartNumber);
                newlist.AddRange(newparts);
            }

            parts.AddRange(newlist);
            return parts;
        }

    }
}
