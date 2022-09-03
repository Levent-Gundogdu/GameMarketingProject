using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IProductDal
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
