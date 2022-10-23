using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            StreamWriter outputFile;
            string fileText = "";
            string input = "";
            
            //Output file is labeled 'myFile.txt'
            outputFile = File.CreateText("myFile.txt");
            //i and count both start at 1
            int i = 1;
            int count = 1;

            string inputText = System.IO.File.ReadAllText("C:/Users/austi/Desktop/test_text.txt").ToLower();
            input = inputText;
            //Logic below was adopted from Chegg and adapted to meet my needs.
            //Read contents from input file
            while (i < inputText.Length)
            {
                //checking for all characters that are and are not letters
                if ((inputText[i] == '.' || inputText[i] == ' ' || inputText[i] == '\t' || inputText[i] == '!' 
                    || inputText[i] == ',' || inputText[i] == '?' || inputText[i] == '\n') 
                    && (inputText[i - 1] == 't' || inputText[i - 1] == 'e' || inputText[i - 1] == 'T' || inputText[i - 1] == 'E'))
                {
                    count++;
                    
                }
                //Write contents to output file
                outputFile.WriteLine("There are " + count + " words ending in the letters t or e in the text file.");
                i++;
                
            }
            
            //Write contents to console
            Console.Write("There are " + count + " words ending in the letters t or e in the text file with the contents: \n\n" + inputText 
                            + "\n\n All contents above have been written to a file named: 'myFile.Txt'");
            
        }
    }
}