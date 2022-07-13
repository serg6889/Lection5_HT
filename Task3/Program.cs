// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива
   
void Main(int n)
{
            double[] argMass;
            
            argMass = new double[n];
            var random = new Random();

           for (int i = 0; i < argMass.Length; i++)
           {
               argMass[i] = random.Next(0, 100);
           }

           double numMax = argMass[0], numMin = argMass[0];

           for (int i = 1; i < argMass.Length; i++)

           {
               if (argMass[i] > numMax) numMax = argMass[i];
               if (argMass[i] < numMin) numMin = argMass[i];

           }

            Console.WriteLine($"Difference between Max and Min elements in massive: {numMax - numMin}");

           Console.ReadKey();
}

Console.WriteLine("Input number of elements n=");
int n = Convert.ToInt32(Console.ReadLine());
 Main(n);

