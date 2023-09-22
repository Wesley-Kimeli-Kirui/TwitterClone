using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Services.Comment
{
    public interface IComment
    {
        Task<List<UserComments>> GetComments();
    }
}