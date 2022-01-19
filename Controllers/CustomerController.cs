using System;
using ProjectCoffee.Models;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using ProjectCoffee.Dal;


namespace ProjectCoffee.Controllers
{
    public class CustomerController : Controller
    {
        
        private IEnumerable<object> collection;

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
       //public JsonResult get_data()
       // {
       //     DataSet ds = dblayer.Show_Menu();
       //     List<Product> listreg = new List<Product>();
       //     foreach( DataRow dr in ds.Tables[0].Rows)
       //     {
       //         listreg.Add(new Product
       //         {
       //             NameProduct = dr["nameProduct"].ToString(),
       //             price = dr["Price"].ToString(),
       //             image = dr["Image"].ToString()

       //         }) ;
       //     }
       //     return Json(listreg, JsonRequestBehavior.AllowGet);
            
       // }
        public ActionResult datapup()
        {
            SqlConnection Con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["ProjectCoffeeContext"].ConnectionString;
            Con.ConnectionString = path;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from Products", Con);
                adp.Fill(dt);

            }
            catch (Exception)
            {
                throw;
            }
            return View(dt);
        }
    }
}