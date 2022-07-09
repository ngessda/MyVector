using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    public class Class1
    {
        public static MyVectory[] ReadVectors(string filePath)
        {
            var vectorList = new List<string>(); 
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) 
            {
                var temp = line.Trim(); 

                if (IsValidLine(temp)) 
                {
                    vectorList.Add(temp); 
                }
            }

            
            var vectors = new MyVectory[vectorList.Count];

            for (int i = 0; i < vectorList.Count; i++)
            {
                
                vectors[i] = GetVector(vectorList[i]);
            }

            return vectors; 
        }

      
        public static void WriteSortedVectors(MyVectory[] vectors, string path)
        {
            var sb = new StringBuilder(); 

          
            var resVecs = SortedVectors(vectors);

            foreach (var vec in resVecs)
            {
                
                sb.Append(vec.lengthVector.ToString()) 
                    .Append(" ") 
                    .AppendLine(vec.ToString()); 
            }

            File.WriteAllText(path, sb.ToString()); 
        }

       
        public static MyVectory[] SortedVectors(MyVectory[] vectors)
        {
            var newVecs = (MyVectory[])vectors.Clone(); 

           
            foreach (var vecs in newVecs)
            {
                vecs.Sort();
            }

           
            for (int i = 0; i < newVecs.Length; i++)
            {
                for (int j = 0; j < newVecs.Length - (i + 1); j++)
                {
                    if (newVecs[j].lengthVector > newVecs[j + 1].lengthVector)
                    {
                        var temp = newVecs[j];
                        newVecs[j] = newVecs[j + 1];
                        newVecs[j + 1] = temp;
                    }
                }
            }

            return newVecs; 
        }

       
        private static bool IsValidLine(string line)
        {
            var elems = line.Split(' '); 
            bool result = true; 

            try
            {
                
                int.Parse(elems[0]);
            }
            catch
            {
              
                result = false;
                return result; 
            }

            
            for (int i = 1; i < elems.Length; i++)
            {
                try
                {
                    double.Parse(elems[i]);
                }
                catch
                {
                    result = false;
                    
                    break;
                }
            }

            return result; 
        }

        
        private static MyVectory GetVector(string line)
        {
            var elems = line.Split(' '); 
            int size = int.Parse(elems[0]); 
            var data = new double[size]; 

            for (int i = 1; i < elems.Length; i++)
            {
                data[i - 1] = double.Parse(elems[i]); 
            }

            var result = new MyVectory(data);
            return result; 
        }
    }
}
