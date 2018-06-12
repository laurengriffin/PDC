using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibplctagWrapper;

namespace PDC_Lauren
{
    class PLCommunication
    {
        public string ipAddress;
        public string path;
        public CpuType cput;
        public string tagname;
        public int dtInt;
        public string dtString;
        public int elemCount;
        public bool writeToPlc;
        public string valToWrite;

        public PLCommunication(string ipAddress, string path, string slot, string cput, string tagname, string dtString, int elemCount, bool writeToPlc, string valToWrite)
        {
            this.ipAddress = ipAddress;
            // path format
            if (string.IsNullOrEmpty(path))
            {
                this.path = "";
            }
            else
            {
                if (string.IsNullOrEmpty(slot))
                {
                    this.path = path;
                }
                else
                {
                    this.path = path + "," + slot;
                }
            }
            // cpu type format
            if (cput.Equals("LGX"))
            {
                this.cput = CpuType.LGX;
            }
            else if (cput.Equals("SLC"))
            {
                this.cput = CpuType.SLC;
            }
            else if (cput.Equals("PLC5"))
            {
                this.cput = CpuType.PLC5;
            }
            this.tagname = tagname;
            // data type format
            this.dtString = dtString;
            if (this.dtString == "Int16")
            {
                this.dtInt = DataType.Int16;
            }
            else if (this.dtString == "Int8")
            {
                this.dtInt = DataType.Int8;
            }
            else if (dtString == "Int32")
            {
                this.dtInt = DataType.Int32;
            }
            else if (dtString == "Float32")
            {
                this.dtInt = DataType.Float32;
            }
            else if (dtString == "String")
            {
                this.dtInt = DataType.String;
            }
            this.elemCount = elemCount;
            this.writeToPlc = writeToPlc;
            this.valToWrite = valToWrite;
        }

        public PLCommunication(string ipAddress, string cput, string tagname, string dtString, int elemCount, bool writeToPlc, string valToWrite)
        {
            this.ipAddress = ipAddress;
            // cpu type format
            if (cput.Equals("LGX"))
            {
                this.cput = CpuType.LGX;
            }
            else if (cput.Equals("SLC"))
            {
                this.cput = CpuType.SLC;
            }
            else if (cput.Equals("PLC5"))
            {
                this.cput = CpuType.PLC5;
            }
            this.tagname = tagname;
            this.dtString = dtString;
            // data type format
            this.dtString = dtString;
            if (this.dtString == "Int16")
            {
                this.dtInt = DataType.Int16;
            }
            else if (this.dtString == "Int8")
            {
                this.dtInt = DataType.Int8;
            }
            else if (dtString == "Int32")
            {
                this.dtInt = DataType.Int32;
            }
            else if (dtString == "Float32")
            {
                this.dtInt = DataType.Float32;
            }
            else if (dtString == "String")
            {
                this.dtInt = DataType.String;
            }
            this.elemCount = elemCount;
            this.writeToPlc = writeToPlc;
            this.valToWrite = valToWrite;
        }

    }
}
