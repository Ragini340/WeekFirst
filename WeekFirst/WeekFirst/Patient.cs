using System;
using System.IO;

namespace WeekFirst
{
    class Patient
    {
        int ID;
        string Name;
        long Phone_No;
        int BillAmount;
       
        public static void Main()
        {
            
            Patient patient = new Patient();
            
            Console.WriteLine("Enter Patient ID");
            int id = Convert.ToInt32(Console.ReadLine());
            patient.ID = id;

            Console.WriteLine("Enter Patient Name");
            string name = Console.ReadLine();
            patient.Name = name;

            Console.WriteLine("Enter Patient Mobile NO");
            long Mob_No = Convert.ToInt64(Console.ReadLine());
            patient.Phone_No = Mob_No;

            Console.WriteLine("Enter Patient Bill");
            int bill = Convert.ToInt32(Console.ReadLine());
            patient.BillAmount = bill;

            patientDetails(patient);
            Console.ReadKey();

            FileStream f = new FileStream("C://Users/RRagini/source/repos/WeekFirst.CSV", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            s.BaseStream.Seek(0, SeekOrigin.Begin);
            while (!s.EndOfStream){
                string line = s.ReadLine();
                Console.WriteLine(line);
            }
         
            s.Close();
            f.Close();
           
        }
        public static void patientDetails(Patient patient)
        {
            StreamWriter obj = new StreamWriter("C://Users/RRagini/source/repos/WeekFirst.CSV");

            obj.Write("ID" + "  " + "Name" + "  " + "Mobile Number" + "  " + "Bill");
            obj.WriteLine();
            obj.Write(patient.ID + " ");

            obj.Write(patient.Name + " ");
            obj.Write(patient.Phone_No + " ");
            obj.Write(patient.BillAmount);

            obj.Flush();
            obj.Close();
        }
       
    }
}
 

