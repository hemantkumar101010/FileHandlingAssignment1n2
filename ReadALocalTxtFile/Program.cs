using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadALocalTxtFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //First Assignment
            ReadFromTxtFile readFromTxtFile = new ReadFromTxtFile();
            readFromTxtFile.ReadFile(); 


            //Second assignment
            ReadAllMatchingStatus readNetworkLogFile = new ReadAllMatchingStatus();

            //Prints all records having "Success" status
            readNetworkLogFile.ReadFile("Success");
            //Prints all records having "Failed" status
            readNetworkLogFile.ReadFile("Failed");

            //Prints all records having "Missed" status
            readNetworkLogFile.ReadFile("Missed");
            ////Prints all records having "Dialled" status
            readNetworkLogFile.ReadFile("Dialled");


        }
    }
}
