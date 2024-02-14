using Hexagram.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagram.Business.Services.Interfaces
{
    public interface IPostService
    {
        Task<List<Post>> GetAllAsync();
        Task<bool> Create(Post Post);
        Task<Post> GetProject(int id);
        Task Update(Post post);
        Task Delete(int id);

    }
}
