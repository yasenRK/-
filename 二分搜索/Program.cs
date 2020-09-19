using System;

namespace 二分搜索
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
                //int temp = counter * 2 + 1;
                data[counter] = temp;
                counter++;

            }
            Console.WriteLine("原始数组如下");
            PrintData(data);
            //int index = BinarySearch(data, 101);
            //Console.WriteLine();
            //Console.WriteLine("查找的索引是{0}", index);
            Console.WriteLine("排序后的数组");
            PrintData(OptimizeInsertSortByBinarySearch(data));
            Console.ReadKey();

        }

        static int[] OptimizeInsertSortByBinarySearch(int[] data)
        {
            for (int begin = 1; begin < data.Length - 1; begin++)
            {
                int index = begin;
                int start = 0;
                int tmp = data[index];
                int targetIndex = -1;
                int middle = (index + start) / 2;
                // 0->index这段数据是有序的
                // 0->index的索引之间找出小于和大于tmp的两个数字或者等于tmp的数字
                if(data[start]==tmp)
                {
                    targetIndex = start + 1;
                }else if(data[start]<tmp)
                {
                    targetIndex = start;
                }
                start++;
                while(targetIndex!=-1 && index%start!=1)
                {
                    if(data[middle]==tmp)
                    {
                        targetIndex = middle + 1;
                    }else if(data[middle]>tmp)
                    {
                        index = middle;
                    }else if(data[middle]<tmp)
                    {
                        start = middle;
                    }
                    middle = (index + start) / 2;
                }
                if()

            }    return data;
        }


        static int BinarySearch(int[] datas,int? data)
        {
            int index = -1;
            if (datas == null || datas.Length == 0 || data == null)
                return index;
            int begin = 1;// 考虑到后面做除法，为了排除除数等于0的情况，从第二个元素开始，第一个元素单独拿出来判断
            int end = datas.Length - 1;
            int middle = (begin + end) / 2;
            if (datas[0] == data)
            {
                index = 0;
                return index;
            }
            while(end%begin!=1)
            {
                // 判断中间值是否等于data
               if(datas[middle]==data)
                {
                    index = middle;
                    return index;
                }else if(datas[middle]>data)// 中间值大于data，取前半部分
                {
                    end = middle;
                }else// 取后半部分
                {
                    begin = middle;
                }
                middle = (begin + end) / 2;

            }
            // 最后比较begin和end是否等于data
            if (datas[begin] == data)
            {
                index = begin;
                
            }
            else if (datas[end] == data)
            {
                index = end;
            } 
            return index;

        }
        static void PrintData(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item.ToString());
                Console.Write(",  ");
            }
        }
    }
}
