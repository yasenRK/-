using System;
using System.Diagnostics;
namespace 插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            // 准备排序的数组
            int[] data = new int[100000];
            Random random = new Random();
            int counter = 0;
            while (counter < 100000)
            {
                int temp = random.Next(0, 100000);
                data[counter] = temp;
                counter++;

            }
            Console.WriteLine("排序前的数字顺序:");
            //PrintData(data);
            Console.WriteLine();
            Console.WriteLine("排序后的数字顺序:");
            //PrintData(InsertSort(data,out long time1));
            InsertSort(data, out long time1);
            Console.WriteLine($"插入排序运行了{time1.ToString()}时间");
            Console.WriteLine("优化排序后的数字顺序:");
            //PrintData(OPtimzedInsertSort(data,out long time2));
            OPtimzedInsertSort(data, out long time2);
            Console.WriteLine($"优化插入排序运行了{time2.ToString()}时间");
            
            Console.ReadKey();
        }
        

        static int[] OPtimzedInsertSort(int[] data,out long time)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int begin = 1; begin < data.Length; begin++)
            {
                int index = begin;
                int tmp = data[begin];
                while(index>0)
                {
                    // 从数组的头位置开始找比tmp大的元素记为targetData
                    // 把targetData到tmp之间的元素都往后退一个位置
                    for (int i = 0; i < index; i++)
                    {
                        if(data[i]>tmp)
                        {
                                // 把j 放在j+1
                            for (int j = index-1; j>i; j--)
                            {
                                data[j + 1] = data[j];
                            }
                        }
                    }

                    index--;
                }

            }
            watch.Stop();
           time= watch.ElapsedTicks;
            return data;
        }

        static int[] InsertSort(int[] data,out long time)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int begin = 1; begin < data.Length; begin++)
            {
                int index = begin;
                while(index>0)
                {
                    if(data[index]<data[index-1])
                    {
                        int temp = data[index];
                        data[index] = data[index - 1];
                        data[index - 1] = temp;
                    }
                    index--;
                }
            }
            watch.Stop();
           time= watch.ElapsedTicks;
            return data;
        }

        static void PrintData(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item.ToString());
                Console.Write(",");
            }
        }

    }
    
}
