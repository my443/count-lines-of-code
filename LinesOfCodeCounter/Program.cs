using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LinesOfCodeCounter
{
    internal class Program
    {
        // This is the list that stores your count.
        List<string[]> listOfFilesAndCount = new List<string[]>();

        static void Main(string[] args)
        {
            string[] directories = getDirectories(@"C:\Users\jvand\OneDrive\Desktop");

        }

        /// <summary>
        /// Gets a list of all of the directories and sub-directories starting at a given top directory. 
        /// </summary>
        /// <param name="topDirectory"></param>
        /// <returns></returns>
        static string[] getDirectories(string topDirectory) {

            string[] dirs = Directory.GetDirectories(topDirectory, "*", SearchOption.AllDirectories);

            return dirs;

        }

        /// <summary>
        /// Returns the number of rows of code for a given filepath.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        private string[] countRowsOfCode(string filepath)
        {
            string[] row = new string[2];

            return row;
        }

        /// <summary>
        /// Checks whether the file has the desired extension.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        private bool checkExtension(string filepath, string extension)
        {
            bool hasExtension = false;

            return hasExtension;

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
