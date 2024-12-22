using AuthServer.Core.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IUserService  //yeni uyeleri kaydetmek.
    {
        //user db ile ilgili olmasına ragman repository i olusturmadan servisini olusturuyoruz cunku Identity kutuphanesini kullandım.

        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}
