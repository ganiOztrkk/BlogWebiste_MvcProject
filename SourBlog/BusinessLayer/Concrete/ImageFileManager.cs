using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        private readonly IImageFileDal _imageFileDal;

        public ImageFileManager(IImageFileDal imageFileDal)
        {
            _imageFileDal = imageFileDal;
        }

        public List<ImageFile> List()
        {
            return _imageFileDal.List();
        }

        public void Insert(ImageFile entity)
        {
            _imageFileDal.Insert(entity);
        }

        public void Delete(ImageFile entity)
        {
            _imageFileDal.Delete(entity);
        }

        public void Update(ImageFile entity)
        {
            _imageFileDal.Update(entity);
        }

        public ImageFile GetById(int id)
        {
            return _imageFileDal.GetById(id);
        }
    }
}