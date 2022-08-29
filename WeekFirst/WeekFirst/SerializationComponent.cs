using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeekFirst
{
   public class SerializationComponent
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.id = 101;
            emp1.name = "Ragini";
            emp1.address = "Bangalore";
            emp1.salary = 5000;
            empList.Add(emp1);

            Employee emp2 = new Employee();
            emp2.id = 111;
            emp2.name = "Rita";
            emp2.address = "Channai";
            emp2.salary = 4000;
            empList.Add(emp2);
            //Save list of employee records in xml file.
            saveAsXml(empList);
            //Load employee record from Xml file.
            empList = LoadXmlData();
            foreach (Employee emp in empList) Console.WriteLine(emp.name);

        }

        static List<Employee> LoadXmlData()
        {
            var fs = new FileStream("Employee.xml", FileMode.Open, FileAccess.Read);
            var formatter = new XmlSerializer(typeof(List<Employee>));
            var list = formatter.Deserialize(fs) as List<Employee>;
            fs.Close();
            return list;
        }

        static void saveAsXml(List<Employee> empList)
        {
            var fs = new FileStream("Employee.xml", FileMode.OpenOrCreate, FileAccess.Write);
            var formatter = new XmlSerializer(typeof(List<Employee>));//Should privide the Type Info of the class that U R serializing. 
            formatter.Serialize(fs, empList);
            fs.Close();
        }
        [Serializable]
        public class Employee
        {
            public int id;
            public string name, address;
            public int salary;

        }
  } 
}

