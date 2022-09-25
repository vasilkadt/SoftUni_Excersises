using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            int lineCounter1 = 0;
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                while (!reader1.EndOfStream)
                {
                    reader1.ReadLine();
                    lineCounter1++;
                }
            }

            int lineCounter2 = 0;
            using (StreamReader reader2 = new StreamReader(secondInputFilePath))
            {
                while (!reader2.EndOfStream)
                {
                    reader2.ReadLine();
                    lineCounter2++;
                }
            }

            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                string line1 = reader1.ReadLine();
                using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    string line2 = reader2.ReadLine();
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        if (lineCounter1 >= lineCounter2)
                        {
                            while (!reader2.EndOfStream)
                            {
                                writer.WriteLine(line1);
                                writer.WriteLine(line2);

                                line1 = reader1.ReadLine();
                                line2 = reader2.ReadLine();
                            }
                            writer.WriteLine(line1);
                            writer.WriteLine(line2);
                            line1 = reader1.ReadLine();
                            while (!reader1.EndOfStream)
                            {
                                writer.WriteLine(line1);
                                line1 = reader1.ReadLine();
                            }
                            writer.WriteLine(line1);
                        }
                        else
                        {
                            while (!reader1.EndOfStream)
                            {
                                writer.WriteLine(line1);
                                writer.WriteLine(line2);

                                line1 = reader1.ReadLine();
                                line2 = reader2.ReadLine();
                            }

                            writer.WriteLine(line1);
                            writer.WriteLine(line2);

                            line2 = reader2.ReadLine();
                            while (!reader2.EndOfStream)
                            {
                                writer.WriteLine(line2);
                                line2 = reader2.ReadLine();
                            }
                            writer.WriteLine(line2);
                        }
                    }
                }
            }
        }
    }
}
