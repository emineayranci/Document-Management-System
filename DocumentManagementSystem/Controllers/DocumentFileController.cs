using DocumentManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Controllers
{
    public class DocumentFileController : Controller
    {
        DocumentDbContext dbContext = new DocumentDbContext();

        public IActionResult Index()
        {
            var documentFiles = dbContext.documentFiles.ToList();
            return View(documentFiles);
        }
        public IActionResult AddDocumentFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDocumentFile(DocumentFile df)
        {
            df.numberOf_document = 0;
            dbContext.documentFiles.Add(df);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDocumentFile(int id)
        {
            var df = dbContext.documentFiles.Find(id);
            var doc = dbContext.documents.Where(x => x.DocumentFileID == id).ToList();
            foreach (var d in doc)
            {
                var deletedDoc = new DeletedDocument();
                deletedDoc.deleted_document_name = d.document_name;
                deletedDoc.deleted_document_type = d.document_type;
                deletedDoc.UserID = d.UserID;
                dbContext.deletedDocuments.Add(deletedDoc);
                dbContext.documents.Remove(d);
            }
          
            dbContext.documentFiles.Remove(df);
            dbContext.SaveChanges();
            TempData.Add("Alert", "Document File was deleted");
            return RedirectToAction("Index");

        }
        public IActionResult GetDocumentFile(int id)
        {
            var df = dbContext.documentFiles.Find(id);
            return View("GetDocumentFile", df);
        }
        public IActionResult UpdateDocumentFile(DocumentFile docFile)
        {
            var df = dbContext.documentFiles.Find(docFile.document_file_id);
            df.document_file_name = docFile.document_file_name;
            df.numberOf_document = docFile.numberOf_document;
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DocumentFileDetail(int id)
        {
            var df = dbContext.documentFiles.Find(id);
            string s = df.document_file_name + " File Content ";
            ViewBag.name = s;
            var doc = dbContext.documents.Where(x => x.DocumentFileID == id).ToList();
            return View(doc);
        }
    }
}
