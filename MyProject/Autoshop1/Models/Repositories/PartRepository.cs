using Autoshop1.Models.DB;
using Autoshop1.Models.Interfaces;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.WebApi;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Autoshop1.Models.Repositories
{
    public class PartRepository : IParts
    {
        private MainDBContext mdbContext;
        //public PartRepository(MainDBContext ctx)
        //{
        //    mdbContext = ctx;
        //}

        public static List<SearchPart> searchResult = new List<SearchPart>();

        public List<SearchPart> getlist()
        {
            return searchResult;
        }
        public void FillList(List<SearchPart> list)
        {
            searchResult.Clear();
            searchResult.AddRange(list);
        }

        //public PartRepository(List<SearchPart> sres)
        //{
        //    searchResult = sres;
        //}

        //public PartRepository(List<SearchPart>sp)
        //{
        //    searchResult = sp;
        //}

        //public IEnumerable<Part> Partslist() => mdbContext.Parts;


        //public IEnumerable<Part> Partslistsearch(string partNum)
        //{

        //    var partsfromsearch = mdbContext.Parts.Where(p => p.PartNumber == partNum);

        //    return partsfromsearch;
        //}

        public IEnumerable<SearchPart> Partslistsearch(string partNum)
        {
            HttpReq httpReq = new HttpReq(partNum);
            var result = httpReq.GetResponse().Result;

            return result;
        }


        //public IEnumerable<Part> searchByPartId(int partId)
        //{
        //    Part partfromsearch = mdbContext.Parts.Where(p => p.PartId == partId).SingleOrDefault();
        //    yield return partfromsearch;
        //}

        public SearchPart selectedItem(int partid)
        {
            SearchPart part = searchResult.FirstOrDefault(p => p.PartId == partid);
            return part;
        }

        //public CartItem selectedCartItem(int partid)
        //{
        //    CartItem item = mdbContext.CartItems.FirstOrDefault(c => c.CartItemID == partid);
        //    return item;
        //}





        //public List<Part> searchResult(string partNum)
        //{
        //    HttpReq httpReq = new HttpReq(partNum);
        //    var result = httpReq.GetResponse().Result;
        //    return result;
        //}

    }


    public class SearchPart
    {
        public int PartId { get; set; }
        public int VendorId { get; set; }
        public string Brand { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }

        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime DeliveryDate { get; set; }

    }



}
