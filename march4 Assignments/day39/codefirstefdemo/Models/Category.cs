using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstefdemo.Models
{
    class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public List<Product> Products { set; get; }


    }
}