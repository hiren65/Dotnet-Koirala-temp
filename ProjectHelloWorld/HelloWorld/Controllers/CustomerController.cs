using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;
using Microsoft.Ajax.Utilities;
using HelloWorld.Dal;

namespace HelloWorld.Controllers
{

    class CustomerBinder : IModelBinder
    {

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            string custName= objContext.Request.Form["txtCustName"];
            string custId = objContext.Request.Form["txtCustId"];

            Customer obj = new Customer()
            {
                CustName = custName,
                CustId = custId
            };

            return obj;
        }


    }
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Load()
        {

            Customer customer = new Customer();
            customer.CustName = "Hirenkumar";
            customer.CustId = "ABC1200";

            ViewData["CustName"] = customer.CustName;
            return View("Customers",customer);
        }

        // public ActionResult Submit([ModelBinder(typeof(CustomerBinder))]   Customer obj)
        public ActionResult Submit( Customer obj)
        {

            /*Customer ccc = new Customer();
            ccc.CustName = CustName;
            ccc.CustId = CustId;

            var name = CustName;
            var no = CustId;*/

            var name = obj.CustName;
            var no = obj.CustId;

            ViewData["C1"] = name;
            ViewData["C2"] = no;
            if (ModelState.IsValid)
            {
                //Insert Customer Objsct to data baseEF DAL

                CustomerDal Dal = new CustomerDal();  
                Dal.Customers.Add(obj);     //in memmory
                Dal.SaveChanges();    //Physical  Commit

                ViewData["SUC"] = "Successfull";
                return View("Customers", obj);
            }
            else
            {
                return View("Customers", obj);
            }

           
            //return View("Customers",obj);
        }

    }
}