using System;
               // Dars mavzusi "C#da string nima "
// string greeting = ("Hello, new user");

// Console.WriteLine(greeting);
// Console.Write("PLease type your name: ");
// string userName = Console.ReadLine();

// Console.WriteLine("Hoooorey! Now we know your name!");
// Console.WriteLine(userName);



            //    Stringning turlari 
    // literal string        
//string oldGreeting = "\tHello!\n\" New User \"";
    // verbatim string
//string filePath = @"C:\television.txt";
//string name = Console.ReadLine();
    // interpolated string
//string greeting = $"Hello {name}";    
//Console.WriteLine(greeting);


             // Butun sonlar
    // syntax
// short studentsCount = 30;
// int populationCount = 40_000;
// long peopleCount = 7_000_000_000;      
//     //size
// Console.WriteLine(sizeof(short));
// Console.WriteLine(sizeof(int));
// Console.WriteLine(sizeof(long));
//     //range
// Console.WriteLine(short.MinValue);
// Console.WriteLine(short.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(long.MinValue);
// Console.WriteLine(long.MaxValue);           

// string name = "Diyor";
// short age = 22;
// string workPlace = "Almalyk mining metallurgical combinate";
// string greeting = $"Hello {name}";
// string isAge = $"Your age {age}";
// string isWorkPlace = $"You work in {workPlace}";
// string path = @"This project is in C:\Users\hp\OneDrive\Desktop\Mohirdev .NET\KESCHA";
// Console.WriteLine(greeting);
// Console.WriteLine(isAge);
// Console.WriteLine(isWorkPlace);
// Console.WriteLine(path);

System.Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name} ";
System.Console.WriteLine(greeting);

System.Console.WriteLine("Enter your age: ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted {age}");
int keschasAge = 3;
int ageDifference = age - keschasAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");