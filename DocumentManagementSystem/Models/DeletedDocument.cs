using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class DeletedDocument
    {
        [Key]
        public int deleted_document_id { get; set; }
        public string deleted_document_type { get; set; }
        public string deleted_document_name { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

    }
}
