using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoConsolAppDemo
{
    internal class GroupedDemo
    {
        static void Main(string[] args)
        {
            List<Categories> categories = new List<Categories>() 
            {
            new Categories(){CategoryID=1,CategoryName="Beverages" },
            new Categories(){ CategoryID=2,CategoryName="Snacks"}
            
            };

            List<Products> products = new List<Products>() 
            { 
                new Products (){ProductID=101,ProductName="Tea",UnitPrice=10,CatId=1 },
                new Products (){ProductID=102,ProductName="Coffee",UnitPrice=20,CatId=1 },
                new Products (){ProductID=103,ProductName="Chips",UnitPrice=20,CatId=2 },
                new Products (){ProductID=104,ProductName="CheeseBites",UnitPrice=10,CatId=2 },
                new Products (){ProductID=105,ProductName="Lays",UnitPrice=10,CatId=2 },
            };

            //var data = from p in products
            //           group p by p.CatId into foodCategories
            //           select foodCategories;

            //var catdata= from c in categories
            //             select c;

            //foreach (var foodData in data)
            //{
            //    Console.WriteLine("CategoryID=" + foodData.Key);
            //    foreach (var itemCategory in catdata)
            //    {
            //        if (foodData.Key == itemCategory.CategoryID)
            //        {
            //            Console.WriteLine("CategoryName= " + itemCategory.CategoryName);
            //        }
            //    }



            //        foreach (var item in foodData)
            //        {
            //            Console.WriteLine(item.ProductID);
            //            Console.WriteLine(item.ProductName);
            //            Console.WriteLine(item.UnitPrice);
            //        }

            //    Console.WriteLine("----------------");
            //}

            var data = from p in products
                       join c in categories
                     on p.CatId equals c.CategoryID
                       select new {p.ProductID,p.ProductName,p.UnitPrice,c.CategoryName,p.CatId };



            foreach (var item in data)
            {
                Console.Write(item.ProductID);
                Console.Write("\t\t" + item.ProductName);
                Console.Write("\t\t" + item.UnitPrice);
                Console.Write("\t" + item.CatId);
                Console.Write("\t" + item.CategoryName);
                Console.WriteLine();
            }


            Console.ReadLine();



        }
    }
}
