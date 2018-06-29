using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Altuntas.Data;
using Altuntas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Altuntas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
    private readonly ApplicationDbContext db;
    public SellersController(ApplicationDbContext db)
    {
      this.db = db;
    }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Seller>> Get()
        {
         
          
         /* var seller1 = new Seller();
          seller1.Name = "Altuntaş";
          db.Sellers.Add(seller1);
          db.SaveChanges();

          var buyer1 = new Buyer();
          buyer1.Name = "Bilişim Eğitim Merkezi";
          db.Buyers.Add(buyer1);
          db.SaveChanges();

          var sale1 = new Sale();
          sale1.SellerId = seller1.Id;
          sale1.BuyerId = buyer1.Id;
          sale1.Adress = "Beşiktaş";
          sale1.Commission = 5;
          sale1.ExtraFormPrice = "10";
          sale1.Height = 3;
          sale1.invoicePrice = 100;
          sale1.Length = 50;
          sale1.Model = "3310";
          sale1.OurSalePrice = 150;
          sale1.ReceivedForms = "asdasda";
          sale1.WarrantyEndDate = DateTime.Now.AddYears(2);
          sale1.Width = 6;
          sale1.CreateDate = DateTime.Now;
          sale1.CreateBy = "username";
          sale1.UpdateDate = DateTime.Now;
          sale1.UpdateBy = "username";
          db.Sales.Add(sale1);
          db.SaveChanges();*/
          var sellers = db.Sellers.OrderBy(o => o.Name).ToList();

          return sellers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
