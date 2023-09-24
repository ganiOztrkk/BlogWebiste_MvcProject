﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }

        [StringLength(10000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //heading tablosu ile ilişki
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        //writer tablo ilişkisi
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
