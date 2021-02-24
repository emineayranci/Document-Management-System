using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class DocumentFile
    {
        [Key]
        public int document_file_id { get; set; }
        [Required]
        public string document_file_name { get; set; }
        public int numberOf_document { get; set; }
        public IList<Document> Documents { get; set; }

    }
}
