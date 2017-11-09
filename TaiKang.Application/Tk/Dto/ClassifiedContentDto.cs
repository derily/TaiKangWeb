﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk.Dto
{
    [AutoMap(typeof(ClassifiedContent))]
    public class ClassifiedContentDto: EntityDto
    {
        public Classify ClassifyName;
        public string Content;
    }
}
