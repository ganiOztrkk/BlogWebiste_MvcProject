using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class ImageFile : IEntity
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
    }
}