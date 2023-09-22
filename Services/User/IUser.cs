using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.Models;

namespace TwitterClone.Services.User
{
    public interface IUser
    {
        Task<List<Users>> GetUsers();
    }
}