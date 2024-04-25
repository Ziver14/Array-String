namespace Array_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[]asd = new int[3];//одномерный массив
            Console.WriteLine(asd[1]);

            int[,] asd1 = new int[3, 2];//двухмерный массив
            int[][]asd2 = new int[3][];//зубчатый массив(массив с массивами)
            
            asd2[0] = new int[] { };//инициализация массива

            int[]ss = new int[] { 1, 2, 3, 4, 5 };

            foreach (int i in ss)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("++++++++++++++++++++++++++++");

            int chet = 0, nechet = 0, unique = 0;
            int[]arr = new int[] { 2,6,7,8,12,47,2,5,6};

            foreach (var i in arr)
            {
                if (i % 2 == 0)
                    chet++;
                else
                    nechet++;

            }

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if(isUnique) unique++;
            }

            Console.WriteLine(chet);
            Console.WriteLine(nechet);
            Console.WriteLine(unique);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

            int[] arr2 = new int[] {2,4,8,6,9,7,5,12,5 };

            Console.WriteLine("Ввседите ограничение");
            int count=0;
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            foreach (int i in arr2)
            {if (i < n)
                    count++;
            }
            Console.WriteLine(count);

            Console.WriteLine("\n");

            

            int[,] arr3 = new int[3, 3] { 
                { 2, 2,  32 }, 
                { 4, 6,  71 }, 
                { 10, 2, 12 } 
            };
            int min = arr3[0, 0];
            int max = arr3[0, 0];

            //Первое решение
            /*foreach (int i in arr3)
            {
                foreach (var j in arr3)
                {
                    if (i < min) min = i;
                    if (j < min) min = j;
                    if (i > max) max = i; 
                    if (j > max) max = j; 
                }
            }
           

            int rows = arr3.GetLength(0);
            int cols = arr3.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr3[i, j] > max) max = arr3[i, j];
                    if (arr3[i, j] < min) min = arr3[i, j];
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] words = str.Split(" ");
            Console.WriteLine(words.Length);*/

            Console.WriteLine("Введите строку");
            string str2 = Console.ReadLine();
            string [] words1 = str2.Split(' ');

            for(int i = 0; i  < words1.Length;i++)
            {
                words1[i] = new string(words1[i].Reverse().ToArray());
                Console.Write(words1[i] + ' ');
            }

            //1. Интерпаляция
            int num = 10;
            string str3 = $"ценап:{num}";

            //2. Метод string.format

            string str4 = String.Format("Format {0},{1}", num, str2);

            //3.Метод Concat
            string str5 = String.Concat("Asssaaasd", num);

            //4. Сложение строк
            string str6 = str4 + str3;
        }
    }
}
