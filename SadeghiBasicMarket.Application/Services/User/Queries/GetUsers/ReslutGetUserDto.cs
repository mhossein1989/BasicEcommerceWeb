﻿using System.Collections.Generic;

namespace SadeghiBasicMarket.Application.Services.Queries.GetUsers
{
    public class ReslutGetUserDto
    {
        public List<GetUsersDto> Users { get; set; }
        public int Rows { get; set; }
    }
}
