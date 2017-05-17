using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal
{
    class Program
    {
        static void Main(string[] args)
        {
            // To get the value from the signal

            // Create the MATLAB instance 
            MLApp.MLApp matlab = new MLApp.MLApp();

            // Change to the directory where the function is located 
            matlab.Execute(@"cd C:\Users\Suzanne\Desktop");

            // Define the output 
            object result = null;
            // Call the funtion with the path
            string path = "Dist 5cm Puiss 50%.csv";
            matlab.Feval("valeur_signal", 1, out result,path);

            // Display result
            object[] res = result as object[];
            // res[0] is the value
            Console.WriteLine(res[0]);
            //Console.ReadLine();

            // To map
 
            
            /*
            MLApp.MLApp matlab = new MLApp.MLApp()

            matlab.Execute(@"cd C:\Users\Suzanne\Desktop");

            object result1 = null;

            // Creation of the path for saving the image in png format

            string path1 = "...";
            object[] values =... ; // tab of values
            object[] positions =... ; // tab of positions
            
            matlab.Feval("mapping", 2, out result1, values, positions ,path1);


            object[] res1 = result1 as object[];

            Console.WriteLine(res[0]); // max of values
            Console.WriteLine(res[1]); // min of values
            */
        }
    }
}
