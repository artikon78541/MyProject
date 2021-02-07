using Autoshop1.Models.MainModels;
using Autoshop1.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoshop1.Models.Interfaces
{

    public interface IParts
    {
        //IEnumerable<Part> Partslist { get; }

        //IEnumerable<Part> Partslistsearch(string partNumber);
        IEnumerable<SearchPart> Partslistsearch(string partNumber);
        //IEnumerable<Part> Partslist();
        public SearchPart selectedItem(int partid);
        public List<SearchPart> getlist();

        //public CartItem selectedCartItem(int partid);

        //IEnumerable<Part> searchByPartId(int partId);
        //Part selectedItem(int cartid);
        //public List<Part> searchResult(string partNum);



    }

}
