
//int number = 5;
//int[] arr = { -9,23,5, 78,5};
//int counter=0;
//foreach (int item in arr)
//{
//    if(item== number)
//    {
//        counter++;
//    }
//}
//Console.WriteLine(counter);



//Console.WriteLine(Sum(4, 5)); //4,5 - arguments
//int Sum(int n1,int n2) //n1, n2 parametrs
//{
//    int total = n1 + n2;
//    return total;
//}
//Console.WriteLine(Sum(40, 50));

//int FindNumber(int searchNumber, int[] arr)
//{
//    int counter = 0;
//    foreach (int item in arr)
//    {
//        if (item == searchNumber)
//        {
//            counter++;
//        }
//    }
//    return counter;
//}

//int number = 5;
//int[] arr = { -9, 23, 5, 78, 5 };

//Console.WriteLine(FindNumber(number,arr));
//Console.WriteLine(FindNumber(3,new int[]{1,2,3,4,5,6 }));

//void Fullname(string name,string surname)
//{
//    Console.WriteLine(name+" "+surname);
//}

//Fullname("Kamran", "jabiyev");
//Fullname("Leyla", "Gulmemmedova");
//Fullname("Elmir", "Gulcohreli");

void Compare(int a,int b)
{
    if (a > b)
    {
        Console.WriteLine(a);
        return;
    }
    Console.WriteLine(b);
}

Compare(5, -6);
