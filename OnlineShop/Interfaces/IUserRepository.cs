using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Interfaces;
using OnlineShop.Models;
using OnlineShop.Repositories;
using OnlineShop.Controllers;
using OnlineShop.Wrapper;

namespace OnlineShop.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
    }
}
