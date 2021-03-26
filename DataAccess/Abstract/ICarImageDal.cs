﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarImageDal:IEntityRepository<CarImage>
    {
        List<CarImageDto> GetCarImageDetails(Expression<Func<CarImage, bool>> filter = null);
    }
   
        
  
}
