using System;

// class User
// {
//     private string firstName;
//     private string lastName;
//     private string passWord;

//     public User(string firstname, string lastname, string password)
//     {
//         this.firstName = firstname;
//         this.lastName = lastname;
//         this.passWord = password;
//     }

//     public string GetFirstName() {return firstName;}
//     public string GetLastName(){return lastName;}
//     public string GetPassword(){return passWord;} 
// }



// class Authentication{
//     public static void Main(string[] args){

//         Console.WriteLine("Enter first name: ");
//         string firstName = Console.ReadLine();

//         Console.WriteLine("Enter last name: ");
//         string lastName = Console.ReadLine();

//         Console.WriteLine("Enter password: ");
//         string password  = Console.ReadLine();



//     }
// }

class Authentication
{
    public static void Main()
    {
        List<string> user = new List<string>();

        Console.WriteLine("Enter username and password to register");

        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
        {
            user.Insert(0, username);
            user.Insert(1, password);
            Console.WriteLine("User registered successfully");
        }
        else
        {
            Console.WriteLine("Please enter a username and password");
            Console.WriteLine("Registration unsuccessful!\n");

            Environment.Exit(1);
        }


        Console.WriteLine("Would you like to log in? (yes/no): ");

        string login = Console.ReadLine();

        if (login == "yes")
        {
            Console.WriteLine("Enter username: ");
            string storedUsername = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string storedPassword = Console.ReadLine();

            if(storedUsername == user[0] && storedPassword == user[1]){
                Console.WriteLine($"Login successful, welcome {user[0]}");
            }
            else{
                Console.WriteLine("Wrong username or password, try again");
            }
        }

    }
}

