using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class Document
    {
        [Key]
        public int document_id { get; set; }
        [Required]
        public string document_type { get; set; }
        [Required]
        public string document_name { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int DocumentFileID { get; set; }
        public DocumentFile DocumentFile { get; set; }

    }
}
