using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();

            XmlElement studentElement = xmlDocument.CreateElement("student");

            XmlElement fullNameElement = xmlDocument.CreateElement("fullname");
            fullNameElement.InnerText = "Иванов Иван Иванович";
            XmlElement ageElement = xmlDocument.CreateElement("age");
            ageElement.InnerText = "18";
            XmlElement facultyElement = xmlDocument.CreateElement("faculty");
            facultyElement.InnerText = "Энергетический";
            XmlElement groupElement = xmlDocument.CreateElement("group");
            groupElement.InnerText = "ЭЭ-101";

            studentElement.AppendChild(fullNameElement);
            studentElement.AppendChild(ageElement);
            studentElement.AppendChild(facultyElement);
            studentElement.AppendChild(groupElement);

            xmlDocument.AppendChild(studentElement);

            xmlDocument.Save("SecondTask.txt");

            Process.Start("notepad.exe", "SecondTask.txt");
        }
    }
}
