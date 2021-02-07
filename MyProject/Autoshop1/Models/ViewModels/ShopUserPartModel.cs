using Autoshop1.Models.Identity;
using Autoshop1.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Autoshop1.Models.MainModels;

namespace Autoshop1.Models.ViewModels 
{
    public class ShopUserPartModel
    {
        public AppUser appUser { get; set; }

        public List<SearchPart> SearchParts { get; set; }

        public int NumofCartItems { get; set; }



    }

    public class ModelCollection
    {
        private Dictionary<Type, object> models = new Dictionary<Type, object>();

        public void AddModel<T>(T t)
        {
            models.Add(t.GetType(), t);
        }

        public T GetModel<T>()
        {
            return (T)models[typeof(T)];
        }
    }

    public class SendingData
    {
        public int partId { get; set; }
        public int quant { get; set; }
        public string str { get; set; }
    }

}
