using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppTest.Models;

namespace AppTest.Controllers
{
    public class PaisController : ApiController
    {
        public IEnumerable<cat_pais> get()
        {
            using (dbEntities db = new dbEntities())
            {
                var pais = db.cat_pais.ToList();
                return pais;
            }                
        }
    }
}
