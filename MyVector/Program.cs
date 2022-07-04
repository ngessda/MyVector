using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyVectory mv = new MyVectory("C:\\Users\\micky\\Downloads\\vectors.txt");
            Console.ReadKey();
        }
    }
}
/*
 *             int count = 0;
            bool flag = true;
            bool c = true;
            string[] str = File.ReadAllLines(path);
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i][j] == ',' || str[i][j] == ' ')
                    {
                        count++;
                    }
                }
            }
            count -= 4;
            double[,] vector = new double[count, 2];
            int counter = 0;
            for(int i = 0; i < str.Length; i++)
            {
                flag = true;
                string s = "";
                int k;
                for (int j = 0; j < str[i].Length; j++)
                {
                    c = true;
                    s = "";
                    if (flag)
                    {
                        k = 0;
                        while (str[i][j + k] != ' ' && str[i][j + k] != '\n')
                        {
                            if (str[i][j + k] == ',')
                            {
                                c = false;
                                break;
                            }
                            s += str[i][j + k];
                            k++;
                        }
                        if (Double.TryParse(s, out double number) && c)
                        {
                            vector[counter, 0] = number;
                            j += k;
                            flag = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        k = 0;
                        while (str[i][j + k] != ',' && str[i][j + k] != '\n')
                        {
                            if (str[i][j + k] == ' ')
                            {
                                c = false;
                                break;
                            }
                            s += str[i][j + k];
                            k++;
                        }
                        if (Double.TryParse(s, out double number) && c) 
                        {
                            vector[counter, 1] = number;
                            counter++;
                            j += k;
                            flag = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            //for (int i = 0; i < vector.Length - 1; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(vector[i, j]);
            //        Console.Write(",");
            //    }
            //    Console.WriteLine();
            //}
            ShakerSort(vector, count);
            string resPath = @"C:\Users\micky\Desktop\note.txt";
            string sPid = vector.ToString();

*/
/*
 * string a;
            string trash = "";
            string str = File.ReadAllText(path, Encoding.UTF8);
            List<double> list = new List<double>();
            for (int i = 0; i < str.Length; i++)
            {
                a = "";
                if (str[i] == '+')
                {
                    Console.WriteLine(i);
                    Console.WriteLine(str[i]);
                }
                int x = 0;
                while (str[i + x] != ' ' && str[i + x] != ',' && str[i + x] != '\n')
                {
                    a += str[i + x];
                    x++;
                }
                i += x;
                if (double.TryParse(a, out var b))
                {
                    list.Add(b);
                }
                else if (list.Count % 2 != 0)
                {
                    trash += list.Last() + " ";
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    if (str[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        int c = 0;
                        trash += a + ",";
                        while (str[i + c] != ',')
                        {
                            c++;
                        }
                        i += c;
                    }
                }
            }
            Console.WriteLine(trash);

*/