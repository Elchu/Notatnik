using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    {

        public static string FindText = "";
        public static bool WielkoscLiter;
        public static string ZamienTekst = "";
        public string sciezkaPliku = "";
        private int szukanyIndex;


        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(richTextBox1.Text != "")
            {
                if (sciezkaPliku == "")
                {
                    DialogResult opcja = MessageBox.Show("Czy chcesz zapisać zmiany w pliku?", "Notatnik", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (opcja == DialogResult.OK)
                        saveToolStripMenuItem_Click(sender, e);
                    else if (opcja == DialogResult.No)
                        richTextBox1.Clear();
                }
                else
                    richTextBox1.Clear();
            }
            


        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                //zapisujemy sciezke do otwartego pliku aby moc pozniej zapisywac do niego bez ponownego wybierania pliku
                sciezkaPliku = openFileDialog1.FileName;
                //wyswietla w notatniku nazwe pliku otworzonego
                this.Text = sciezkaPliku;
            }
                
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (sciezkaPliku != "")
                richTextBox1.SaveFile(sciezkaPliku, RichTextBoxStreamType.PlainText);
            else
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FileName = "";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    //zapisujemy sciezke do pliku aby moc pozniej zapisywac do niego bez ponownego wybierania pliku
                    sciezkaPliku = openFileDialog1.FileName;
                }
                    
            }
            
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0)
            {
                wytnijToolStripMenuItem.Enabled = true;
                kopiujToolStripMenuItem.Enabled = true;
                wklejToolStripMenuItem.Enabled = true;
                zaznaczWszystkoToolStripMenuItem.Enabled = true;
            }
            else
            {
                wytnijToolStripMenuItem.Enabled = false;
                kopiujToolStripMenuItem.Enabled = false;
                wklejToolStripMenuItem.Enabled = false;
                zaznaczWszystkoToolStripMenuItem.Enabled = false;
            }
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dataICzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString();
        }

        private void szukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find znajdz = new Find();
            znajdz.ShowDialog();

            if (FindText != "")
               szukanyIndex = richTextBox1.Find(FindText);
        }

        private void nastęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FindText != "")
                if(WielkoscLiter)
                    szukanyIndex = richTextBox1.Find(FindText, (szukanyIndex + 1), richTextBox1.Text.Length, RichTextBoxFinds.MatchCase);
                else
                    szukanyIndex = richTextBox1.Find(FindText, (szukanyIndex + 1), richTextBox1.Text.Length, RichTextBoxFinds.None);
        }

        private void zastąpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace zamien = new Replace();
            zamien.ShowDialog();

            richTextBox1.Find(FindText);
            richTextBox1.SelectedText = ZamienTekst;            
        }

        private void zawijajTekstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.WordWrap == true)
                richTextBox1.WordWrap = false;
            else
                richTextBox1.WordWrap = true;
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void kolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void kolorCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void zaznaczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void zaznaczKolorWyróżnieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void oMnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sciezkaPliku == "")
            {
                DialogResult opcja = MessageBox.Show("Czy chcesz zapisać zmiany w pliku?", "Notatnik", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (opcja == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);
             
            }
        }
    }
}
