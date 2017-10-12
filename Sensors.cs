using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOS
{
    public class Sensors
    {
        
        public double accelerometer, gyroscope;
        public int altimeter, temperature;
        public bool touchdown = false;
        public Sensors()
        {

        }
        public  Sensors (double accelerometer, int altimeter, int temperature, bool touchdown, double gyroscope)
        {
            this.Accelerometer = accelerometer;
            this.Altimeter = altimeter;
            this.Temperature = temperature;
            this.Touchdown = touchdown;
            this.Gyroscope = gyroscope;
        } 
        
        public double Accelerometer {
            get { return accelerometer; }
            set
            {
                accelerometer = 200;
            }
        }
        public double Gyroscope
        {
            get {
                return gyroscope;}
            set
            {
                gyroscope = 45;
            }
        }
        public bool Touchdown
        {
            get { return touchdown; }
            set { touchdown =false; }
        }
        public int Temperature
        {
            get { return temperature; }
            set
            {
                temperature = 55;
            }
        }
        public int Altimeter
        {
            get { return altimeter; }
            set
            {
                altimeter = 100;
            }
        }
    }
    
}
