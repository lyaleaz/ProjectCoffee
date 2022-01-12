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
using System.Runtime.Remoting.Contexts;

namespace ProjectCoffee.Controllers
{
   

    public class CoffeeShopController : Controller
    {
        UserD db = new UserD();
        //DbModels db1 = new DbModels();
        
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con1 = new SqlConnection();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4JKOUPSU;Initial Catalog=UserDB;Integrated Security=True");

        // GET: CoffeeShop
        [HttpGet]
        public ActionResult CoffeeShop()
        {
            return View("CoffeeShop");
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LogInPage()
        {
            return View("LogInPage");
        }
        public ActionResult SinginPage()
        {
            return View("SinginPage");
            
        }
        public ActionResult HomePageAdmin()
        {
            return View("HomePageAdmin");

        }
        public ActionResult MenuPage()
        {
            return View();
        }
        public ActionResult Rooms()
        {
            return View();
        }
        public ActionResult Customer()
        {
            return View("Customer");
        }
        void connectionString()
        {
            con.ConnectionString = "data source=LAPTOP-4JKOUPSU; database=UserDB; integrated security = SSPI;";

        }
      
       
        [HttpPost]
        public ActionResult Verify(Admin add,User user)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from AdminDB where UserNmae='"+add.Username+"' and Password='"+add.Password+"'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return View("HomePageAdmin");
            }
            else
            {
                var obj = db.Users.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password)).FirstOrDefault();
                if (obj != null)
                {
                    return View("Customer");
                }
                else
                {
                    return View("Erorr");



                }


            }
        }
       
        public ActionResult Register()
        {

            return View();
        }



        public ActionResult Creat(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");

            }
            return View("Register");



        }
        [HttpGet]
        public ActionResult NewProd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewProd(Product pro)
        
        {
            if (ModelState.IsValid)
            {
                pro.image = "../../Image/" + pro.image;
                db.Products.Add(pro);
                db.SaveChanges();
               
                return RedirectToAction("MenuPage");

            }

            return View(pro);
        }
       

        //public ActionResult SaveData(Product prod)
        //{
        //    if (prod.NameProduct != null && prod.price != null && prod.ImageUpload != null)
        //    {
        //        string filename = Path.GetFileNameWithoutExtension(prod.ImageUpload.);
        //    }

        //}
    }







}
