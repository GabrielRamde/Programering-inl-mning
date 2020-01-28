using System;



namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] data)
        {
            bool sortering = true;  //Påståendet nedanför är sant
            
            for (int i = 0; i < data.Length - 1 && sortering; i++) //for loop för alla tal som ska sorteras
            {
                
                sortering = false; //Börja om med en till sortering
                
                for (int j = 0; j < data.Length - 1 - i; j++) //for loop gå igenom talen igen, (inte talen i variabel "i")
                {
                    
                    if (data[j] > data[j + 1])  //Flyttar fram större tal
                    {
                        
                        sortering = true;   //Fortsätta sortera
                        //byter plats på talen
                        int k = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = k;
                    }
                }
                         //ifall inga tal är sorterar stoppar sortering = false; loopen
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
                Console.WriteLine("Skapar slumpad data av längd " + n[i]);    //timer "DateTime" för att räkna utt hur lång tid det tog att sortera talen
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
