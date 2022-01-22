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