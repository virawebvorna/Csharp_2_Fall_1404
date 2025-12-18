// 1 to 10
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine();
//Console.WriteLine();

//int j = 0;
//while (j <= 10)
//{
//    j++;
//    if (j == 2)
//        continue;
//    Console.WriteLine(j);
//}
//Console.WriteLine();


// 10 to 1
//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("enter Course1");
//int course1 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter Course2");
//int course2 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter Course3");
//int course3 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter Course4");
//int course4 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter Course5");
//int course5 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter Course6");
//int course6 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter Course7");
//int course7 = int.Parse(Console.ReadLine());

//int total = course1 + course2 + course3 + course4 + course5 + course6 + course7;
//Console.WriteLine(total / 7);

//int total1 = 0;
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("enter Course " + i);
//    int course = int.Parse(Console.ReadLine());

//    total1 += course;
//}

//Console.WriteLine(total1 / 10);
//Console.WriteLine();
//Console.WriteLine();


//int total2 = 0;
//int j = 1;
//while (j <= 10)
//{
//    Console.WriteLine("enter Course " + j);
//    int course = int.Parse(Console.ReadLine());

//    total2 += course;

//    j++;
//}
//Console.WriteLine(total2 / 10);


//int totalScore = 0;

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("enter Course" + i.ToString());
//    int course = int.Parse(Console.ReadLine());

//    totalScore = totalScore + course;
//}

//int average = totalScore / 10;
//Console.WriteLine(average);


//int i = 5;
//Console.WriteLine(i++);
//int x = i++; // x = 5, i = 6

//int j = 5;
//Console.WriteLine(++j);
//int y = ++i; // x = 6, i = 6


//Console.WriteLine(x);
//Console.WriteLine(y);


//int number = 1;
//double number2 = 1.2;
//string name = "ali";

//int[] numbers = [1, 2, 3, 4, 5, 6];
// 1   2   3   4   5   6
// 0   1   2   3   4   5
//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers[1]);
//Console.WriteLine(numbers[2]);
//Console.WriteLine(numbers[3]);
//Console.WriteLine(numbers[4]);
//Console.WriteLine(numbers[5]);

//Console.WriteLine();

//double[] numbers2 = [1.2, 1.3, 1.4];
//Console.WriteLine(numbers2[0]);
//Console.WriteLine(numbers2[1]);
//Console.WriteLine(numbers2[2]);

//string[] names = ["ali", "reza", "mohammad"];
//Console.WriteLine(names[2]);
//Console.WriteLine(names[0]);
//Console.WriteLine(names[1]);

//string[] names2 = new string[5];
////"reza"  "mohammad" "ali"
////   0        1        2
//names2[0] = "reza";
//names2[1] = "mohammad";
////names2[2] = "ali";

//Console.WriteLine(names2[0]);
//Console.WriteLine(names2[1]);
//Console.WriteLine(names2[2]);


//Console.WriteLine("Enter your number");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine();
//for (int i = 1; i <= number; i++)
//{
//    Console.WriteLine(i);
//}


//int number = 3;
//Console.WriteLine(1);
//Console.WriteLine(2);
//Console.WriteLine(3);

//int number = int.Parse(Console.ReadLine());
//for (int i = 1; i <= number; i++)
//{
//    Console.WriteLine(i);
//}

//int number = 5;
//int[] numbers = [1, 5, 9, 7];
//// 1   5   9   7
//// 0   1   2   3
//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers[1]);
//Console.WriteLine(numbers[2]);
//Console.WriteLine(numbers[3]);

//نام دانش آموزان
//int count = int.Parse(Console.ReadLine());
//string[] names = new string[count];
//////names[0] = Console.ReadLine();
//////names[1] = Console.ReadLine();
//////names[9] = Console.ReadLine();

//for (int i = 0; i < count; i++)
//{
//    names[i] = Console.ReadLine();
//    //names[0] = ali;
//    //names[1] = reza;
//    //names[2] = mahmood;
//}

//Console.WriteLine("finish");


//Person person = new Person();
//Console.WriteLine(person.FirstName);
//Console.WriteLine(person.LastName);
//Console.WriteLine(person.Age);

//class Person
//{
//    public string FirstName = "ali";
//    public string LastName = "naderifar";
//    public int Age = 20;
//}


//int number = int.Parse(Console.ReadLine());
//double[] score = new double[number];

//for (int i = 0; i < 10; i++)
//{
//    score[i] = double.Parse(Console.ReadLine());
//}

//for (int i = 0; i < number; i++)
//{
//    Console.WriteLine(score[i]);
//}


//Car Samand = new Car();

//Console.WriteLine("enter Name");
//Samand.name = Console.ReadLine();
//Console.WriteLine("enter Brand");
//Samand.brand = Console.ReadLine();
//Console.WriteLine("enter Speed");
//Samand.speed = double.Parse(Console.ReadLine());
//Console.WriteLine("enter Color");
//Samand.color = Console.ReadLine();
//Console.WriteLine("Car Is Electric or no?");
//Samand.isElectric = bool.Parse(Console.ReadLine());
//Console.WriteLine("-------------------------------------------");
//Console.WriteLine(Samand.name);
//Console.WriteLine(Samand.brand);
//Console.WriteLine(Samand.speed);
//Console.WriteLine(Samand.color);
//Console.WriteLine(Samand.isElectric);

//public class Car
//{
//    public string name;
//    public string brand;
//    public double speed;
//    public string color;
//    public bool isElectric;
//}

