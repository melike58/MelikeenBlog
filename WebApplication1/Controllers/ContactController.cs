using BusinessLAyer.Concrete;
using BusinessLAyer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDal());
        ContactValidator cv = new ContactValidator();

    
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var concatvalues = cm.GetByID(id); 
            return View(concatvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
       

    }
}