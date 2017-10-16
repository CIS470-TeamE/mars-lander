using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOS
{
    public class Sensors
    {
        
        public double accelerometer, gyroscope;
        public int altimeter, temperature;
        public bool touchdown = false, dataSent=false;
      
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
        public void sendData()//sends data to database
        {
            Sensors sense = new Sensors();
            double Accelleration = sense.accelerometer;
            int altimeter = sense.altimeter;
            int temperature = sense.temperature;
            bool touchdown = sense.touchdown;
            double gyroscope = sense.gyroscope;
            OleDbConnection con = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SeniorProject.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            string query1 = "Insert into Accelerometers(Acceleration) Values ('" + Accelleration + "')";
            string query2 = "Insert into Altimeter (Altitude) Values ('"+altimeter+"')";
            string query3 = "Insert into DopplerRadar(Reading) Values ('" + temperature + "')";
            string query4 = "Insert into Gyroscopes(Orientation) Values('" + gyroscope + "')";
            string query5 = "Insert into Touchdown(Success) Values('" + touchdown + "')";
            try
            {
                cmd.CommandText = query1 + query2 + query3 + query4 + query5;
                cmd.Connection = con;
                //cmd.ExecuteNonQuery();

                Console.WriteLine("Record Submitted"+" Congrats");

                con.Close();
            }
            catch
            {
                Console.WriteLine("connection failed");
            }

            
        }
        public double Accelerometer {
            
            get { return accelerometer; }
            set
            {

                double accX=5, accY=3, accZ=5;
                accelerometer = accX+accY+accZ;
            }
           
        }
        
        public double Gyroscope
        {
            get { return gyroscope; }
            set
            {
                double dPitch=5, dRoll=5, dYaw=10;
                gyroscope = dPitch+dRoll+dYaw;
            }
        }
        public bool Touchdown
        {
            get { return touchdown; }
            set {
                if (altimeter == 0)
                {
                    touchdown = true;
                }
                else
                {
                    touchdown =false; 
                }
                }
        }
        public int Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
            }
        }
        public int Altimeter
        {
            get { return altimeter; }
            set
            {
                altimeter = value;
               /* int i = 1000;
                while (i >= 0)
                {
                    altimeter = i;
                    i= i-50;
                }*/
                
            }
        }

       
    }
    
}
