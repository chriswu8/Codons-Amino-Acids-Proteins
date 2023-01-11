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
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            Application.Run(form1);

            Button clearButton = new Button();
            clearButton.Text = "Clear all";
            clearButton.Location = new Point((form1.Width - clearButton.Width) / 2, (form1.Height - clearButton.Height) / 2);
            clearButton.Size = new Size(100, 25);
            form1.Controls.Add(clearButton);

            clearButton.Size = new Size(40, 40);
        }
    }
}
