﻿using SadeghiBasicMarket.Common.Dto;
using SadeghiBasicMarket.Domain.Entities;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Application.Services.Commands.UserLogin
{

    public interface IUserLoginService
    {
        ResultDto<ResultUserloginDto> Execute(string Username, string Password);
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
