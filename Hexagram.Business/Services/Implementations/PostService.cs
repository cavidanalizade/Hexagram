using Hexagram.Business.Services.Interfaces;
using Hexagram.Core.Entities;
using Hexagram.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.Business.Services.Implementations
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repo;

        public PostService(IPostRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Create(Post Post)
        {
            if (await _repo.Create(Post)) return true;
            return false;
        }

        public async Task Delete(int id)
        {
            await _repo.DeleteAsync(id);

        }

        public async Task<List<Post>> GetAllAsync()
        {
            var Posts = await _repo.GetAllAsync(); return Posts;
        }

        public async Task<Post> GetProject(int id)
        {
            if (id <= 0) throw new ArgumentException();
            var Post = await _repo.GetById(id);
            return Post;
        }

        public async Task Update(Post Post)
        {
            if (Post == null) throw new ArgumentNullException();
            await _repo.Update(Post);

        }
    }
}
