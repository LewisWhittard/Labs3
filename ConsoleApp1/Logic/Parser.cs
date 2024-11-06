using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Logic
{
    public class Parser
    {
        public int GetIntFromString(string prompt)
        {
            try
            {
                return Convert.ToInt32(prompt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string GetIntFromString(int prompt)
        {
            try
            {
                return Convert.ToString(prompt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
