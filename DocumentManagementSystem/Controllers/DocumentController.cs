using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DocumentManagementSystem.Controllers
{
    public class DocumentController : Controller
    {
        DocumentDbContext dbContext = new DocumentDbContext();
        public IActionResult Index(string search)
        {
            var documents = dbContext.documents.ToList();
            return View(dbContext.documents.Where(x => x.document_name.StartsWith(search) || search == null).ToList());
        }
        [HttpGet]
        public IActionResult AddDocument()  // user, documentFile idlerini getiriyo
        {
            List<SelectListItem> user = (from x in dbContext.users.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.user_name,
                                             Value = x.user_id.ToString()
                                         }).ToList();
            List<SelectListItem> documentFile = (from x in dbContext.documentFiles.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.document_file_name,
                                             Value = x.document_file_id.ToString()
                                         }).ToList();
            ViewBag.u = user;
            ViewBag.df = documentFile;
            return View();
        }
        public IActionResult AddDocument(Document d) // yeni doc ekliyo
        {
                var user = dbContext.users.Where(x => x.user_id == d.User.user_id).FirstOrDefault();
                d.User = user;

                var docFile = dbContext.documentFiles.Where(x => x.document_file_id == d.DocumentFile.document_file_id).FirstOrDefault();
                docFile.numberOf_document++;
                d.DocumentFile = docFile;

                dbContext.documents.Add(d);

                dbContext.SaveChanges();
                return RedirectToAction("Index");
         
        }
        public IActionResult DeleteDocument(int id)
        {
            var d = dbContext.documents.Find(id);
            var df = dbContext.documentFiles.Find(d.DocumentFileID);
            df.numberOf_document--;
            var deletedDoc = new DeletedDocument();
           // deletedDoc.deleted_document_id = d.document_id;
            deletedDoc.deleted_document_name = d.document_name;
            deletedDoc.deleted_document_type = d.document_type;
           // deletedDoc.User = d.User;
            deletedDoc.UserID = d.UserID;
            dbContext.deletedDocuments.Add(deletedDoc);
            dbContext.documents.Remove(d); 
            dbContext.SaveChanges();
            TempData.Add("Alert", "Document was deleted");
            return RedirectToAction("Index");

        }
        public IActionResult GetDocument(int id)
        {

            List<SelectListItem> documentFile = (from x in dbContext.documentFiles.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.document_file_name,
                                                     Value = x.document_file_id.ToString()
                                                 }).ToList();
            ViewBag.df = documentFile;
           // var doc = dbContext.documents.Find(id);
            var doc = dbContext.documents.Where(x => x.document_id == id).FirstOrDefault();
           
            var oldDocFile = dbContext.documentFiles.Where(x => x.document_file_id == doc.DocumentFile.document_file_id).FirstOrDefault();
            oldDocFile.numberOf_document--;
            dbContext.SaveChanges();
            return View("GetDocument", doc);
        }
        public IActionResult UpdateDocument(Document doc)
        {
            var d = dbContext.documents.Find(doc.document_id);
   
           
            var docFile = dbContext.documentFiles.Where(x => x.document_file_id == doc.DocumentFile.document_file_id).FirstOrDefault();
            docFile.numberOf_document++;
            d.document_name = doc.document_name;
            d.document_type = doc.document_type;
            d.DocumentFile = docFile;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

