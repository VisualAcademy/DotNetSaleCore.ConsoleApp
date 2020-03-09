using DotNetSaleCore.ConsoleApp.Models;
using System;
using System.Linq;

namespace DotNetSaleCore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //[0] DbContext 클래스의 인스턴스 생성
            //SaleDbContext context = new SaleDbContext();
            #region [1] 카테고리 등록 테스트
            //using (var context = new SaleDbContext())
            //{
            //    context.Categories.Add(new Category { Name = "책" });
            //    context.Categories.Add(new Category { Name = "강의" });
            //    context.Categories.Add(new Category { Name = "컴퓨터" });
            //    context.SaveChanges();
            //} 
            #endregion

            #region [2] 상품 등록 테스트
            //using (var context = new SaleDbContext())
            //{
            //    var book = new Product { Name = "좋은책", Price = 55.99M, CategoryId = 1 };
            //    context.Products.Add(book);

            //    context.Products.Add(new Product { Name = "좋은강의", Price = 300M, CategoryId = 2 });

            //    var computer = new Product { Name = "좋은컴퓨터", Price = 1_000M, CategoryId = 3 };
            //    context.Add(computer);

            //    context.SaveChanges();
            //} 
            #endregion

            #region [4] 상품 수정 테스트
            //using (var context = new SaleDbContext())
            //{
            //    var lecture = context.Products.Where(p => p.Name == "좋은강의").FirstOrDefault();
            //    if (lecture != null)
            //    {
            //        lecture.Price = 99.99m;
            //    }
            //    if (lecture is Product)
            //    {
            //        lecture.Price = 199.99m;
            //    }
            //    context.Entry(lecture).State = EntityState.Modified;
            //    context.SaveChanges();
            //}
            #endregion

            #region [5] 상품 삭제 테스트
            //using (var context = new SaleDbContext())
            //{
            //    var lecture = context.Products.Where(p => p.Name == "좋은강의").FirstOrDefault();
            //    if (lecture is Product)
            //    {
            //        context.Remove(lecture); 
            //    }
            //    context.SaveChanges();
            //}
            #endregion

            #region [3] 상품 출력 테스트 
            using (var context = new SaleDbContext())
            {
                // 메서드 Syntax
                //var products = context.Products
                //    .Where(it => it.Price >= 1.00m)
                //    .OrderBy(p => p.Name);

                // 쿼리 Syntax
                var products = from product in context.Products
                               where product.Price >= 1.00m
                               select product;

                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Id} - {product.Name}({product.Price})");
                }
            }
            #endregion
        }
    }
}
