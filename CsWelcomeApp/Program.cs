using System;



static void Func()
{

}

//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Привет мир");

//int n = 10;

//float x;
//x = 20.5f;

//double y = 34.29;
//double z = 29.5e-3;

//int a = 0b10101001;
//int b = 0x12FA;

//char c = 'A';
//string s = "Hello";


//byte bb; //  0..255
//sbyte sb; //-128..127
//short sh; // -32768..32767
//ushort ush; // 0..65535
//int i;
//uint ui; // unsigned int
//long li;
//ulong uli; // unsigned long

//float fx;
//double dx;
//decimal mx;

//char ch = 'D';
//char chx = '\u0567';
//bool bf = true;

//string str;
//object obj;

//var res = false;


//string s1 = Console.ReadLine();
//Console.WriteLine(s1);

//Console.Write("Input age: ");
//int age = Convert.ToInt32(Console.ReadLine());

///*
//Convert.ToDouble();
//Convert.ToDecimal();
//Convert.ToSingle();
//Convert.ToByte()
//*/

///*
//+, -, *, /, %, ++, --
//a / (b * c)

//&, |, ~, <<, >>, ^
//*/

//// &&, &
//// ||, |
//// ^
//// !

//int count = 10;

//if (count == 5 & ++count > 0)
//    Console.WriteLine("True");

//Console.WriteLine(count);

///*
//<, >, <=, >=, !=, ==

//+=, -=, *=, /=, %=
//a = a + b >>> a += b

//&=, |=, ^=, <<=, >>=
//*/

//byte b1 = 10;
//int i1 = b1 + 20;
//byte b2 = (byte)(i1 + 5);
//// byte -> short -> int -> long -> decimal
//// int -> double
//// short -> float -> double
//// char -> int

//char ch2 = 'A';
//int code = ch2;

//if(true)
//{
//    // true
//}
//else
//{
//    // false
//}

//if(false)
//{

//}
//else if(false)
//{

//}
//else
//{

//}

//string op = (i1 > 0) ? ">0" : "<=0";

//string name = "Bob";

//switch(name)
//{
//    case "Joe":
//        Console.WriteLine("Joe!!!");
//        break;
//    case "Bob":
//        Console.WriteLine("Bobby!!!");
//        break;
//    default:
//        break;
//}

//byte month = 3;
//string title;

//switch(month)
//{
//    case 1: title = "Jan"; break;
//    case 2: title = "Feb"; break;
//    case 3: title = "March"; break;
//    default:
//        title = ""; break;
//}

//string mtitle = month switch
//{
//    1 => "Jan",
//    2 => "Feb",
//    3 => "March",
//    _ => ""
//};


//while()
//{

//}

//do
//{

//} while ();

//for (int i = 0; i < length; i++)
//{

//}

//// continue, break


int[] array = new int[] { 1, 2, 3 };
int[] arr1 = new[] { 1, 2, 3 };
string[] names = { "bob", "joe" };

for (int i = 1; i <= array.Length; i++)
    Console.Write(array[^i] + " ");

foreach(var item in names)
    Console.Write(item + " ");

array[0] = 10;

int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
//int[,,] cube = new int[2, 3, 4];

//for(int i = 0; i < matrix.Length; i++)
Console.WriteLine(matrix.GetLength(1));

int[][] ztable = new int[3][];
ztable[0] = new int[3];
ztable[1] = new int[5];
ztable[2] = new int[2];

Console.WriteLine(ztable.Length);
Console.WriteLine(ztable[1].Length);


static void Method()
{
    Code x = Code.Tula;
}


class MyClass
{

}

enum Days
{
    Mon = 10,
    Tue = -3,
    Wen
}

enum Code
{
    Tula = 71,
    Kursk = 40
}