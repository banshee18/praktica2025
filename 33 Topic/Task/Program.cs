using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task
{
    public class YourDbContext : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Tourist> Tourists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Visder\\OneDrive\\Desktop\\практика кпияп\\Тема 1\\33 Topic\\DBTur_firm.sqlite");
        }
    }

    [Table("Туры")]
    public class Tour
    {
        [Column("Код_тура")]
        public int TourId { get; set; }
        [Column("Название")]
        public string Name { get; set; }
        [Column("Дата_начала")]
        public DateTime StartDate { get; set; }
        [Column("Дата_окончания")]
        public DateTime EndDate { get; set; }
        [Column("Цена")]
        public decimal Price { get; set; }
    }

    [Table("Туристы")]
    public class Tourist
    {
        [Column("Код_туриста")]
        public int TouristId { get; set; }
        [Column("Фамилия")]
        public string LastName { get; set; }
        [Column("Имя")]
        public string FirstName { get; set; }
        [Column("Отчество")]
        public string MiddleName { get; set; }
        [Column("Код_тура")]
        public int TourId { get; set; }
    }

    class Program
    {
        static void Main()
        {
            using (var db = new YourDbContext())
            {
                var tourists = db.Tourists.ToList();

                Console.WriteLine("Список туристов:");
                foreach (var tourist in tourists)
                {
                    Console.WriteLine($"ID: {tourist.TouristId}, Фамилия: {tourist.LastName}, Имя: {tourist.FirstName}, Отчество: {tourist.MiddleName}, ID тура: {tourist.TourId}");
                }
            }
        }
    }
}
