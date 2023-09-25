using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading : IEntity
    {
        [Key]
        public int HeadingId { get; set; }

        [StringLength(70)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        
        //Category Tablosu ile ilişki
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        //Content Tablosu ile ilişki
        public ICollection<Content> Contents { get; set; }

        //writer tablosu ile ilişki
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
