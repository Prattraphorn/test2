using System;

public class Program
{
    public static void Main()
    {
        float[] numbers = new float[1000];
        int count = 0;
        while (true)
        {
            Console.Write("Enter a number");
            string input = Console.ReadLine();
            if (input.ToLower() == "end")
            {
                break;
            }
            float number;
            if (float.TryParse(input, out number))
            {
                numbers[count] = number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        Console.Write("Enter mode: ");
        string mode = Console.ReadLine();

        if (mode == "FindMax")
        {
            float max = numbers[0];
            for (int i = 1; i < count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Maximum value: " + max);
        }
        else if (mode == "FindMin")
        {
            float min = numbers[0];
            for (int i = 1; i < count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Minimum value: " + min);
        }
        else if (mode == "FindMean")
        {
            float sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }
            float mean = sum / count;
            Console.WriteLine("Mean value: " + mean);
        }
        else
        {
            Console.WriteLine("Invalid mode");
        }
    }
}
