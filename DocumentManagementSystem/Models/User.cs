using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        public string user_name { get; set; }
        [Required]
        public string user_surname { get; set; }

        public IList<Document> Documents { get; set; }
        public IList<DeletedDocument> DeletedDocuments { get; set; }


    }
}
