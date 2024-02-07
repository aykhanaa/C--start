///// AcademyWork


//int age = 30;
//Console.WriteLine(age);


//int n = 10;
//int m = 100;

//int sum = n + m;

//Console.WriteLine(sum);


//bool isMarried = true;

//if (isMarried == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}



//int[] arr = { 1, 2, 3, 4, 5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine (i);
//}
//Console.WriteLine("//////////");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}


//int a = 1;
//int b = 100;

//for (int i = a; i <= b; i++)
//{
//    Console.WriteLine(i);
//}



//1-100 arasında 2-2 artirmaq

//int a = 1;
//int b = 100;

//for (int i = a; i <= b; i+=2)
//{
//    Console.WriteLine(i);
//}



//1-100 arasinda cütlər

//int a = 1;
//int b = 100;

//for (int i = a; i <= b; i++)
//{ 
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//} 


///// 1-100 kimi təklərin cəmi
//int a = 1;
//int b = 100;
//int sum = 0;
//for (int i = a; i <= b; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//string[] words = { "salam", "sagol", "muellim", "salam" };

//int count = 0;

//for (int i = 0; i < words.Length; i++)
//{
//    if (words[i]=="salam")
//    {
//       count++;
//    }
//}

//// Console.WriteLine(count);





//HomeWork






///1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.


//int n = 0;

//if (n % 21 == 0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}

///2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//int n = 2;
//int m = 4;
//int sum = 0;
//if (n % 2 == 0 && m % 2 == 0)
//{
//    sum = m + n;

//    Console.WriteLine(sum);
//}

///3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.


//int n = 2;
//int m = 8;
//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//      sum += i;
//    }

//}
//Console.WriteLine(sum);

///4) Verilmish arrayin icindeki tek ededlerin cemini tapin.


//int[] arr = { 3, 4, 2, 7, 9, 8, 5 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] %2==1 )
//    {
//        sum += arr[i];
//    }
//}
//Console.WriteLine(sum);

///5) Verilmish arrayin icindeki cut ededlerin sayini tapin.


//int[] arr = { 4, 5, 8, 7, 9, 2 };
//int count = 0;
//for (int i = 0; i <arr.Length; i++)
//{
//    if (arr[i]%2 == 0)
//    {
//        count = arr[i];
//        Console.WriteLine(count);
//    }
//}

///6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.


//int n= 4;
//int m= 19;
//int count = 0;
//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console .WriteLine(count);

///7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.


//int n = 5;
//int m = 14;
//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }

//}
//Console.WriteLine(sum);


/////8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//int n = 5;
//int m = 12;
//int count = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);



///// 9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.


//int n = 1;
//int count = 0;

//if (n < 2)

//    Console.WriteLine("Ne sade, ne murekkeb");

//for (int i = 1; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        count++;
//    }
//}
//if (count == 2)
//{
//    Console.WriteLine("Sade");

//}
//else
//{
//    Console.WriteLine("Murekkeb");
//}