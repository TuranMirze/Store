using Core.Enum;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Product
    {
        private static int _no = 1;

        public string Name;
        private int _price;
        public Types Type;
        public int No { get; set; }

        public int Price { 
            get 
            {
                return _price;
            } 
            set 
            {
                if (value > 0)
                {

                    _price = value;

                }
                else {

                    throw new PriceMustBeGratherThanZeroException("0dan kicik ola bilmez");

                }

            } 
        
        }

        public Product(string name, int price, Types type)
        {
            
            No = _no++;
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
    }
}
