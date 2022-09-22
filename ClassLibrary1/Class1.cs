using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Management;

namespace ClassLibrary1
{
    class Programa_ejemplo
    {
        static void Main(string[] args)
        {

            ManagementObjectSearcher searcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            List<string> listProcessor = new List<string>();
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                listProcessor.Add(wmi_HD["ProcessorID"].ToString());
            }
            //En listProcessor tenemos todos los procesadores del equipo en que se está ejecutando el software
            //Por ejemplo en listProcessor[0] tenemos el id de la primera CPU de nuestra máquina.
        }
    }
}
