using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Store
    {
        Product[] products;
        private List<Product> productss = new List<Product>();

        public Store()
        {
            products = new Product[0];
        }



        public void ShowAll()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Sira:" + products[i].No + " ");
                Console.WriteLine("Mehsul:" + products[i].Name + " ");
                Console.WriteLine("Qiymet:" + products[i].Price + "$" + " ");
                Console.WriteLine("Kateqoriya:"+ products[i].Type);
                Console.WriteLine();
            }
        }


        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
            Console.WriteLine($"{product.Name} adli mehsulunuz elave edildi.");
        }

        //public void RemoveProductByNo(int _no)
        //{

        //    for (int i = 0; i < products.Length; i++)
        //    {

        //        if (products[i].No == _no)
        //        {
        //            products[i].Name = null;
        //            products[i]._price = 0;
        //        }

        //    }

        //}

        public void GetProducts(int no)
        {

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sira:" + products[i].No + " ");
                    Console.WriteLine("Mehsul:" + products[i].Name + " ");
                    Console.WriteLine("Qiymet:" + products[i].Price + "$" + " ");
                    Console.WriteLine("Kateqoriya:" + products[i].Type);
                    Console.WriteLine();
                }

                else
                {

                    Console.WriteLine($"{products[i].Name} nomreli mehsul yoxdur");

                }

            }

        }




        public void RemoveProductByNo(int no)
        {
            //bool productFound = false;

            //for (int i = 0; i < products.Length; i++)
            //{
            //    if (products[i].No == no)
            //    {
            //        products.RemoveAt(i);;
            //        productFound = true;
            //        break; // Exit loop after removal
            //    }
            //}

            //if (!productFound)
            //{
            //    Console.WriteLine($"{no} nomreli mehsul yoxdur. Elave ele silersen sora :)");
            //}
        }

        public void FilterProductsByType(Types type)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Type == type)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sira:" + products[i].No + " ");
                    Console.WriteLine("Mehsul:" + products[i].Name + " ");
                    Console.WriteLine("Qiymet:" + products[i].Price + "$" + " ");
                    Console.WriteLine("Kateqoriya:" + products[i].Type);
                    Console.WriteLine();
                }

                else {

                    Console.WriteLine($"{products[i].Type} kateqoriyasinda mehsul yoxdur. Yaxinda gelecek :)");

                }
            }
        }



        public void FilterProductsByName(string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sira:" + products[i].No + " ");
                    Console.WriteLine("Mehsul:" + products[i].Name + " ");
                    Console.WriteLine("Qiymet:" + products[i].Price + "$" + " ");
                    Console.WriteLine("Kateqoriya:" + products[i].Type);
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine($"{products[i].Name} adli mehsul yoxdur. Yaxinda gelecek :)");
                }
            }

        }

    }
}