// Student ali = new Student();
// ali.firstName = "Ali";
// ali.lastName = "Razavi";
// ali.age = 12;
//
// Student reza = new Student()
// {
//     firstName = "reza",
//     lastName = "Sabzika",
//     age = 12,
// };
//
//
// public class Student
// {
//     public string firstName;
//     public string lastName;
//     public int age;
// }

//1

// Person ali = new Person();
// ali.firstName = "Ali";
// ali.lastName = "razavi";
// ali.fatherName = "mahmod";
// ali.nationalCode = "1234567890";
// ali.dateOfBirth = new DateOnly(2025, 5, 10);
// ali.Gender = Gender.Male;
// ali.Age = 20;
// Console.WriteLine(ali.GetInfo());
//
// //2
// Person reza = new Person()
// {
//     firstName = "reza",
//     lastName = "zohrabi",
//     fatherName = "jafar",
//     nationalCode = "0987654321",
//     dateOfBirth = new DateOnly(2022, 5, 10),
//     Gender = Gender.Boy,
//     Age = 16
// };
// string fullName = reza.GetInfo();
// Console.WriteLine(fullName);
// // int age = ali.GetAge();
// // Console.WriteLine(age);
// // Console.WriteLine(reza.dateOfBirth);
// // Console.WriteLine(reza.Gender);
// // Console.WriteLine(reza.Age);
//
// public class Person
// {
//     public string firstName { get; set; }
//     public string lastName { get; set; }
//     public string fatherName { get; set; }
//     public string nationalCode { get; set; }
//     public DateOnly dateOfBirth { get; set; }
//     public Gender Gender { get; set; }
//     public int Age { get; set; }
//
//     public string GetInfo()
//     {
//         // return firstName + " " + lastName;
//         return $"{firstName} {lastName} {fatherName} {nationalCode} {dateOfBirth} {Gender} {Age}";
//     }
//     // public int GetAge()
//     // {
//     //     return Age;
//     // }
// }
//
//public enum Gender
//{
//    Male,
//    Female,
//    Boy,
//    Girl
//}


//Calculator calc1 = new Calculator()
//{
//    FirstNumber = 50,
//    SecondNumber = 10,
//    Operator = Operator.Subtract
//};


//if (calc1.Operator == Operator.Add)
//    Console.WriteLine(calc1.Add());
//else if (calc1.Operator == Operator.Multiply)
//    Console.WriteLine(calc1.Multiply());
//else if(calc1.Operator == Operator.Subtract)
//    Console.WriteLine(calc1.Subtract());
//else if (calc1.Operator == Operator.Divide)
//    Console.WriteLine(calc1.Divide());

//Console.ReadKey();

//public class Calculator
//{
//    public double FirstNumber { get; set; }
//    public double SecondNumber { get; set; }
//    public Operator Operator { get; set; }

//    public double Add()
//    {
//        return FirstNumber + SecondNumber;
//    }

//    public double Subtract()
//    {
//        return FirstNumber - SecondNumber;
//    }

//    public double Multiply()
//    {
//        return FirstNumber * SecondNumber;
//    }

//    public double Divide()
//    {
//        return FirstNumber / SecondNumber;
//    }
//}


//public enum Operator
//{
//    Add,
//    Subtract,
//    Multiply,
//    Divide
//}
//Rectangle rect2 = new Rectangle()
//{
//    Height = 50,
//    Width = 100
////};
//Console.WriteLine();
//Console.WriteLine("hello");

//Rectangle rect1 = new Rectangle();
//rect1.Width = 100;
//rect1.Height = 250;

//Console.WriteLine(rect1.Perimeter());
//Console.WriteLine(rect1.Area());
//Console.WriteLine(rect1.Area(1.2,2.5,"M"));
////Console.WriteLine(rect1.Area(50, rect1.Width, "m"));
//Console.ReadKey();

//public class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }


//    public double Area()
//    {
//        double area = Width * Height;
//        return area;
//    }

//    public string Area(double h, double w, string unit)
//    {
//        double area = h * w;
//        return $"{area} {unit}";
//    }

//    public double Perimeter()
//    {
//        return 2 * (Height + Width);
//    }
//}



//string name = "   reza zohraby   ";
//Console.WriteLine(name.Trim());


//Console.ReadKey();

//Circle circle = new Circle();
//Console.WriteLine(circle.Area(3));
//Console.WriteLine(circle.Perimeter(3));

//Console.ReadKey();

//public class Circle
//{ 
//    public double Area(double r)
//    {
//        return r * r * 3.14;
//    }

//    public double Perimeter(double r)
//    {
//        return 2 * r * 3.14;
//    }
//}



//class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }

//    public string ShowInfo()
//    {
//        Console.WriteLine();
//    }
//}





//using Csharp_Term2_Fall_1404.Entities;

//Calculator calculator = new Calculator();
//Console.WriteLine(calculator.Add(20, 30));
//Console.WriteLine(calculator.Mines(50, 50));
//Console.WriteLine(calculator.Multply());
//Console.WriteLine(calculator.Div());

//Console.WriteLine("hello");

//using Csharp_Term2_Fall_1404.Entities;

//Product product1 = new Product()
//{
//    Name = "Laptop",
//    Type = "Electronics",
//    Price = 1500.00,
//    DiscountPrice = 1200.00
//};

//product1.GetProductInfo();

using Csharp_Term2_Fall_1404.Entities;

Wallet myWallet = new Wallet();
myWallet.Balance = 2500.75;

myWallet.GetBalance();
myWallet.Deposit(500.25);
myWallet.GetBalance();
myWallet.Withdraw(4000);
myWallet.GetBalance();
