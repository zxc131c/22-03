using System;

class Program{

static void Main(string[] args){

 Console.WriteLine("введите размер массива:");
 int n = int.Parse(Console.ReadLine());
 int[] arr = new int[n];
 Console.WriteLine($"введите {n} целых чисел для заполнения массива:");

for (int i = 0; i < n; i++){
    arr[i] = int.Parse(Console.ReadLine());
}
    int max = arr[0];
    for (int i = 1; i < n; i++){

     if (arr[i] > max){
     max = arr[i];
   }
 }
        int maxFn = arr.Max();

     int min = arr[0];
     for (int i = 1; i < n; i++){

     if (arr[i] < min){
     min = arr[i];
  }
}
         int minFn = arr.Min();

     int sum = 0;
     for (int i = 0; i < n; i++){

      sum += arr[i];
}
        double avg = (double)sum / n;


    Console.WriteLine("введите значение для поиска:");
    int search = int.Parse(Console.ReadLine());
    int index = -1;

    for (int i = 0; i < n; i++){
    if (arr[i] == search){

    index = i;
    break;
    }
}
    Console.WriteLine($"индекс элемента {search}: {index}");


      int count = 0;
      for (int i = 0; i < n; i++){

       if (arr[i] == search){

      count++;
    }
}
            int countFn = arr.Count(x => x == search);


        int sumCycle = 0;
        int productCycle = 1;
        for (int i = 0; i < n; i++) {

         sumCycle += arr[i];
         productCycle *= arr[i];
 }


            int sumFn = arr.Sum();
            int productFn = arr.Aggregate((a, b) => a * b);

        Console.WriteLine($"максимальное значение в массиве: {max}");
        Console.WriteLine($"минимальное значение в массиве: {min}");
        Console.WriteLine($"среднее значение массива: {avg}");
        Console.WriteLine($"количество элементов со значением {search}: {count}");
        Console.WriteLine($"сумма значений в массиве: {sumCycle}");
        Console.WriteLine($"произведение значений в массиве: {productCycle}");
    }
}
