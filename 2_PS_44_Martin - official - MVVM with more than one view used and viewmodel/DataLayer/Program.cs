using DataLayer.Database;
using DataLayer.Model;
using System;
using Welcome.Others;

public class Program
{
    static void Main(string[] args)
    {
        using (var context = new DatabaseContext())
        {
            context.Database.EnsureCreated();
            AddSampleUser(context);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Retrieve all users");
                Console.WriteLine("2. Add a new user");
                Console.WriteLine("3. Delete an existing user");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RetrieveAllUsers(context);
                        break;
                    case "2":
                        AddNewUser(context);
                        break;
                    case "3":
                        DeleteUser(context);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }

    static void AddSampleUser(DatabaseContext context)
    {
        //context.Add<DatabaseUser>(new DatabaseUser()
        //{
            //Name = "user",
            //Password = "password",
            //Role = UserRolesEnum.STUDENT,
            //FacNum = "fac_num",
            //Email = "email@email.com",
            //expiresDate = DateTime.Now
        //});

        //context.SaveChanges();
    }

    static void RetrieveAllUsers(DatabaseContext context)
    {
        var users = context.Users.ToList();
        Console.WriteLine("All Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Role: {user.Role}, FacNum: {user.FacNum}, Email: {user.Email}, expires in: {user.expiresDate}");
        }
    }

    static void AddNewUser(DatabaseContext context)
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        
        UserRolesEnum[] roles = (UserRolesEnum[])Enum.GetValues(typeof(UserRolesEnum));
        bool invalidRole = true;
        UserRolesEnum userRole = UserRolesEnum.ANONYMOUS;
        while (invalidRole)
        {
            Console.Write("Enter role(");
            foreach (UserRolesEnum r in roles)
            {
                Console.Write($"{r}, ");
            }

            Console.Write("):");

            string roleInput = Console.ReadLine();

            if (Enum.TryParse(roleInput, true, out userRole))
            {
                invalidRole = false;
                Console.WriteLine($"Selected role: {userRole}");
            }
            else
            {
                Console.WriteLine("Invalid role!");
            }
        }

        Console.Write("Enter faculty number: ");
        string fac_num = Console.ReadLine();

        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        Console.Write("Enter in how many months it will expires: ");
        int exp = int.Parse(Console.ReadLine());
        Console.ReadLine();


        context.Add<DatabaseUser>(new DatabaseUser()
        {
            Name = username,
            Password = password,
            Role = userRole,
            FacNum = fac_num,
            Email = email,
            expiresDate = DateTime.Now.AddMonths(exp)
        });

        context.SaveChanges();

        LogAction(context, "User Addition", $"Added new user: {username}");

        Console.WriteLine("New user added successfully!");
    }

    static void DeleteUser(DatabaseContext context)
    {
        Console.Write("Enter username of the user to delete: ");
        string username = Console.ReadLine();

        var user = context.Users.FirstOrDefault(u => u.Name == username);
        if (user != null)
        {
            LogAction(context, "User Deletion", $"Deleted user: {username}");

            context.Users.Remove(user);
            context.SaveChanges();
            Console.WriteLine("User deleted successfully!");
        }
        else
        {
            Console.WriteLine("User not found!");
        }
    }

    static void LogAction(DatabaseContext context, string actionType, string message)
    {
        var logEntry = new LogEntry
        {
            Timestamp = DateTime.Now,
            MessageType = actionType,
            Message = message,
            userName = "Admin1"
        };

        context.LogEntries.Add(logEntry);
        context.SaveChanges();
    }
}
