using System;
namespace 选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            // 准备排序的数组
            int[] data = new int[10];
            Random random = new Random();
            int counter = 0;
            while (counter < 10)
            {
                int temp = random.Next(0, 100);
                data[counter] = temp;
                counter++;

            }
            Console.WriteLine("排序前的数字顺序:");
            PrintData(data);
            Console.WriteLine();
            Console.WriteLine("排序后的数字顺序:");
            PrintData(SelectionSort(data));
            Console.ReadKey();
        }
        static void PrintData(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item.ToString());
                Console.Write(",  ");
            }
        }
        static int[] SelectionSort(int[] data)
        {
            for(int i=0;i<data.Length;i++)
            {
                int max = data[0];
                int exchangedIndex =0;

                for(int j=0;j<data.Length-i;j++)
                {
                    if(data[j]>max)
                    {
                        max = data[j];
                        exchangedIndex = j;
                    }
                }
                int temp = data[data.Length - 1 - i];
                data[data.Length -1-i] = max;
                data[exchangedIndex] = temp;
                max = data[0];
            }
            return data;
        }
    }
    
}
