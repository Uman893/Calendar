using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Calendar.Models
{
    public class SchemaActivity
    {
        public int Id { get; set; }
        [Required]
        public DateTime? Start { get; set; }
        [Required]
        public DateTime? End { get; set; }
        public DateTime? ExpiresAt { get; set; }
        //Iterations
        //public virtual Schema? Schema { get; set; }
        //[ForeignKey(nameof(Schema))]
        //public int SchemaId { get; set; }
        //public virtual Activity? Activity { get; set; }
        //[ForeignKey(nameof(Activity))]
        //public int ActivityId { get; set; }

        [StringLength(10)]
        public string? ThemeColor { get; set; }

        public bool? IsFullDay { get; set; }
    }
}