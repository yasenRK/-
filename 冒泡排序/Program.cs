using System;
namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            // 准备排序的数组
            int[] data = new int[10];
            Random random = new Random();
            int counter = 0;
            while(counter<10)
            {
                int temp = random.Next(0, 100);
                data[counter] = temp;
                counter++;

            }
            Console.WriteLine("排序前的数字顺序:");
            PrintData(data);
           
            Console.WriteLine();
            Console.WriteLine("排序后的数字顺序:");
            //PrintData(BubbleSort1(data));
            //PrintData(BubbleSort2(data));
            //PrintData(BubbleSort3(data));
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

        static int[] BubbleSort3(int[] data)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        int temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            return data;
        }
        
        static int[] BubbleSort2(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }
        static int[] BubbleSort1(int[] data)
        {
            for(int i=0;i<data.Length-1;i++)
            {
                int exchangedIndex = 0;
                    int endIndex = data.Length - 1 - i;
                for(int j=0;j<=endIndex-1;j++)
                {
                    if(data[j]>data[j+1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                        exchangedIndex = i;//记录最后一次交换的位置，下次只需要比较到这里即可

                    }
                }
                endIndex = exchangedIndex;
            }
            return data;
        }
    }
   
}
