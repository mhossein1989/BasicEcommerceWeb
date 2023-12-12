using Microsoft.EntityFrameworkCore;
using SadeghiBasicMarket.Application.Interfaces.Contexts;
using SadeghiBasicMarket.Common;
using SadeghiBasicMarket.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SadeghiBasicMarket.Application.Services.Commands.UserLogin
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IDataBaseContext _context;
        public UserLoginService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultUserloginDto> Execute(string Username, string Password)
        {

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "نام کاربری و رمز عبور را وارد نمایید",
                };
            }



            var user = _context.Users
                .Include(p => p.UserInRoles)
                .ThenInclude(p => p.Role)
                .Where(p => p.Email.Equals(Username)
            && p.IsActive == true)
            .FirstOrDefault();

            if (user == null)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "کاربری با این ایمیل در سایت فروشگاه باگتو ثبت نام نکرده است",
                };
            }

            var passwordHasher = new PasswordHasher();
            bool resultVerifyPassword = passwordHasher.VerifyPassword(user.Password, Password);
            if (resultVerifyPassword == false)
            {
                return new ResultDto<ResultUserloginDto>()
                {
                    Data = new ResultUserloginDto()
                    {

                    },
                    IsSuccess = false,
                    Message = "رمز وارد شده اشتباه است!",
                };
            }

            List<string> roles = new List<string>();
            foreach (var item in user.UserInRoles)
            {
                //roles += $"{item.Role.Name}";
                roles.Add(item.Role.Name);
            }
          


            return new ResultDto<ResultUserloginDto>()
            {
                Data = new ResultUserloginDto()
                {
                    Roles = roles,
                    UserId = user.Id,
                    Name = user.FullName
                },
                IsSuccess = true,
                Message = "ورود به سایت با موفقیت انجام شد",
            };


        }
    }
    //public interface IUserLoginService
    //{
    //    ResultDto<ResultUserloginDto> Execute(string Username, string Password);
    //}

    //public class UserLoginService : IUserLoginService
    //{
    //    private readonly IDataBaseContext _context;
    //    public UserLoginService(IDataBaseContext context)
    //    {
    //        _context = context;
    //    }
    //    public ResultDto<ResultUserloginDto> Execute(string Username, string Password)
    //    {
    //        string hashPassword = HashPassword.Execute(Password);

    //        var user = _context.Users.Where(p => p.Email.Equals(Username)
    //        && p.Password.Equals(hashPassword) 
    //        && p.IsActive==true)
    //        .FirstOrDefault();

    //        if (user == null)
    //        {
    //            return new ResultDto<ResultUserloginDto>()
    //            {
    //                Data = new ResultUserloginDto()
    //                {

    //                },
    //                IsSuccess = false,
    //                Message = "نام کاربری یا رمز عبور اشتباه است.",
    //            };
    //        }

    //        List<string> userRoles = _context.UserInRoles.Where(p => p.UserId == user.Id)
    //            .ToList().Select(p=>p.Role.Name).ToList();

    //        return new ResultDto<ResultUserloginDto>()
    //        {
    //            Data = new ResultUserloginDto()
    //            {
    //                Roles = userRoles,
    //                UserId = user.Id,
    //            },
    //            IsSuccess=true,
    //            Message="ورود به سایت با موفقیت انجام شد",
    //        };


    //    }
    //}

}
