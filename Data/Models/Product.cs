﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Data.Models
{
    [Serializable]
    public class Product
    {
        [DisplayName("Id")]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        [DisplayName("Supplier")]
        [Required]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
