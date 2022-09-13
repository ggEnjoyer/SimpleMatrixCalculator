using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator1
{
    internal static class CustomGlobalFunctionsAndObjects
    {
        [Conditional("DEBUG")]
        public static void DebugMessage(string message)
        {
            System.Windows.MessageBox.Show(message);
        }
    }
}
