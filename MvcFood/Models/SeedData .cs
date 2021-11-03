using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFood.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFoodContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFoodContext>>()))
            {
                if (context.Food.Any())
                {
                    return;
                }
                context.Food.AddRange(
                    new Food
                    {
                        Title = "Món ăn truyền thống .",
                        ReleaseDate = DateTime.Parse("1989-5-10"),
                        Genre = "Cơm rang ",
                        Price = 10M,
                        Img = "https://img-global.cpcdn.com/recipes/3d50ba74fea0ee16/680x482cq70/c%C6%A1m-rang-th%E1%BA%ADp-c%E1%BA%A9m-recipe-main-photo.jpg"
                    },
                    new Food
                    {
                        Title = "Món ăn ẩm thực",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Bánh kẹo Đà Nẵng",
                        Price = 10M,
                        Img = "https://img-global.cpcdn.com/recipes/3d50ba74fea0ee16/680x482cq70/c%C6%A1m-rang-th%E1%BA%ADp-c%E1%BA%A9m-recipe-main-photo.jpg"
                    },
                    new Food
                    {
                        Title = "Món ăn có thú vị",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Gà hầm thuốc bắc",
                        Price = 3.99M,
                        Img = "https://img-global.cpcdn.com/recipes/3d50ba74fea0ee16/680x482cq70/c%C6%A1m-rang-th%E1%BA%ADp-c%E1%BA%A9m-recipe-main-photo.jpg"
                    },
                    new Food
                    {
                        Title = "Món ăn Hà Nội",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Mì tôm",
                        Price = 3.99M,
                        Img = "https://img-global.cpcdn.com/recipes/3d50ba74fea0ee16/680x482cq70/c%C6%A1m-rang-th%E1%BA%ADp-c%E1%BA%A9m-recipe-main-photo.jpg"
                    }
               );
                context.SaveChanges();

            }
        }
    }
}
