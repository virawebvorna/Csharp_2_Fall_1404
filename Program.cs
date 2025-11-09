
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
int count = int.Parse(Console.ReadLine());
string[] names = new string[count];
////names[0] = Console.ReadLine();
////names[1] = Console.ReadLine();
////names[9] = Console.ReadLine();

for (int i = 0; i < count; i++)
{
    names[i] = Console.ReadLine();
    //names[0] = ali;
    //names[1] = reza;
    //names[2] = mahmood;
}

Console.WriteLine("finish");


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