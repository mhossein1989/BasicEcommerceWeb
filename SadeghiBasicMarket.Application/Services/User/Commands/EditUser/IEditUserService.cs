﻿using SadeghiBasicMarket.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Application.Services.Commands.EditUser
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEdituserDto request);
    }
}
