using System.Collections.Generic;
using InnoTech.VideoApplication2021.Domain.IRepositories;
using InnotTech.VideoApplication2021.Core.IServices;
using InnotTech.VideoApplication2021.Core.Models;

namespace InnoTech.VideoApplication2021.Domain.Services
{
    public class VideoService : IVideoService
    {
        private IVideoRepository _repo;
        public VideoService(IVideoRepository repo)
        {
            _repo = repo;
        }
        
        public Video Create(Video video)
        {
            return _repo.Add(video);
        }

        public List<Video> ReadAll()
        {
            return _repo.FindAll();
        }

        public Video ReadById(int id)
        {
            return _repo.FindById(id);
        }

        public Video Update(Video video)
        {
            return _repo.Update(video);
        }

        public Video Delete(int id)
        {
            return _repo.Remove(id);
        }
    }
}