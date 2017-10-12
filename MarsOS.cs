using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOS
{
    class MarsOS
    {/* Team: E
        Program: Mars OS
        Programmer: Ryan Barbera
        Last Update:10/8/2017
        Description: Handles control of lander and sends sensor data to database upon safe landing
        */

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.ReadLine();
            int numEngineWarmUpAltitude=1000, numEngineCutOffAltitude=250, numAxialEngineThrust=0;
            bool flightContour;
            bool parachute, touchdown = false;
            int numAltimeter = 0 ;
            bool rollEngines, axialEngines, axialEnginesHot;
            bool accelerationDescent;//predetermined descent acceleration
          
            bool phase1 = true, phase2 = false, phase3 = false, phase4 = false, phase5 = false;

            while (phase1 = true)
            {
                trajectory();
                if ( numAltimeter <= numEngineWarmUpAltitude)
                {
                    Console.WriteLine("Success!");
                    phase1 = false;
                    phase2 = true;
                    engines();
                }
                else phase1 = true;
            }
            while (phase2 = true)
            {
                trajectory();
                int numRollEngineThrust = 100;

                if (axialEnginesHot = true)
                {
                    parachute = false;
                    phase2 = false;
                    phase3 = true;
                    numAxialEngineThrust = 100;
                }
                else
                {
                    phase2 = true;
                }
            }
            while (phase3 = true)
            {
                if (flightContour = true)
                {
                    numAxialEngineThrust = 50;
                }
                else
                {
                    numAxialEngineThrust = 100;

                }
                if (numAltimeter <= numEngineCutOffAltitude)
                {
                    axialEngines = false;
                    rollEngines = false;
                    phase3 = false;
                    phase4 = true;
                }
                if (touchdown = true)
                {
                    axialEngines = false;
                    rollEngines = false;
                    phase3 = false;
                    phase5 = true;
                }
                else
                {
                    phase3 = true;
                }
            }
            while (phase4 = true)
            {
                bool freeFall = true;
                if (touchdown = true)
                {
                    phase5 = true;
                }
                else
                    phase4 = true;
            }
            while (phase5 = true)
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=rbarbera.mydevryportfolio.com;Initial Catalog=rbarbera_cis470;User ID=rbarbera_cis470;Password=cis470";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    Console.WriteLine("Connection Open ! ");
                    //Will send all sensor data to database
                    cnn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection ! ");
                }
                
                
            }
            TerminateApplication();

        }
        public static void TerminateApplication()
        {
           
            Console.Write("Thank you.  Press any key to terminate the program...");
            Console.ReadLine();
        }

        static void engines()
        {
            bool axialEnginesWarmUp = true;
            bool rollEnginesOn = true;
        }

        public static void alt (Sensors altimeter)
        {

        }
       
        static void trajectory()
        {
            //determines trajectory based off of parachute
            int xVelocity, yVelocity, zVelocity;

        }
        
    }
}
