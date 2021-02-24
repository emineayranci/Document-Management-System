using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Models
{
    public class DocumentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\DBDoc.mdf;Integrated Security=True;Connect Timeout=30");          
        }
        
        public virtual DbSet<Document> documents { get; set; }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<DeletedDocument> deletedDocuments { get; set; }
        public virtual DbSet<DocumentFile> documentFiles { get; set; }


    }
}
