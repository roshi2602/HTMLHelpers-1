using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpersinMVC.Models;

namespace HTMLHelpersinMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult MyEmployee()
        {
            Employee emp = new Employee()
            {
                Eid = 1,
                Address = "813 vip paraspar, indore"
            };
            return View(emp);
        }


        //for dropdown list
        public ActionResult MyDropDown()
        {
            //create Employee list
            List<Employee> empl = new List<Employee>()
            {
                new Employee(){Eid=2, Ename="paul",Address="suadama nagar",City="pune",Password="2344"},
                 new Employee(){Eid=3, Ename="teresa",Address="suadama nagar",City="mumbai",Password="2ff4"},
                  new Employee(){Eid=4, Ename="minal",Address="suadama nagar",City="ahendabad",Password="ff4"},
            };
            

            //retive data
            //create selectList
            ViewBag.Employee = new SelectList(empl, "Eid", "Ename", "Address", "City", "Password");
           
            //pass Employee to view
            return View();
        }
      //drop down list is nothing but a collection of SelectListItem objects
      //using this, we can retrive the values from database


    }
} 