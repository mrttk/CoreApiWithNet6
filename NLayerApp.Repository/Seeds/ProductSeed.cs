using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Pen 1",
                    Price = 20,
                    Stock = 245,
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    Name = "Pen 2",
                    Price = 30,
                    Stock = 28,
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Name = "Pen 1",
                    Price = 40,
                    Stock = 173,
                    CategoryId = 1,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 4,
                    Name = "Book 1",
                    Price = 20,
                    Stock = 100,
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 5,
                    Name = "Book 2",
                    Price = 95,
                    Stock = 156,
                    CategoryId = 2,
                    CreatedDate = DateTime.Now
                });
        }
    }
}
