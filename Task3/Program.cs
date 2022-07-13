// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива
   
void Main(double[] args)
{
            double[] argMass;
            Console.WriteLine("Input number of elements n=");
            int n = Convert.ToInt32(Console.ReadLine());
            argMass = new double[n];
            var random = new Random();

           for (int i = 0; i < argMass.Length; i++)
           {
               argMass[i] = random.Next(0, 100);
           }

           double numMax = arr[0], numMin = arr[0];

           for (int i = 1; i < argMass.Length; i++)

           {
               if (arr[i] > numMax) numMax = arr[i];
               if (arr[i] < numMin) numMin = arr[i];

           }

            Console.WriteLine($"Difference between Max and Min elements in massive: {numMin - numMax}");

           Console.ReadKey();
}
 double[] arr = new double[n];
 int n = Convert.ToInt32(Console.WriteLine("Input number of elements  "));
 Main(arr);



