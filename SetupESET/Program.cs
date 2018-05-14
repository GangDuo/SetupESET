using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SetupESET
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bin = null;
            if (Environment.Is64BitOperatingSystem)
            {
                bin = Properties.Resources.ees_nt64_JPN;
            }
            else
            {
                bin = Properties.Resources.ees_nt32_JPN;
            }

            var msi = Path.Combine(Path.GetTempPath(), "ees_nt_JPN.msi");
            File.WriteAllBytes(msi, bin);
            Process.Start(msi);
        }
    }
}
