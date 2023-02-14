using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
namespace easygroceries.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {
        
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; }
        public DbSet<Grocery> Groceries { get; set; }
      


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();

       

           modelBuilder.Entity<Grocery>().HasData(
                 new Grocery
                 {
                     GroceryId = 1,
                     Name = "Apples",
                     Slug = "apples",
                     Description = "Juicy apples",
                     Price = 1.50M,
                     Image = "https://images.pexels.com/photos/1453713/pexels-photo-1453713.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                     Quantity = 50

                 },
                 new Grocery
                 {
                     GroceryId = 2,
                  Name = "Bananas",
                  Slug = "bananas",
                  Image= "https://images.pexels.com/photos/1093038/pexels-photo-1093038.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                  Description = "Fresh bananas",
                  Price = 3.50M,
                     Quantity = 50

                 },
                 new Grocery
                 {
                     GroceryId = 3,
                 Name = "Watermelon",
                 Slug = "watermelon",
                 Description = "Juicy watermelon",
                 Image = "https://images.pexels.com/photos/1313267/pexels-photo-1313267.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                 Price = 2.50M,
                     Quantity = 50

                 },
                 new Grocery
                 {
                     GroceryId = 4,
                 Name = "Grapefruit",
                 Slug = "grapefruit",
                 Description = "Juicy grapefruit",
                 Price = 2M,
                  Image = "https://images.pexels.com/photos/2247211/pexels-photo-2247211.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                     Quantity = 50

                 },
                 new Grocery
                 {
                     GroceryId = 5,
                 Name = "Milk",
                 Slug = "milk",
                 Description = "The best of cows",
                 Price = 1.99M,
                 Image = "https://images.pexels.com/photos/248412/pexels-photo-248412.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                     Quantity = 50

                 },
                 new Grocery
                 {
                     GroceryId = 6,
                 Name = "Bread",
                 Slug = "bread",
                 Description = "Easy toast",
                 Price = 1.99M,
                 Image = "https://images.pexels.com/photos/166021/pexels-photo-166021.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                     Quantity = 50

                 },
                 new Grocery
                 {
                     GroceryId = 7,
                 Name = "Eggs",
                 Slug = "eggs",
                 Description = "Wild chicken",
                 Price = 1.99M,
                 Image = "https://images.pexels.com/photos/600615/pexels-photo-600615.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                     Quantity = 50

                 }
           );

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                CustomerFirstName = "Bill",
                CustomerSecondName = "Gates",
                HouseNumberName = "222",
                StreetName = "High street",
                Town = "Newark",
                Postcode = "NW5 8MM",
                Country = "UK"


            },
            new Customer
            {
                CustomerId = 2,
                CustomerFirstName = "Jon",
                CustomerSecondName = "Snow",
                HouseNumberName = "1",
                StreetName = "Main street",
                Town = "London",
                Postcode = "SW1 1LP",
                Country = "UK"
            });
            modelBuilder.Entity<PurchaseOrder>().HasData(
                new PurchaseOrder
                {
                    TotalPrice = 40M,
                    Id = 1,
                    CustomerId = 2
                }
                );
        }
    }

}
    



