using Microsoft.EntityFrameworkCore;
using System;

namespace Traveltour.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(
                new Trip { Id = 1, DateStarted = DateTime.Now },
                new Trip { Id = 2, DateStarted = DateTime.Now },
                new Trip { Id = 3, DateStarted = DateTime.Now },
                new Trip { Id = 4, DateStarted = DateTime.Now },
                new Trip { Id = 5, DateStarted = DateTime.Now });

            modelBuilder.Entity<Trip>().HasData(
                new Booking { Id = 1, UserId = 1, BookingType = "Grunge Skater Jeans", BookingStatus = "AWMGSJ", Price = 68 },
                new Booking { Id = 2, UserId = 1, BookingType = "Polo Shirt", BookingStatus = "AWMPS", Price = 35 },
                new Booking { Id = 3, UserId = 1, BookingType = "Skater Graphic T-Shirt", BookingStatus = "AWMSGT", Price = 33 },
                new Booking { Id = 4, UserId = 1, BookingType = "Slicker Jacket", BookingStatus = "AWMSJ", Price = 125 },
                new Booking { Id = 5, UserId = 1, BookingType = "Thermal Fleece Jacket", BookingStatus = "AWMTFJ", Price = 60 },
                new Booking { Id = 6, UserId = 1, BookingType = "Unisex Thermal Vest", BookingStatus = "AWMUTV", Price = 95 },
                new Booking { Id = 7, UserId = 1, BookingType = "V-Neck Pullover", BookingStatus = "AWMVNP", Price = 65 },
                new Booking { Id = 8, UserId = 1, BookingType = "V-Neck Sweater", BookingStatus = "AWMVNS", Price = 65 },
                new Booking { Id = 9, UserId = 1, BookingType = "V-Neck T-Shirt", BookingStatus = "AWMVNT", Price = 17 },
                new Booking { Id = 10, UserId = 2, BookingType = "Bamboo Thermal Ski Coat", BookingStatus = "AWWBTSC", Price = 99 },
                new Booking { Id = 11, UserId = 2, BookingType = "Cross-Back Training Tank", BookingStatus = "AWWCTT", Price = 0 },
                new Booking { Id = 12, UserId = 2, BookingType = "Grunge Skater Jeans", BookingStatus = "AWWGSJ", Price = 68 },
                new Booking { Id = 13, UserId = 2, BookingType = "Slicker Jacket", BookingStatus = "AWWSJ", Price = 125 },
                new Booking { Id = 14, UserId = 2, BookingType = "Stretchy Dance Pants", BookingStatus = "AWWSDP", Price = 55 },
                new Booking { Id = 15, UserId = 2, BookingType = "Ultra-Soft Tank Top", BookingStatus = "AWWUTT", Price = 22 },
                new Booking { Id = 16, UserId = 2, BookingType = "Unisex Thermal Vest", BookingStatus = "AWWUTV", Price = 95 },
                new Booking { Id = 17, UserId = 2, BookingType = "V-Next T-Shirt", BookingStatus = "AWWVNT", Price = 17 },
                new Booking { Id = 18, UserId = 3, BookingType = "Blueberry Mineral Water", BookingStatus = "MWB", Price = 2.8M },
                new Booking { Id = 19, UserId = 3, BookingType = "Lemon-Lime Mineral Water", BookingStatus = "MWLL", Price = 2.8M },
                new Booking { Id = 20, UserId = 3, BookingType = "Orange Mineral Water", BookingStatus = "MWO", Price = 2.8M },
                new Booking { Id = 21, UserId = 3, BookingType = "Peach Mineral Water", BookingStatus = "MWP", Price = 2.8M },
                new Booking { Id = 22, UserId = 3, BookingType = "Raspberry Mineral Water", BookingStatus = "MWR", Price = 2.8M },
                new Booking { Id = 23, UserId = 3, BookingType = "Strawberry Mineral Water", BookingStatus = "MWS", Price = 2.8M },
                new Booking { Id = 24, UserId = 4, BookingType = "In the Kitchen with H+ Sport", BookingStatus = "PITK", Price = 24.99M },
                new Booking { Id = 25, UserId = 5, BookingType = "Calcium 400 IU (150 tablets)", BookingStatus = "SC400", Price = 9.99M },
                new Booking { Id = 26, UserId = 5, BookingType = "Flaxseed Oil 100 mg (90 capsules)", BookingStatus = "SFO100", Price = 12.49M },
                new Booking { Id = 27, UserId = 5, BookingType = "Iron 65 mg (150 caplets)", BookingStatus = "SI65", Price = 13.99M },
                new Booking { Id = 28, UserId = 5, BookingType = "Magnesium 250 mg (100 tablets)", BookingStatus = "SM250", Price = 12.49M },
                new Booking { Id = 29, UserId = 5, BookingType = "Multi-Vitamin (90 capsules)", BookingStatus = "SMV", Price = 9.99M },
                new Booking { Id = 30, UserId = 5, BookingType = "Vitamin A 10,000 IU (125 caplets)", BookingStatus = "SVA", Price = 11.99M },
                new Booking { Id = 31, UserId = 5, BookingType = "Vitamin B-Complex (100 caplets)", BookingStatus = "SVB", Price = 12.99M },
                new Booking { Id = 32, UserId = 5, BookingType = "Vitamin C 1000 mg (100 tablets)", BookingStatus = "SVC", Price = 9.99M },
                new Booking { Id = 33, UserId = 5, BookingType = "Vitamin D3 1000 IU (100 tablets)", BookingStatus = "SVD3", Price = 12.49M });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "adam@example.com" },
                new User { Id = 2, Email = "barbara@example.com" });
        }
    }
}
