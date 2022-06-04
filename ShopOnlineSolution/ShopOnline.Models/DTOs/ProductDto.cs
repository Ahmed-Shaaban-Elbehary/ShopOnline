using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDiscription { get; set; }
        public string ImageUrl { get; set; }
        public decimal ProductPrice { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
