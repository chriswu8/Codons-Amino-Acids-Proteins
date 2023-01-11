using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Amino_Acids
{
    public partial class Form1 : Form
    {
        private int newLabel;
        private int leftMargin;
        private int topMargin;
        private int counter;

        private const int THRESHOLD = 12;
        private const int MOVE_RIGHT_AMOUNT = 75;
        private const int WIDTH_SHAVE = 27;
        private const int INITIAL_LEFT = 25;

        // The Form1 constructor
        public Form1()
        {
            InitializeComponent();
            this.newLabel = 1;
            this.leftMargin = 25;
            this.topMargin = 25;
            this.counter = 0;
        }

        // A dictionary that maps codons to amino acids
        Dictionary<string, string> codonToAminoAcid = new Dictionary<string, string>()
        {
            {"UUU", "Phenylalanine"},
            {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"},
            {"UUG", "Leucine"},
            {"UCU", "Serine"},
            {"UCC", "Serine"},
            {"UCA", "Serine"},
            {"UCG", "Serine"},
            {"UAU", "Tyrosine"},
            {"UAC", "Tyrosine"},
            {"UAA", "STOP"},
            {"UAG", "STOP"},
            {"UGU", "Cysteine"},
            {"UGC", "Cysteine"},
            {"UGA", "STOP"},
            {"UGG", "Tryptophan"},
            {"CUU", "Leucine"},
            {"CUC", "Leucine"},
            {"CUA", "Leucine"},
            {"CUG", "Leucine"},
            {"CCU", "Proline"},
            {"CCC", "Proline"},
            {"CCA", "Proline"},
            {"CCG", "Proline"},
            {"CAU", "Histidine"},
            {"CAC", "Histidine"},
            {"CAA", "Glutamine"},
            {"CAG", "Glutamine"},
            {"CGU", "Arginine"},
            {"CGC", "Arginine"},
            {"CGA", "Arginine"},
            {"CGG", "Arginine"},
            {"AUU", "Isoleucine"},
            {"AUC", "Isoleucine"},
            {"AUA", "Isoleucine"},
            {"AUG", "Methionine"},
            {"ACU", "Threonine"},
            {"ACC", "Threonine"},
            {"ACA", "Threonine"},
            {"ACG", "Threonine"},
            {"AAU", "Asparagine"},
            {"AAC", "Asparagine"},
            {"AAA", "Lysine"},
            {"AAG", "Lysine"},
            {"AGU", "Serine"},
            {"AGC", "Serine"},
            {"AGA", "Arginine"},
            {"AGG", "Arginine"},
            {"GUU", "Valine"},
            {"GUC", "Valine"},
            {"GUA", "Valine"},
            {"GUG", "Valine"},
            {"GCU", "Alanine"},
            {"GCC", "Alanine"},
            {"GCA", "Alanine"},
            {"GCG", "Alanine"},
            {"GAU", "Aspartic acid"},
            {"GAC", "Aspartic acid"},
            {"GAA", "Glutamic acid"},
            {"GAG", "Glutamic acid"},
            {"GGU", "Glycine"},
            {"GGC", "Glycine"},
            {"GGA", "Glycine"},
            {"GGG", "Glycine"}
        };

        private Label addNewLabel(String codon)
        {
            Label aminoAcid = new Label();
            this.Controls.Add(aminoAcid);

            if(counter == THRESHOLD)
            {
                leftMargin += MOVE_RIGHT_AMOUNT;
                newLabel = 1;
                counter = 0;
            }
            aminoAcid.Top = newLabel * topMargin;
            aminoAcid.Left = leftMargin;

            aminoAcid.Text = codonToAminoAcid[codon];
            newLabel++;
            counter++;

            aminoAcid.Width = aminoAcid.Width - WIDTH_SHAVE;
            return aminoAcid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewLabel("UGU");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            addNewLabel("UAA");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            addNewLabel("UUG");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            addNewLabel("CCU");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            addNewLabel("AAU");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNewLabel("GGG");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            addNewLabel("GAA");
        }


        private void button47_Click(object sender, EventArgs e)
        {
            addNewLabel("UUC");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            addNewLabel("UUU");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            addNewLabel("UUA");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            addNewLabel("CUU");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            addNewLabel("CUC");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            addNewLabel("CUA");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            addNewLabel("CUG");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            addNewLabel("AUU");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            addNewLabel("AUC");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            addNewLabel("AUA");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            addNewLabel("AUG");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            addNewLabel("GUU");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            addNewLabel("GUC");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            addNewLabel("GUA");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            addNewLabel("GUG");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            addNewLabel("UCU");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            addNewLabel("UCC");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            addNewLabel("UCA");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            addNewLabel("UCG");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            addNewLabel("CCC");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            addNewLabel("CCA");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            addNewLabel("CCG");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            addNewLabel("ACU");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            addNewLabel("ACC");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            addNewLabel("ACA");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            addNewLabel("ACG");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            addNewLabel("GCU");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            addNewLabel("GCC");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            addNewLabel("GCA");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            addNewLabel("GCG");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            addNewLabel("UAU");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            addNewLabel("UAC");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            addNewLabel("UAG");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            addNewLabel("CAU");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            addNewLabel("CAC");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            addNewLabel("CAA");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            addNewLabel("CAG");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            addNewLabel("AAC");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            addNewLabel("AAA");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            addNewLabel("AAG");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            addNewLabel("GAU");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            addNewLabel("GAC");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            addNewLabel("GAG");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNewLabel("UGC");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNewLabel("UGA");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNewLabel("UGG");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNewLabel("CGU");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNewLabel("CGC");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNewLabel("CGA");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNewLabel("CGG");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addNewLabel("AGU");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addNewLabel("AGC");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addNewLabel("AGA");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addNewLabel("AGG");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addNewLabel("GGU");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addNewLabel("GGC");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addNewLabel("GGA");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }


        private void removeLabel(Label l)
        {
            this.Controls.Remove(l);
            l.Dispose();
            l = null;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            foreach (Label l in this.Controls.OfType<Label>())
            {
                removeLabel(l);
            }

            newLabel = 1;
            counter = 0;
            leftMargin = INITIAL_LEFT;
        }

    }
}
