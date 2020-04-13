using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.Models;
using BookShop.ViewModel;
using BookShop.Dal;

namespace BookShop.Controllers
{
    public class LoadController : Controller
    {
        // GET: Load
        public ActionResult Index()
        {
            BooksAuthorVM  baVm = new BooksAuthorVM();
            
            Customer customer = new Customer()
            {
                CustId = 1,CustName = "Chirag",CustMobile = 449027677
            } ;

            Books book = new Books()
            {
                BookId = 1, Author = "Charles Darwin", BookName = "Evolution Of Species"
            };


            baVm.customer = customer;
            baVm.book = book;


            CustomerDal dal1 = new CustomerDal();

            List<Customer> listCust = dal1.Customers.ToList<Customer>();



            baVm.MyListOfsustomers = listCust;

            return View("LoadContent", baVm);
        }
  
        public ActionResult Submit()
        {

            BooksAuthorVM objAuthorVm = new BooksAuthorVM();
            Customer obj = new Customer();
            obj.CustName= Request.Form["Customer.CustName"];
            obj.CustId =int.Parse( Request.Form["Customer.CustId"]);
            obj.CustMobile = int.Parse( Request.Form["Customer.CustMobile"]);

            //objAuthorVm.customer = obj;

            if (ModelState.IsValid)
            {
                CustomerDal dal = new CustomerDal();
                dal.Customers.Add(obj);//in memory
                dal.SaveChanges();// in Physcical
                objAuthorVm.customer = new Customer();
            }
            else
            {
                objAuthorVm.customer = obj;
            }


            /*CustomerDal dal = new CustomerDal();
            List<Customer> customerscoll = dal.Customers.ToList<Customer>();
            vm.customers = customerscoll;*/

            CustomerDal dal1 = new CustomerDal();

            List<Customer> listCust = dal1.Customers.ToList<Customer>() ;

            

            objAuthorVm.MyListOfsustomers = listCust;

            return View("LoadContent",objAuthorVm);

        }

        public ActionResult AddData(BooksAuthorVM   bvm)
        {
            // Receives data from form action
            /*Customer customer = new Customer();
            customer.CustName = booksAuVM.customer.CustName;
            customer.CustId = booksAuVM.customer.CustId;
            customer.CustMobile = booksAuVM.customer.CustMobile;*/

          

            BooksAuthorVM  objAuthorVm = new BooksAuthorVM();
            objAuthorVm.customer.CustName = bvm.customer.CustName;
            objAuthorVm.customer.CustId = bvm.customer.CustId;
            objAuthorVm.customer.CustMobile = bvm.customer.CustMobile;

            return View("LoadContent",objAuthorVm);
        }




    }
}