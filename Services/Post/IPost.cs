using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Services.Post
{
    public interface IPost
    {
        Task<List<UserPosts>> GetPosts();

    }
}