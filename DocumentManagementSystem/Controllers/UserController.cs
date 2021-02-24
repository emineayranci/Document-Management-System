using DocumentManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Controllers
{
    public class UserController : Controller
    {
        DocumentDbContext dbContext = new DocumentDbContext();
        public IActionResult Index()
        {
            var users = dbContext.users.ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User u)
        {
            if (ModelState.IsValid)
            {
                dbContext.users.Add(u);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        public IActionResult DeleteUser(int id)
        {
            var u = dbContext.users.Find(id);
            var doc = dbContext.documents.Where(x => x.UserID == id).ToList();
            foreach (var d in doc)
            {
                var df = dbContext.documentFiles.Where(x => x.document_file_id == d.DocumentFileID).FirstOrDefault();
                df.numberOf_document--;
                var deletedDoc = new DeletedDocument();
                deletedDoc.deleted_document_name = d.document_name;
                deletedDoc.deleted_document_type = d.document_type;
                deletedDoc.UserID = d.UserID;
                dbContext.deletedDocuments.Add(deletedDoc);
                dbContext.Remove(d);
                dbContext.SaveChanges();
            }
            dbContext.users.Remove(u);
            dbContext.SaveChanges();
            TempData.Add("Alert", "User was deleted");
            return RedirectToAction("Index");

        }
        public IActionResult GetUser(int id)
        {
            if (ModelState.IsValid)
            {
                var u = dbContext.users.Find(id);
                return View("GetUser", u);
            }
            return View();
        }
        public IActionResult UpdateUser(User user)
        {
            
                var u = dbContext.users.Find(user.user_id);
                u.user_name = user.user_name;
                u.user_surname = user.user_surname;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            
        }
        public  IActionResult UserDetail(int id)
        {
            var u = dbContext.users.Find(id);
            string s = u.user_name + " " + u.user_surname +"'s Documents";
            ViewBag.name = s;
            var doc = dbContext.documents.Where(x => x.UserID == id).ToList();
            return View(doc);
        }
    }
}
