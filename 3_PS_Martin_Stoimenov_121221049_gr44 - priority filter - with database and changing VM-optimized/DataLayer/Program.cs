using DataLayer.Database;
using Microsoft.Extensions.Logging.Abstractions;
using DataLayer.Models;
using DataLayer.Database;

public class Program
{
    static void Main(string[] args)
    {

        using (var context = new DatabaseContext())
        {
            context.Database.EnsureCreated();
            context.Add<Ticket>(new Ticket { Id = 1, Artist = "Artist1", Venue = "Venue1", Date = DateTime.Now.AddDays(1), Price = 50 });
            context.Add<Ticket>(new Ticket { Id = 2, Artist = "Artist2", Venue = "Venue2", Date = DateTime.Now.AddDays(2), Price = 60 });
            context.Add<Ticket>(new Ticket { Id = 3, Artist = "Artist3", Venue = "Venue3", Date = DateTime.Now.AddDays(3), Price = 70 });
            context.Add<Ticket>(new Ticket { Id = 4, Artist = "Artist4", Venue = "Venue4", Date = DateTime.Now.AddDays(1), Price = 80 });
            context.Add<Ticket>(new Ticket { Id = 5, Artist = "Artist5", Venue = "Venue5", Date = DateTime.Now.AddDays(2), Price = 90 });
            context.Add<Ticket>(new Ticket { Id = 6, Artist = "Artist6", Venue = "Venue6", Date = DateTime.Now.AddDays(3), Price = 70 });

            context.Add<Car>(new Car { Id = 1, Mark = "Toyota", Model = "Camry", Description = "Midsize sedan with comfortable interior", Color = "Silver", Engine = "2.5L Inline-4", Transmision = "Automatic", Price = 25000, BodyType = "Sedan", EuroCategory = "Euro 5" });
            context.Add<Car>(new Car { Id = 2, Mark = "Honda", Model = "Civic", Description = "Compact car with sporty handling", Color = "Red", Engine = "1.5L Turbocharged Inline-4", Transmision = "CVT", Price = 22000, BodyType = "Sedan", EuroCategory = "Euro 4" });
            context.Add<Car>(new Car { Id = 3, Mark = "Ford", Model = "F-150", Description = "Full-size pickup truck, known for its ruggedness", Color = "Blue", Engine = "3.5L Twin-Turbo V6", Transmision = "Automatic", Price = 40000, BodyType = "Pickup", EuroCategory = "Euro 6" });
            context.Add<Car>(new Car { Id = 4, Mark = "Chevrolet", Model = "Malibu", Description = "Stylish and comfortable midsize sedan", Color = "White", Engine = "1.5L Turbocharged Inline-4", Transmision = "Automatic", Price = 28000, BodyType = "Sedan", EuroCategory = "Euro 5" });
            context.Add<Car>(new Car { Id = 5, Mark = "BMW", Model = "X5", Description = "Luxury SUV with powerful engine options", Color = "Black", Engine = "3.0L Inline-6", Transmision = "Automatic", Price = 60000, BodyType = "SUV", EuroCategory = "Euro 4" });
            context.Add<Car>(new Car { Id = 6, Mark = "Mercedes-Benz", Model = "C-Class", Description = "Premium compact car with elegant design", Color = "Gray", Engine = "2.0L Turbocharged Inline-4", Transmision = "Automatic", Price = 45000, BodyType = "Sedan", EuroCategory = "Euro 6" });
            context.Add<Car>(new Car { Id = 7, Mark = "Audi", Model = "A4", Description = "Refined and tech-packed compact executive sedan", Color = "Blue", Engine = "2.0L Turbocharged Inline-4", Transmision = "Automatic", Price = 42000, BodyType = "Sedan", EuroCategory = "Euro 6" });
            context.Add<Car>(new Car { Id = 8, Mark = "Volkswagen", Model = "Golf", Description = "Iconic hatchback known for its practicality", Color = "Silver", Engine = "1.4L Turbocharged Inline-4", Transmision = "Automatic", Price = 28000, BodyType = "Hatchback", EuroCategory = "Euro 5" });
            context.Add<Car>(new Car { Id = 9, Mark = "Subaru", Model = "Outback", Description = "Spacious and capable crossover SUV", Color = "Green", Engine = "2.5L Flat-4", Transmision = "CVT", Price = 35000, BodyType = "SUV", EuroCategory = "Euro 4" });
            context.Add<Car>(new Car { Id = 10, Mark = "Tesla", Model = "Model 3", Description = "Electric car with impressive range and performance", Color = "White", Engine = "Electric", Transmision = "Single-Speed Automatic", Price = 50000, BodyType = "Sedan", EuroCategory = "Euro 3" });

            var books = new List<Book>
            {
                new Book { Id = 1, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Pages = 336, PublicationYear = 1960 },
                new Book { Id = 2, Title = "1984", Author = "George Orwell", Genre = "Fiction", Pages = 328, PublicationYear = 1949 },
                new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Pages = 180, PublicationYear = 1925 },
                new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Fiction", Pages = 432, PublicationYear = 1813 },
                new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Pages = 224, PublicationYear = 1951 },
                new Book { Id = 6, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Pages = 336, PublicationYear = 1960 },
                new Book { Id = 7, Title = "Animal Farm", Author = "George Orwell", Genre = "Fiction", Pages = 112, PublicationYear = 1945 },
                new Book { Id = 8, Title = "Brave New World", Author = "Aldous Huxley", Genre = "Fiction", Pages = 288, PublicationYear = 1932 },
                new Book { Id = 9, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", Pages = 310, PublicationYear = 1937 },
                new Book { Id = 10, Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Genre = "Fantasy", Pages = 223, PublicationYear = 1997 }
            };

            // Add these books to your context
            foreach (var book in books)
            {
                context.Add(book);
            }

            context.SaveChanges();
        }
    }
}


