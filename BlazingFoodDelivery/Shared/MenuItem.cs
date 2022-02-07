using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingFoodDelivery.Shared
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool Featured { get; set; } = false;
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
    }
}
