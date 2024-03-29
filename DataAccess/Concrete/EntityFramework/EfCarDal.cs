﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Tbl_Cars
                             join b in context.Tbl_Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Tbl_Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                BrandName = b.BrandName,
                                ColorName = co.ColorName,
                                DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
            
        }
    }
}
