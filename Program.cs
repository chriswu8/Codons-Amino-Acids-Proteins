using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amino_Acids
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// This program converts codons into their corresponding amino acids,
        /// and showcases the concept of amino acid redundancy through color groupings.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            Application.Run(form1);
        }
    }
}
