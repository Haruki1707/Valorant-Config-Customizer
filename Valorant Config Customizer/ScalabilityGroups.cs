using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorant_Config_Customizer
{
    class ScalabilityGroups
    {
        public int Index;
        public string Name;
        public string Parameter;
        public string Value;
        List<string> GUSlines;

        public string GetValue(string name, List<string> guslines)
        {
            Name = name;
            Parameter = "sg." + name.Replace(" ", "");
            GUSlines = guslines;

            string stringline = GUSlines.Where(t => t.Contains(Parameter)).FirstOrDefault();
            int index = GUSlines.IndexOf(stringline);
            string value = stringline.Replace(Parameter + "=", "");
            if (index != 0)
            {
                Index = index;
                Value = value;
            }

            return Value;
        }

        public void SetValue(string value)
        {
            Value = value;
            GUSlines[Index] = Parameter + "=" + Value;
        }
    }
}
