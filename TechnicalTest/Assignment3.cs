using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Assignment3
    {
        public static List<Double> ExtractLargestNumbers(string pathToFile, int countOfNumbers)
        {
            var largestNumbers = new List<Double>(countOfNumbers);

            using (FileStream fs = File.Open(pathToFile, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                string thisLine = string.Empty;
                int counter = 0;
                double number = 0;

                while ((thisLine = sr.ReadLine()) != null)
                {
                    if (!Double.TryParse(thisLine, out number))
                    {
                        continue;
                    }

                    if (counter < countOfNumbers)
                    {
                        largestNumbers.Add(number);

                        if (counter == countOfNumbers - 1)
                        {
                            largestNumbers.Sort();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < countOfNumbers; i++)
                        {
                            if (number > largestNumbers[i])
                            {
                                largestNumbers.Remove(largestNumbers[i]);
                                largestNumbers.Add(number);
                                largestNumbers.Sort();
                                break;
                            }
                        }
                    }

                    counter++;
                }
            }

            return largestNumbers.OrderByDescending(o => o).ToList();
        }
    }
}