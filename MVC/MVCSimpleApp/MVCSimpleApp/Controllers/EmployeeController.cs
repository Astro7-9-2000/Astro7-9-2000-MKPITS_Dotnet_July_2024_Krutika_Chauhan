using MVCSimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace MVCSimpleApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employees = from e in EmpList
                            orderby e.Id
                            select e;
            return View(employees);
        }
        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = EmpList.SingleOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Employee emp = new Employee();
                emp.Name = collection["Name"];
                DateTime jDate;
                DateTime.TryParse(collection["DOB"] , out jDate);
                emp.JoiningDate = jDate;
                string age = collection["Age"];
                emp.Age = Int32.Parse(age);
                //empList.Add(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var Employee = EmpList.SingleOrDefault(m => m.Id == id);
            if(Employee == null)
            {
                return HttpNotFound();
            }
            
            return View(Employee);

        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var employee = EmpList.Single(m => m.Id == id);
                if (TryUpdateModel(employee))
                {
                    employee.Name = collection["Name"];
                    employee.Age = Int32.Parse(collection["Age"]);
                    employee.JoiningDate = DateTime.Parse(collection["JoiningDate"]);
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public static List<Employee> EmpList= new List<Employee>
            {
                new Employee
                {
                    Id = 1 , 
                    Name = "Elon" ,
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 23,
                } , 

                new Employee
                {
                    Id = 2 , 
                    Name = "Hazel" ,
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 25
                } , 

                new Employee
                {
                    Id = 3 , 
                    Name = "Derek" , 
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 28 
                } , 

                new Employee
                {
                    Id = 4 , 
                    Name = "Krutika" , 
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()) , 
                    Age = 27
                },
            };
        }
        }
       
