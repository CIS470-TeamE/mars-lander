using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
            
            Sensors sense = new Sensors();
            sense.sendData();
            int altimeter = sense.altimeter;
            double accelerometer = sense.accelerometer;
            double gyroscope = sense.gyroscope;
            bool touchdown = sense.touchdown;
            int temperature = sense.temperature;
            //test data
            
            altimeter = 2000;
            

            Console.WriteLine("Welcome");
            Console.ReadLine();
            int numEngineWarmUpAltitude=1600, numEngineCutOffAltitude=350, numAxialEngineThrust=0;
            bool flightContour = true;
            bool parachute;
            
            bool rollEngines, axialEngines, axialEnginesHot=false;
            bool accelerationDescent;//predetermined descent acceleration

            bool phase1 = true, phase2 = false, phase3 = false, phase4 = false, phase5 = false;
           
            
                

                while (phase1 == true)
                {
                    trajectory();
                    if (altimeter <= numEngineWarmUpAltitude)
                    {

                        phase1 = false;
                        phase2 = true;
                        engines();
                        Console.WriteLine("phase 1 complete" + Convert.ToString(altimeter));
                    sense.sendData();

                }
                    else phase1 = true;
                altimeter = altimeter - 50;
                
            }
                while (phase2 == true)
                {
                    trajectory();
                    int numRollEngineThrust = 100;
                axialEnginesHot = true;

                if (axialEnginesHot == true)
                    {
                        parachute = false;
                        phase2 = false;
                        phase3 = true;
                        numAxialEngineThrust = 100;
                        Console.WriteLine("phase 2 complete" + Convert.ToString(altimeter));
                    sense.sendData();


                }
                    else
                    {
                        phase2 = true;
                    
                }
                }
                while (phase3 == true)
                {
                    
                    if (flightContour == true)
                    {
                        numAxialEngineThrust = 50;
                    }
                    else
                    {
                        numAxialEngineThrust = 100;

                    }
                    if (altimeter <= numEngineCutOffAltitude)
                    {
                        axialEngines = false;
                        rollEngines = false;
                        phase3 = false;
                        phase4 = true;
                        Console.WriteLine("phase 3 complete" + Convert.ToString(altimeter));
                    sense.sendData();
                }
                    else
                    {
                        phase3 = true;
                    altimeter = altimeter - 50;

                }
                    if (touchdown == true)
                    {
                        axialEngines = false;
                        rollEngines = false;
                        phase3 = false;
                        phase5 = true;
                        Console.WriteLine("touchdown complete" + Convert.ToString(altimeter));
                    sense.sendData();
                }
                    
                }
                while (phase4 == true)
                {
                if (altimeter == 0)
                {
                    touchdown = true;
                }
                    bool freeFall = true;
                    if (touchdown == true)
                    {
                        phase5 = true;
                        phase4 = false;
                        Console.WriteLine("phase 4 complete" + Convert.ToString(altimeter));
                    sense.sendData();
                }
                else
                {
                    phase4 = true;
                    altimeter = altimeter - 50;

                }
                        
                }
                while (phase5 == true)
                {
                    Console.WriteLine("phase 5 complete" + Convert.ToString(altimeter));

                    sense.sendData();
                phase5 = false;

              
            }
            TerminateApplication();

            }
        public static void TerminateApplication()
        {
           
            Console.WriteLine("Thank you.  Press any key to terminate the program...");
            Console.ReadLine();
        }

        static void engines()
        {
            int i = 0;
            while (i < 101)
            {
                i=i + 5;
            }
            if (i == 100)
            {
                bool axialEnginesWarmUp = true;
                bool rollEnginesOn = true;

            }
           
        }

        
       
        static void trajectory()
        {
            //determines trajectory based off of parachute
            int xVelocity, yVelocity, zVelocity;

        }
        
    }
}
