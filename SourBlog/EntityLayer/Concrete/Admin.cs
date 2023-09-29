using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Admin : IEntity
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public string AdminRole { get; set; }
        public string AdminImage { get; set; }
    }
}