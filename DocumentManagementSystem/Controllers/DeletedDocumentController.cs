using DocumentManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Controllers
{
    public class DeletedDocumentController : Controller
    {
        DocumentDbContext dbContext = new DocumentDbContext();

        public IActionResult Index()
        {
            var deletedDoc = dbContext.deletedDocuments.ToList();
            return View(deletedDoc);
        }
        public IActionResult RemoveDoc(int id)
        {
            var dd = dbContext.deletedDocuments.Find(id);
            dbContext.deletedDocuments.Remove(dd);
            dbContext.SaveChanges();
            TempData.Add("Alert", "Document was completely deleted");
            return RedirectToAction("Index");
        }
    }
}
