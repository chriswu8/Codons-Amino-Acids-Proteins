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
        /// Lab 1 - Codon to Amino Acid Converter 
        /// Author: Chris Wu 
        /// Date: January 10th, 2023
        /// 
        /// This program converts codons into their corresponding amino acids.
        /// It also showcases the concept of amino acid redundancy 
        /// (and resiliency to DNA mutation) through color groupings.
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
