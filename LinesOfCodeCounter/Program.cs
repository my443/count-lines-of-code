using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace LinesOfCodeCounter
{
    internal class Program
    {
        // This is the list that stores your count.
        List<string[]> listOfFilesAndCount = new List<string[]>();

        static void Main(string[] args)
        {
            string[] directories = getDirectories(@"C:\Users\jvand\AppData\Roaming\DBeaverData\workspace6\General\scripts");
            string[] listOfFiles;

            foreach (string directory in directories)
            {
                listOfFiles = getFiles(directory, ".sql");

                foreach (string file in listOfFiles)
                {
                    string[] row = countRowsOfCode(file);
                    Console.WriteLine("{0},{1}", row[0], row[1]);
                }
            }





            Console.WriteLine("Done.");
            Console.ReadKey();
        }

        /// <summary>
        /// Gets a list of all of the directories and sub-directories starting at a given top directory. 
        /// </summary>
        /// <param name="topDirectory"></param>
        /// <returns></returns>
        static string[] getDirectories(string topDirectory) {

            string[] dirs = Directory.GetDirectories(topDirectory, "*", SearchOption.AllDirectories);

            List<string> returnDirs = new List<string>();

            returnDirs.Add(topDirectory);
            returnDirs.AddRange(dirs);

            string[] returnDirectoriesArray = returnDirs.ToArray();

            return returnDirectoriesArray;

        }

        static string[] getFiles (string targetDirectory, string targetExtension)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            List<string> returnFiles = new List<string>();
            
            foreach(string entry in fileEntries)
            {
                string extension = Path.GetExtension(entry);
                if(extension == targetExtension)
                {
                    returnFiles.Add(entry);
                }
            }

            return returnFiles.ToArray();

        }
        /// <summary>
        /// Returns the number of rows of code for a given filepath.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        static string[] countRowsOfCode(string filepath)
        {
            string[] row = new string[2];
            int lineCount = File.ReadLines(filepath).Count();

            row[0] = filepath;
            row[1] = lineCount.ToString();

            return row;
        }


        /// <summary>
        /// Saves the list of files to a csv.
        /// </summary>
        /// <param name="list"></param>
        private void saveToCSV(List<string[]> list)
        {
            //
        }
    }
}
