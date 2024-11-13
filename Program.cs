using System;

class Program
{                      // Modtafa Firas Otoom 
                       // ID : 202310507 
    static void Main()
    {
        try
        {
            
            Console.Write("enter minNumber: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("enter maxNumber: ");
            int maxNumber = int.Parse(Console.ReadLine());


            if (minNumber > maxNumber)
            {
                Console.WriteLine(" minNum should be less than or equal to maxNum.");
                return;
            }

            int[] frequency = new int[maxNumber - minNumber + 1];

            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int randomNumber = random.Next(minNumber, maxNumber + 1);
                frequency[randomNumber - minNumber]++;
            }

           
            Console.WriteLine("\nNumber\tFrequency");
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine($"{minNumber + i}\t{frequency[i]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
