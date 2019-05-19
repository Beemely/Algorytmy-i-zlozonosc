using AlgorytmyDominikKacprza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace algorytym
{
    public partial class Form1 : Form
    {
        int x = 0;
        long y = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //Algorytm Euklidesa NWD
        private void Button2_Click(object sender, EventArgs e)
        {
            AlgorytmEuklidesa algorytmEuklidesa = new AlgorytmEuklidesa();
            if (textBoxPierwszaLiczbaEuklidesa.Text != "" && textBoxDrugaLiczbaEuklidesa.Text != ""
                && Int32.TryParse(textBoxPierwszaLiczbaEuklidesa.Text, out x) && Int32.TryParse
                (textBoxDrugaLiczbaEuklidesa.Text, out x))
            {
                int pierwsza = Int32.Parse(textBoxPierwszaLiczbaEuklidesa.Text);
                int druga = Int32.Parse(textBoxDrugaLiczbaEuklidesa.Text);
                WynikEuklidesa.Text = algorytmEuklidesa.CountEuklides(pierwsza, druga);
            }
            else MessageBox.Show("Input numbers");
        }

        //L doskonala
        private void button_LiczbaDoskonala_Click(object sender, EventArgs e)
        {
            LiczbaDosk liczbaDosk = new LiczbaDosk();
            string asd = liczbaDosk.LiczbaDoskCounter();
            MessageBox.Show(liczbaDosk.LiczbaDoskCounter());
        }

        //PESEL
         private void button1_Click(object sender, EventArgs e)
        {
            Pesel pesel = new Pesel();

            if (textBox_PESEL.Text != "" && long.TryParse(textBox_PESEL.Text, out y) 
                && textBox_PESEL.Text.Length == 11)
            { 
                MessageBox.Show(pesel.CheckPesel(textBox_PESEL.Text));
            }
            else if (textBox_PESEL.Text.Length < 11)
            {
                MessageBox.Show("Pesel is too short");
            }
            else MessageBox.Show("Write your pesel");
            
        }

        //kolorwanie mapy
        private void Wczytaj_Click(object sender, EventArgs e)
        {
            BitMap bitMap = new BitMap();
            DialogResult wynikOtwierania = openFileDialog1.ShowDialog();

            if (wynikOtwierania == DialogResult.OK)
            {
                Bitmap Obrazek = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                bitMap.KolorujMape(Obrazek);
                Obrazek.Save(openFileDialog1.FileName + " .png");
                MessageBox.Show("Done");              
            }
        }
        
        //BubbleSort
        private void SortButton_Click(object sender, EventArgs e)
        {
            string[] richTextBox = richTextBox_BubbleSort.Lines;
                       
            int[] tab = new int[richTextBox.Length];

            for (int i = 0; i < richTextBox.Length; i++)
            {
                try
                {
                    Int32.Parse(richTextBox[i]);
                }
                catch (Exception)
                {

                    richTextBox[i] = "0";
                }
                tab[i] = Int32.Parse(richTextBox[i]);
            }

            BubbleSort bubbleSort = new BubbleSort();
            richTextBox_BubbleSort.Clear();
            richTextBox_BubbleSort.Text = bubbleSort.sort(tab);
            
        }
     
        //Fibonacci
        private void Button3_Click(object sender, EventArgs e)
        {
           if (textBoxFibItN.Text != "" && long.TryParse(textBoxFibItN.Text, out y))
            {
                Fibonacci fibonacci = new Fibonacci();
                textBoxShowFib.Text = fibonacci.FibonacciIteracja(Int32.Parse(textBoxFibItN.Text));
            }
            else textBoxShowFib.Text = "wprowadz liczbe";            
        }

        private void ButtonFibRek_Click(object sender, EventArgs e)
        {  
            if (textBoxFibRekN.Text != "" && long.TryParse(textBoxFibRekN.Text, out y))
            {
                if (long.Parse(textBoxFibRekN.Text) <= 0)
                {
                    textBoxFibRek.Text = "N-ty wyraz ciagu nie moze byc rowny, badz mniejszy od 0";
                }else
                {
                    Fibonacci fibonacci = new Fibonacci();

                    long[] cached = new long[long.Parse(textBoxFibRekN.Text) + 1];
                    textBoxFibRek.Text = "N-ty wyraz ciagu wynosi: " + fibonacci.FiibonacciRekurencja
                        (long.Parse(textBoxFibRekN.Text), ref cached).ToString();
                }
            }
            else textBoxFibRek.Text = "wprowadz liczbe";
        }

        //odwracanie kolorow **To Do
        private void ButtonWczytajPNG_Click(object sender, EventArgs e)
        {
            BitMap bitMap = new BitMap();
            DialogResult wynikOtwierania = openFileDialog1.ShowDialog();

            if (wynikOtwierania == DialogResult.OK)
            {
                Bitmap Obrazek = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                bitMap.OdwrocKolory(Obrazek);
                Obrazek.Save(openFileDialog1.FileName + " .png");
                MessageBox.Show("Done");

            }
        }
        //Sum of multiples 3, 5
        private void ButtonCheck3or5_Click(object sender, EventArgs e)
        {
            Multiples3or5 multiples3Or5 = new Multiples3or5();
            textBox1.Text = multiples3Or5.CheckSumOfMultiples();
        }
        //check the highest palindrom
        private void ButtonPali_Click(object sender, EventArgs e)
        {
            Palindrom palindrom = new Palindrom();
            textBoxPali.Text = palindrom.FindPalindrom();
        }
        //Smallest multiple 
        private void ButtonSmallestMultiply_Click(object sender, EventArgs e)
        {
            SmallestMultiple smallestMultiple = new SmallestMultiple();
            textBoxSmallestMultiple.Text = smallestMultiple.CheckSmallestMultiple();
        }

        //Calletz
        private void ButtonCheckCollatz_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxNumber.Text, out x) && Int32.Parse(textBoxNumber.Text) != 0)
            {
                Calletz calletz = new Calletz();

                textBoxCollatz.Text = calletz.CheckCalletz(Int32.Parse(textBoxNumber.Text));
            }
            else textBoxCollatz.Text = "Input number";

        }

        private void CheckLongestCalletz_Click(object sender, EventArgs e)
        {
            Calletz calletz = new Calletz();

            textBoxLongestChain.Text = calletz.CheckLongestCalletzUnderMilion();

        }        
    }
}

