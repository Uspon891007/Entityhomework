namespace Entityhomework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;

    [Table("ContactsTable")]
    public partial class ContactsTable
    {
        
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Total { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string category { get; set; }
    }

    
}
