using System;



namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] data)
        {
            bool sortering = true;
            
            for (int i = 0; i < data.Length - 1 && sortering; i++)
            {
                
                sortering = false;
                
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    
                    if (data[j] > data[j + 1])
                    {
                        
                        sortering = true;
                      
                        int k = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = k;
                    }
                }
               
            }
        }
        static int[] Data(int m)
        {
            Random l = new Random();
            int[] data = new int[m];
            for (int i = 0; i < data.Length; i++)
                data[i] = l.Next(data.Length);
            return data;
        }
        static void Main(string[] args)
        {
            int[] n = new int[] { 100, 10000, 100000};
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Skapar slumpad data av längd " + n[i]);
                int[] data = Data(n[i]);
                Console.WriteLine("Sorterar slumpad data");
                DateTime startTid = DateTime.Now;
                BubbleSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera.\n", deltaTid.TotalMilliseconds);
                startTid = DateTime.Now;
                BubbleSort(data);
                deltaTid = DateTime.Now - startTid;

            }
        }
    }
}
