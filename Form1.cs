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

namespace Amino_Acids
{
    public partial class Form1 : Form
    {
        private int newLabel;
        private int leftMargin;
        private int counter;

        private const int THRESHOLD = 2;
        private const int MOVE_RIGHT_AMOUNT = 40;

        public Form1()
        {
            InitializeComponent();
            this.newLabel = 1;
            this.leftMargin = 25;
            this.counter = 0;
        }

        // Create a dictionary that maps codons to amino acids
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
            Label uuu = new Label();
            this.Controls.Add(uuu);
            uuu.Top = newLabel * 25;

            if(counter == THRESHOLD)
            {
                leftMargin += MOVE_RIGHT_AMOUNT;
                counter = 0;
            }
            uuu.Left = leftMargin;

            uuu.Text = codon;
            newLabel++;
            counter++;
        
            return uuu;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }


        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {
            addNewLabel("UUU");
        }
    }
}
