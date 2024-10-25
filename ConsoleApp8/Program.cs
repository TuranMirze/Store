using Core;
using Core.Enum;
using System.Drawing;
using System.Security.Cryptography;

namespace ConsoleApp8

{
    public class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product("GSHGWY", 12, Types.Meal);
            //Product product2 = new Product($"Name{product2.Name}, price{12}, Types{Types.Meal}");
            //store.AddProduct(product2);
            //store.AddProduct(product);

                Store store = new Store();
            try
            {

                Product bread = new Product("Corek", 2, Types.Baker);
                Product meat = new Product("Et", 10, Types.Drink);

                store.AddProduct(bread);
                store.AddProduct(meat);

            }

            catch (PriceMustBeGreaterThanZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            



            string Name;
            int _price;
            Types? Type = null;
            Types? Type2 = null;

            string product_name;
            int product_price;
            int price;

            string secim1;
            bool f = false;

            do
            {
                Console.WriteLine("Seçim edin:");
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - AddProduct");
                Console.WriteLine("2 - GetProduct");
                Console.WriteLine("3 - Remove");
                Console.WriteLine("4 - FilterProductsByType() ");
                Console.WriteLine("5 - FilterProductByName()");
                Console.WriteLine("6 - Proqramdan dayandırmaq üçün");


                secim1 = Console.ReadLine();

                switch (secim1)
                {
                    case "0":
                        Console.WriteLine();
                        Console.WriteLine("Butun mehsullar:");
                        store.ShowAll();
                        break;
                    case "1":
                        Console.WriteLine("Product elave edin: ");
                        product_name = Console.ReadLine();

                        //Product product = new Product(product.Name,product.Price,product.Type);


                        Console.WriteLine("Price daxil edin:");
                        product_price = int.Parse(Console.ReadLine());

                        //_price = Console.ReadLine(price) out price);
                        //Console.ReadLine(product.Name);
                        //store.AddProduct(product);
                        Console.WriteLine("1.Baker");
                        Console.WriteLine("2.Drink");
                        Console.WriteLine("3.Meal");
                        Console.WriteLine("4.Diary");
                        Console.WriteLine("Mehsulun kateqoriyasini daxil edin:");
                        string secim2 = Console.ReadLine();

                        switch (secim2)
                        {
                            case "1":
                                Type2 = Types.Baker;
                                break;
                            case "2":
                                Type2 = Types.Drink;
                                break;
                            case "3":
                                Type2 = Types.Meal;
                                break;
                            case "4":
                                Type2 = Types.Diary;
                                break;
                            default:
                                Console.WriteLine("Zehmet olmasa yuxarida verilenlerden secim edin.");
                                break;
                        }

                        Product product1 = new Product(product_name,product_price,Type2.Value);
                        store.AddProduct(product1);
                        //Console.WriteLine($"{product_name}, {product_price}, {Type.ToString()}");
                        break;

                    case "2":
                        Console.WriteLine("No daxil edin");
                        int no = int.Parse(Console.ReadLine());
                        store.GetProducts(no);
                        break;

                    case "3":
                        Console.WriteLine("Silmek istediyiniz mehsulun nomresini daxil edin");
                        int no1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Remove methodunu yazammadim. Listi de bugun kecdiyimizcun kodu basdan yazmaga vaxtim olmadi :(");
                        //store.RemoveProductByNo(no1);
                        //store.ShowAll();
                        break;

                    case "4":
                        //Types = Console.ReadLine();
                        //store.FilterProductsByType(Types);
                        //break;
                        Console.WriteLine("1.Baker");
                        Console.WriteLine("2.Drink");
                        Console.WriteLine("3.Meal");
                        Console.WriteLine("4.Diary");

                        Console.WriteLine("Mehsulun kateqoriyasini daxil edin:");
                        string secim3 = Console.ReadLine();

                        switch (secim3)
                        {
                            case "1":
                                Type = Types.Baker;
                                break;
                            case "2":
                                Type = Types.Drink;
                                break;
                            case "3":
                                Type = Types.Meal;
                                break;
                            case "4":
                                Type = Types.Diary;
                                break;
                            default:
                                Console.WriteLine("Zehmet olmasa yuxarida verilenlerden secim edin.");
                                break;
                        }

                        if (Type != null)
                        {

                            store.FilterProductsByType(Type.Value);
                        }

                        break;

                    case "5":
                        Console.WriteLine("Mehsul adini daxil edin:");
                        string name = Console.ReadLine();
                        store.FilterProductsByName(name);
                        break;

                    case "6":
                        f = true;
                        Console.WriteLine("Muveqqeti narahatciliga gore uzr isteyirik");
                        break;
                       
                    default:
                        Console.WriteLine("Xahis edirik yuxaridaki secimlerden birini secin");
                        break;
                }
            } while (!f);
        }
    }
}
