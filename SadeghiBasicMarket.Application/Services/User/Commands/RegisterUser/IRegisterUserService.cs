using SadeghiBasicMarket.Common.Dto;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Application.Services.Commands.RegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }
}
