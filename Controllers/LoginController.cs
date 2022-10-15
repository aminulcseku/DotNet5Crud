using DotNet5Crud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5Crud.Controllers
{
    public class LoginController : Controller
    {

        private readonly ComapnyDBContext _context;

        public LoginController(ComapnyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Userinfo _Userinfo = new Userinfo();
            return View(_Userinfo);

        }


        [HttpPost]
        public IActionResult Index(Userinfo _Userinfo)
        {
            // EmployeeContext _employeeContext = new EmployeeContext();

            //var status = _context.Userinfos.Where(m => m.LoginId == _Userinfo.LoginId && m.Pasword == _Userinfo.Pasword).FirstOrDefault();
            var status = _context.Employees.Where(m => m.Designation == _Userinfo.LoginId).FirstOrDefault();
            if (status == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                return RedirectToAction("Index", "Employee");
            }
            return View(_Userinfo);
        }


        //// GET: LoginController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: LoginController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: LoginController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: LoginController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LoginController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: LoginController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LoginController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: LoginController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
