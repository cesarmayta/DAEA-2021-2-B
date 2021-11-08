using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            /*var query = from p in context.Products
                        select p;*/

            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;



            //insertar datos
            //Products p = new Products();

            //p.ProductName = "Peruvian Coffee";
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "10 pkgs";
            //p.UnitPrice = 25;

            //context.Products.InsertOnSubmit(p);
            //context.SubmitChanges();


            //var query = from pr in context.Products
            //            where pr.CategoryID == 1
            //            select pr;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Price ={1} \t Name ={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            //}


            var query = from pr in context.Products
                        where pr.ProductName == "Tofu"
                        select pr;

            foreach (var prod in query)
            {
                Console.WriteLine("ID={0}  \t Name ={1} \t Price ={2} \t Stock ={3} \t Discontinued ={4}", prod.ProductID, prod.ProductName, prod.UnitPrice, prod.UnitsInStock, prod.Discontinued);
            }

            //Modificar Datos
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();

            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            context.SubmitChanges();

            var query2 = from pr2 in context.Products
                         where pr2.ProductName == "Tofu"
                         select pr2;

            foreach (var prod2 in query2)
            {
                Console.WriteLine("ID={0}  \t Name ={1} \t Price ={2} \t Stock ={3} \t Discontinued ={4}", prod2.ProductID, prod2.ProductName, prod2.UnitPrice, prod2.UnitsInStock, prod2.Discontinued);
            }

            //eliminar registro
            var productEliminar = (from pr3 in context.Products
                           where pr3.ProductID == 78
                           select pr3).FirstOrDefault();

            context.Products.DeleteOnSubmit(productEliminar);
            context.SubmitChanges();

           

            var queryEliminar = from pr4 in context.Products
                        where pr4.CategoryID == 1
                        select pr4;

            foreach (var prod4 in queryEliminar)
            {
                Console.WriteLine("ID={0} \t Price ={1} \t Name ={2}", prod4.ProductID, prod4.UnitPrice, prod4.ProductName);
            }

            Console.ReadKey();


        }
    }
}
