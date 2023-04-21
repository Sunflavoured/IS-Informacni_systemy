Console.WriteLine("****Generator nahodnych cisel****");

Console.WriteLine("zadejte počet generovanych cisel");
int n = 0;
while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Znovu");
}
int minNum = IOlib.inputNumber("Zadejte spodní hranici", "Znovu");
int maxNum = IOlib.inputNumber("Zadejte horní hranici", "Znovu");

Console.WriteLine("{0},{1},{2},", n, minNum, maxNum);

Random randomNum = new Random();
int[] arr = new int[n];

for (int i = 1; i < arr.Length; i++)
{
    arr[i] = randomNum.Next(minNum, maxNum + 1);
    Console.Write("{0}; ", arr[i]);
}

int maxHodnota = arr[0];
int minHodnota = arr[0];
int poziceMin = 0;
int poziceMax = 0;
for (int i = 1; i < n; i++)
{
   if(arr[i]>maxHodnota)
           {
            maxHodnota = arr[i];
            poziceMax = i;
           }

        if(arr[i]<minHodnota)
            {
             minHodnota = arr[i];
             poziceMin = i;
            }  
 
}

Console.WriteLine("\n\nmax: {0} na pozici {2} min: {1} na pozici {3}",
maxHodnota, minHodnota, poziceMax, poziceMin);

Console.ReadLine();