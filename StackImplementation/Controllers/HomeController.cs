using StackImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StackImplementation.Controllers
{
    public class HomeController : Controller
    {
        public static bool IsStackCreated=false;
        public static int top = 0;
        public static int sizeOfArr = 0;
        public static int?[] stackArray;
        public ActionResult CreateStack(int stackSize)
        {
            if (IsStackCreated == false)
            {
                sizeOfArr = stackSize;
                stackArray = new int?[stackSize];
                IsStackCreated = true;
                top = sizeOfArr - 1;
                //ViewBag.size = stackArray;
                //StackArray  stackArray = new StackArray();
                //TempData["size"] = stackArray.SetStackSize(stackSize);
                return Json(stackArray, JsonRequestBehavior.AllowGet);
            }
            else
                return Json("Stack is already created", JsonRequestBehavior.AllowGet);
            //return RedirectToAction("Stack");
        }
        public ActionResult Push(int value)
        {
            if (top>=0)
            {
                stackArray[top] = value;
                top--;
                return Json(stackArray, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Stack is full", JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Pop()
        {
            top++;
            if (top < sizeOfArr)
            {
                //top++;
                stackArray[top] = null;
                return Json(stackArray, JsonRequestBehavior.AllowGet);
            }
            else
            {
                top--;
                return Json("Stack is empty", JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete()
        {
            stackArray = null;
            IsStackCreated = false;
            return View("Stack");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Stack()
        {
            ViewBag.Message = "Your Stack page.";
            ViewBag.size = TempData["size"];
            return View();
        }
    }

}