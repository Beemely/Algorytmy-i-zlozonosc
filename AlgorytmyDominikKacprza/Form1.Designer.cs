namespace algorytym
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPageKolorowanieMapy = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.Wczytaj = new System.Windows.Forms.Button();
            this.tabPagePesel = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PESEL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageDosk = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button_LiczbaDoskonala = new System.Windows.Forms.Button();
            this.tabPageNWD = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.WynikEuklidesa = new System.Windows.Forms.TextBox();
            this.textBoxDrugaLiczbaEuklidesa = new System.Windows.Forms.TextBox();
            this.textBoxPierwszaLiczbaEuklidesa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBubbleSort = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.tabPageFibIt = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFibItN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPageFibRek = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFibRekN = new System.Windows.Forms.TextBox();
            this.textBoxFibRek = new System.Windows.Forms.TextBox();
            this.buttonFibRek = new System.Windows.Forms.Button();
            this.tabPageOdwracanieKolorow = new System.Windows.Forms.TabPage();
            this.buttonWczytajPNG = new System.Windows.Forms.Button();
            this.tabPage3or5 = new System.Windows.Forms.TabPage();
            this.buttonCheck3or5 = new System.Windows.Forms.Button();
            this.label3or5 = new System.Windows.Forms.Label();
            this.tabPagePalindrom = new System.Windows.Forms.TabPage();
            this.textBoxPali = new System.Windows.Forms.TextBox();
            this.buttonPali = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSmallestMultiple = new System.Windows.Forms.TabPage();
            this.textBoxSmallestMultiple = new System.Windows.Forms.TextBox();
            this.buttonSmallestMultiply = new System.Windows.Forms.Button();
            this.labelSmallestMulitple = new System.Windows.Forms.Label();
            this.tabPageSmallestDivided = new System.Windows.Forms.TabPage();
            this.textBoxLongestChain = new System.Windows.Forms.TextBox();
            this.checkLongestCalletz = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonCheckCollatz = new System.Windows.Forms.Button();
            this.richTextBox_BubbleSort = new System.Windows.Forms.RichTextBox();
            this.textBoxShowFib = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxCollatz = new System.Windows.Forms.RichTextBox();
            this.tabPageKolorowanieMapy.SuspendLayout();
            this.tabPagePesel.SuspendLayout();
            this.tabPageDosk.SuspendLayout();
            this.tabPageNWD.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBubbleSort.SuspendLayout();
            this.tabPageFibIt.SuspendLayout();
            this.tabPageFibRek.SuspendLayout();
            this.tabPageOdwracanieKolorow.SuspendLayout();
            this.tabPage3or5.SuspendLayout();
            this.tabPagePalindrom.SuspendLayout();
            this.tabPageSmallestMultiple.SuspendLayout();
            this.tabPageSmallestDivided.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Files PNG|*.png";
            // 
            // tabPageKolorowanieMapy
            // 
            this.tabPageKolorowanieMapy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPageKolorowanieMapy.Controls.Add(this.label5);
            this.tabPageKolorowanieMapy.Controls.Add(this.Wczytaj);
            this.tabPageKolorowanieMapy.Location = new System.Drawing.Point(4, 22);
            this.tabPageKolorowanieMapy.Name = "tabPageKolorowanieMapy";
            this.tabPageKolorowanieMapy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKolorowanieMapy.Size = new System.Drawing.Size(393, 405);
            this.tabPageKolorowanieMapy.TabIndex = 3;
            this.tabPageKolorowanieMapy.Text = "4. Kolorowanie mapy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kolorowanie mapy wysokości";
            // 
            // Wczytaj
            // 
            this.Wczytaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wczytaj.Location = new System.Drawing.Point(155, 61);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(75, 23);
            this.Wczytaj.TabIndex = 0;
            this.Wczytaj.Text = "Wczytaj";
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // tabPagePesel
            // 
            this.tabPagePesel.BackColor = System.Drawing.Color.Green;
            this.tabPagePesel.Controls.Add(this.label4);
            this.tabPagePesel.Controls.Add(this.textBox_PESEL);
            this.tabPagePesel.Controls.Add(this.button1);
            this.tabPagePesel.Location = new System.Drawing.Point(4, 22);
            this.tabPagePesel.Name = "tabPagePesel";
            this.tabPagePesel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesel.Size = new System.Drawing.Size(393, 405);
            this.tabPagePesel.TabIndex = 2;
            this.tabPagePesel.Text = "3. Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wprowadz pesel:";
            // 
            // textBox_PESEL
            // 
            this.textBox_PESEL.Location = new System.Drawing.Point(104, 111);
            this.textBox_PESEL.MaxLength = 11;
            this.textBox_PESEL.Name = "textBox_PESEL";
            this.textBox_PESEL.Size = new System.Drawing.Size(169, 20);
            this.textBox_PESEL.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sprawdz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageDosk
            // 
            this.tabPageDosk.Controls.Add(this.label3);
            this.tabPageDosk.Controls.Add(this.button_LiczbaDoskonala);
            this.tabPageDosk.Location = new System.Drawing.Point(4, 22);
            this.tabPageDosk.Name = "tabPageDosk";
            this.tabPageDosk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDosk.Size = new System.Drawing.Size(393, 405);
            this.tabPageDosk.TabIndex = 1;
            this.tabPageDosk.Text = "2. Dosk";
            this.tabPageDosk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liczba doskonala dla 3  <= x <= 10000";
            // 
            // button_LiczbaDoskonala
            // 
            this.button_LiczbaDoskonala.Location = new System.Drawing.Point(155, 192);
            this.button_LiczbaDoskonala.Name = "button_LiczbaDoskonala";
            this.button_LiczbaDoskonala.Size = new System.Drawing.Size(75, 23);
            this.button_LiczbaDoskonala.TabIndex = 0;
            this.button_LiczbaDoskonala.Text = "Oblicz";
            this.button_LiczbaDoskonala.UseVisualStyleBackColor = true;
            this.button_LiczbaDoskonala.Click += new System.EventHandler(this.button_LiczbaDoskonala_Click);
            // 
            // tabPageNWD
            // 
            this.tabPageNWD.Controls.Add(this.label2);
            this.tabPageNWD.Controls.Add(this.WynikEuklidesa);
            this.tabPageNWD.Controls.Add(this.textBoxDrugaLiczbaEuklidesa);
            this.tabPageNWD.Controls.Add(this.textBoxPierwszaLiczbaEuklidesa);
            this.tabPageNWD.Controls.Add(this.button2);
            this.tabPageNWD.Location = new System.Drawing.Point(4, 22);
            this.tabPageNWD.Name = "tabPageNWD";
            this.tabPageNWD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNWD.Size = new System.Drawing.Size(393, 405);
            this.tabPageNWD.TabIndex = 0;
            this.tabPageNWD.Text = "1. Algorytm Euklidesa";
            this.tabPageNWD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Algorytm Euklidesa (NWD)\r\n";
            // 
            // WynikEuklidesa
            // 
            this.WynikEuklidesa.Location = new System.Drawing.Point(140, 222);
            this.WynikEuklidesa.Name = "WynikEuklidesa";
            this.WynikEuklidesa.ReadOnly = true;
            this.WynikEuklidesa.Size = new System.Drawing.Size(111, 20);
            this.WynikEuklidesa.TabIndex = 3;
            // 
            // textBoxDrugaLiczbaEuklidesa
            // 
            this.textBoxDrugaLiczbaEuklidesa.Location = new System.Drawing.Point(277, 99);
            this.textBoxDrugaLiczbaEuklidesa.Name = "textBoxDrugaLiczbaEuklidesa";
            this.textBoxDrugaLiczbaEuklidesa.Size = new System.Drawing.Size(113, 20);
            this.textBoxDrugaLiczbaEuklidesa.TabIndex = 2;
            // 
            // textBoxPierwszaLiczbaEuklidesa
            // 
            this.textBoxPierwszaLiczbaEuklidesa.Location = new System.Drawing.Point(3, 99);
            this.textBoxPierwszaLiczbaEuklidesa.Name = "textBoxPierwszaLiczbaEuklidesa";
            this.textBoxPierwszaLiczbaEuklidesa.Size = new System.Drawing.Size(109, 20);
            this.textBoxPierwszaLiczbaEuklidesa.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 24);
            this.button2.TabIndex = 0;
            this.button2.Text = "Znajdz dzielnik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNWD);
            this.tabControl1.Controls.Add(this.tabPageDosk);
            this.tabControl1.Controls.Add(this.tabPagePesel);
            this.tabControl1.Controls.Add(this.tabPageKolorowanieMapy);
            this.tabControl1.Controls.Add(this.tabPageBubbleSort);
            this.tabControl1.Controls.Add(this.tabPageFibIt);
            this.tabControl1.Controls.Add(this.tabPageFibRek);
            this.tabControl1.Controls.Add(this.tabPageOdwracanieKolorow);
            this.tabControl1.Controls.Add(this.tabPage3or5);
            this.tabControl1.Controls.Add(this.tabPagePalindrom);
            this.tabControl1.Controls.Add(this.tabPageSmallestMultiple);
            this.tabControl1.Controls.Add(this.tabPageSmallestDivided);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 431);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPageBubbleSort
            // 
            this.tabPageBubbleSort.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPageBubbleSort.Controls.Add(this.richTextBox_BubbleSort);
            this.tabPageBubbleSort.Controls.Add(this.label6);
            this.tabPageBubbleSort.Controls.Add(this.textBoxSort);
            this.tabPageBubbleSort.Controls.Add(this.SortButton);
            this.tabPageBubbleSort.Location = new System.Drawing.Point(4, 22);
            this.tabPageBubbleSort.Name = "tabPageBubbleSort";
            this.tabPageBubbleSort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBubbleSort.Size = new System.Drawing.Size(393, 405);
            this.tabPageBubbleSort.TabIndex = 5;
            this.tabPageBubbleSort.Text = "5. Sortowanie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sortowanie babelkowe:";
            // 
            // textBoxSort
            // 
            this.textBoxSort.Location = new System.Drawing.Point(0, 385);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.ReadOnly = true;
            this.textBoxSort.Size = new System.Drawing.Size(223, 20);
            this.textBoxSort.TabIndex = 1;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(165, 253);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Sortuj";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // tabPageFibIt
            // 
            this.tabPageFibIt.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPageFibIt.Controls.Add(this.textBoxShowFib);
            this.tabPageFibIt.Controls.Add(this.label8);
            this.tabPageFibIt.Controls.Add(this.textBoxFibItN);
            this.tabPageFibIt.Controls.Add(this.label7);
            this.tabPageFibIt.Controls.Add(this.button3);
            this.tabPageFibIt.Location = new System.Drawing.Point(4, 22);
            this.tabPageFibIt.Name = "tabPageFibIt";
            this.tabPageFibIt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFibIt.Size = new System.Drawing.Size(393, 405);
            this.tabPageFibIt.TabIndex = 6;
            this.tabPageFibIt.Text = "6. Fibbonaci iteracyjnie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Wprowadz n-ty wyraz ciagu:";
            // 
            // textBoxFibItN
            // 
            this.textBoxFibItN.Location = new System.Drawing.Point(44, 181);
            this.textBoxFibItN.Name = "textBoxFibItN";
            this.textBoxFibItN.Size = new System.Drawing.Size(100, 20);
            this.textBoxFibItN.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "ciąg liczb Fibonacciego \r\n(iteracyjnie)\r\n";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ciag Fib";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tabPageFibRek
            // 
            this.tabPageFibRek.Controls.Add(this.label9);
            this.tabPageFibRek.Controls.Add(this.textBoxFibRekN);
            this.tabPageFibRek.Controls.Add(this.textBoxFibRek);
            this.tabPageFibRek.Controls.Add(this.buttonFibRek);
            this.tabPageFibRek.Location = new System.Drawing.Point(4, 22);
            this.tabPageFibRek.Name = "tabPageFibRek";
            this.tabPageFibRek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFibRek.Size = new System.Drawing.Size(393, 405);
            this.tabPageFibRek.TabIndex = 7;
            this.tabPageFibRek.Text = "6.2. Fib rekurencja";
            this.tabPageFibRek.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Wprowadz n-ty wyraz ciagu:";
            // 
            // textBoxFibRekN
            // 
            this.textBoxFibRekN.Location = new System.Drawing.Point(38, 258);
            this.textBoxFibRekN.Name = "textBoxFibRekN";
            this.textBoxFibRekN.Size = new System.Drawing.Size(100, 20);
            this.textBoxFibRekN.TabIndex = 2;
            // 
            // textBoxFibRek
            // 
            this.textBoxFibRek.Location = new System.Drawing.Point(38, 287);
            this.textBoxFibRek.Name = "textBoxFibRek";
            this.textBoxFibRek.ReadOnly = true;
            this.textBoxFibRek.Size = new System.Drawing.Size(313, 20);
            this.textBoxFibRek.TabIndex = 1;
            // 
            // buttonFibRek
            // 
            this.buttonFibRek.Location = new System.Drawing.Point(172, 258);
            this.buttonFibRek.Name = "buttonFibRek";
            this.buttonFibRek.Size = new System.Drawing.Size(101, 23);
            this.buttonFibRek.TabIndex = 0;
            this.buttonFibRek.Text = "licz fib";
            this.buttonFibRek.UseVisualStyleBackColor = true;
            this.buttonFibRek.Click += new System.EventHandler(this.ButtonFibRek_Click);
            // 
            // tabPageOdwracanieKolorow
            // 
            this.tabPageOdwracanieKolorow.Controls.Add(this.buttonWczytajPNG);
            this.tabPageOdwracanieKolorow.Location = new System.Drawing.Point(4, 22);
            this.tabPageOdwracanieKolorow.Name = "tabPageOdwracanieKolorow";
            this.tabPageOdwracanieKolorow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOdwracanieKolorow.Size = new System.Drawing.Size(393, 405);
            this.tabPageOdwracanieKolorow.TabIndex = 11;
            this.tabPageOdwracanieKolorow.Text = "7. Odwracanie kolorow";
            this.tabPageOdwracanieKolorow.UseVisualStyleBackColor = true;
            // 
            // buttonWczytajPNG
            // 
            this.buttonWczytajPNG.Location = new System.Drawing.Point(149, 195);
            this.buttonWczytajPNG.Name = "buttonWczytajPNG";
            this.buttonWczytajPNG.Size = new System.Drawing.Size(75, 23);
            this.buttonWczytajPNG.TabIndex = 0;
            this.buttonWczytajPNG.Text = "Wczytaj";
            this.buttonWczytajPNG.UseVisualStyleBackColor = true;
            this.buttonWczytajPNG.Click += new System.EventHandler(this.ButtonWczytajPNG_Click);
            // 
            // tabPage3or5
            // 
            this.tabPage3or5.Controls.Add(this.textBox1);
            this.tabPage3or5.Controls.Add(this.buttonCheck3or5);
            this.tabPage3or5.Controls.Add(this.label3or5);
            this.tabPage3or5.Location = new System.Drawing.Point(4, 22);
            this.tabPage3or5.Name = "tabPage3or5";
            this.tabPage3or5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3or5.Size = new System.Drawing.Size(393, 405);
            this.tabPage3or5.TabIndex = 8;
            this.tabPage3or5.Text = "8. 3 or 5?";
            this.tabPage3or5.UseVisualStyleBackColor = true;
            // 
            // buttonCheck3or5
            // 
            this.buttonCheck3or5.Location = new System.Drawing.Point(156, 233);
            this.buttonCheck3or5.Name = "buttonCheck3or5";
            this.buttonCheck3or5.Size = new System.Drawing.Size(98, 23);
            this.buttonCheck3or5.TabIndex = 2;
            this.buttonCheck3or5.Text = "sum";
            this.buttonCheck3or5.UseVisualStyleBackColor = true;
            this.buttonCheck3or5.Click += new System.EventHandler(this.ButtonCheck3or5_Click);
            // 
            // label3or5
            // 
            this.label3or5.AutoSize = true;
            this.label3or5.Location = new System.Drawing.Point(3, 290);
            this.label3or5.Name = "label3or5";
            this.label3or5.Size = new System.Drawing.Size(215, 13);
            this.label3or5.TabIndex = 1;
            this.label3or5.Text = "sum of all the multiples of 3 or 5 below 1000.";
            // 
            // tabPagePalindrom
            // 
            this.tabPagePalindrom.Controls.Add(this.textBoxPali);
            this.tabPagePalindrom.Controls.Add(this.buttonPali);
            this.tabPagePalindrom.Controls.Add(this.label1);
            this.tabPagePalindrom.Location = new System.Drawing.Point(4, 22);
            this.tabPagePalindrom.Name = "tabPagePalindrom";
            this.tabPagePalindrom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePalindrom.Size = new System.Drawing.Size(393, 405);
            this.tabPagePalindrom.TabIndex = 9;
            this.tabPagePalindrom.Text = "9. Palindrom";
            this.tabPagePalindrom.UseVisualStyleBackColor = true;
            // 
            // textBoxPali
            // 
            this.textBoxPali.Location = new System.Drawing.Point(25, 153);
            this.textBoxPali.Name = "textBoxPali";
            this.textBoxPali.ReadOnly = true;
            this.textBoxPali.Size = new System.Drawing.Size(336, 20);
            this.textBoxPali.TabIndex = 2;
            // 
            // buttonPali
            // 
            this.buttonPali.Location = new System.Drawing.Point(151, 100);
            this.buttonPali.Name = "buttonPali";
            this.buttonPali.Size = new System.Drawing.Size(75, 23);
            this.buttonPali.TabIndex = 1;
            this.buttonPali.Text = "find";
            this.buttonPali.UseVisualStyleBackColor = true;
            this.buttonPali.Click += new System.EventHandler(this.ButtonPali_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find the largest palindrome made from the product of two 3-digit numbers.";
            // 
            // tabPageSmallestMultiple
            // 
            this.tabPageSmallestMultiple.Controls.Add(this.textBoxSmallestMultiple);
            this.tabPageSmallestMultiple.Controls.Add(this.buttonSmallestMultiply);
            this.tabPageSmallestMultiple.Controls.Add(this.labelSmallestMulitple);
            this.tabPageSmallestMultiple.Location = new System.Drawing.Point(4, 22);
            this.tabPageSmallestMultiple.Name = "tabPageSmallestMultiple";
            this.tabPageSmallestMultiple.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSmallestMultiple.Size = new System.Drawing.Size(393, 405);
            this.tabPageSmallestMultiple.TabIndex = 10;
            this.tabPageSmallestMultiple.Text = "10. Smallest multiple";
            this.tabPageSmallestMultiple.UseVisualStyleBackColor = true;
            // 
            // textBoxSmallestMultiple
            // 
            this.textBoxSmallestMultiple.Location = new System.Drawing.Point(67, 198);
            this.textBoxSmallestMultiple.Name = "textBoxSmallestMultiple";
            this.textBoxSmallestMultiple.ReadOnly = true;
            this.textBoxSmallestMultiple.Size = new System.Drawing.Size(257, 20);
            this.textBoxSmallestMultiple.TabIndex = 2;
            // 
            // buttonSmallestMultiply
            // 
            this.buttonSmallestMultiply.Location = new System.Drawing.Point(159, 124);
            this.buttonSmallestMultiply.Name = "buttonSmallestMultiply";
            this.buttonSmallestMultiply.Size = new System.Drawing.Size(75, 23);
            this.buttonSmallestMultiply.TabIndex = 1;
            this.buttonSmallestMultiply.Text = "Check";
            this.buttonSmallestMultiply.UseVisualStyleBackColor = true;
            this.buttonSmallestMultiply.Click += new System.EventHandler(this.ButtonSmallestMultiply_Click);
            // 
            // labelSmallestMulitple
            // 
            this.labelSmallestMulitple.AutoSize = true;
            this.labelSmallestMulitple.Location = new System.Drawing.Point(3, 3);
            this.labelSmallestMulitple.Name = "labelSmallestMulitple";
            this.labelSmallestMulitple.Size = new System.Drawing.Size(387, 13);
            this.labelSmallestMulitple.TabIndex = 0;
            this.labelSmallestMulitple.Text = "Smallest positive number that is evenly divisible by all of the numbers from 1 to" +
    " 20";
            // 
            // tabPageSmallestDivided
            // 
            this.tabPageSmallestDivided.BackColor = System.Drawing.Color.Moccasin;
            this.tabPageSmallestDivided.Controls.Add(this.textBoxCollatz);
            this.tabPageSmallestDivided.Controls.Add(this.textBoxLongestChain);
            this.tabPageSmallestDivided.Controls.Add(this.checkLongestCalletz);
            this.tabPageSmallestDivided.Controls.Add(this.textBoxNumber);
            this.tabPageSmallestDivided.Controls.Add(this.buttonCheckCollatz);
            this.tabPageSmallestDivided.Location = new System.Drawing.Point(4, 22);
            this.tabPageSmallestDivided.Name = "tabPageSmallestDivided";
            this.tabPageSmallestDivided.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSmallestDivided.Size = new System.Drawing.Size(393, 405);
            this.tabPageSmallestDivided.TabIndex = 4;
            this.tabPageSmallestDivided.Text = "11. Divide";
            // 
            // textBoxLongestChain
            // 
            this.textBoxLongestChain.Location = new System.Drawing.Point(9, 316);
            this.textBoxLongestChain.Name = "textBoxLongestChain";
            this.textBoxLongestChain.ReadOnly = true;
            this.textBoxLongestChain.Size = new System.Drawing.Size(374, 20);
            this.textBoxLongestChain.TabIndex = 4;
            // 
            // checkLongestCalletz
            // 
            this.checkLongestCalletz.Location = new System.Drawing.Point(118, 287);
            this.checkLongestCalletz.Name = "checkLongestCalletz";
            this.checkLongestCalletz.Size = new System.Drawing.Size(137, 23);
            this.checkLongestCalletz.TabIndex = 3;
            this.checkLongestCalletz.Text = "Check The longest chain";
            this.checkLongestCalletz.UseVisualStyleBackColor = true;
            this.checkLongestCalletz.Click += new System.EventHandler(this.CheckLongestCalletz_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(80, 117);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(58, 20);
            this.textBoxNumber.TabIndex = 2;
            // 
            // buttonCheckCollatz
            // 
            this.buttonCheckCollatz.Location = new System.Drawing.Point(144, 117);
            this.buttonCheckCollatz.Name = "buttonCheckCollatz";
            this.buttonCheckCollatz.Size = new System.Drawing.Size(87, 23);
            this.buttonCheckCollatz.TabIndex = 0;
            this.buttonCheckCollatz.Text = "Check";
            this.buttonCheckCollatz.UseVisualStyleBackColor = true;
            this.buttonCheckCollatz.Click += new System.EventHandler(this.ButtonCheckCollatz_Click);
            // 
            // richTextBox_BubbleSort
            // 
            this.richTextBox_BubbleSort.Location = new System.Drawing.Point(0, 27);
            this.richTextBox_BubbleSort.Name = "richTextBox_BubbleSort";
            this.richTextBox_BubbleSort.Size = new System.Drawing.Size(159, 249);
            this.richTextBox_BubbleSort.TabIndex = 3;
            this.richTextBox_BubbleSort.Text = "";
            // 
            // textBoxShowFib
            // 
            this.textBoxShowFib.Location = new System.Drawing.Point(3, 246);
            this.textBoxShowFib.Name = "textBoxShowFib";
            this.textBoxShowFib.ReadOnly = true;
            this.textBoxShowFib.Size = new System.Drawing.Size(387, 119);
            this.textBoxShowFib.TabIndex = 5;
            this.textBoxShowFib.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(380, 96);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            // 
            // textBoxCollatz
            // 
            this.textBoxCollatz.Location = new System.Drawing.Point(9, 146);
            this.textBoxCollatz.Name = "textBoxCollatz";
            this.textBoxCollatz.ReadOnly = true;
            this.textBoxCollatz.Size = new System.Drawing.Size(374, 135);
            this.textBoxCollatz.TabIndex = 5;
            this.textBoxCollatz.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPageKolorowanieMapy.ResumeLayout(false);
            this.tabPageKolorowanieMapy.PerformLayout();
            this.tabPagePesel.ResumeLayout(false);
            this.tabPagePesel.PerformLayout();
            this.tabPageDosk.ResumeLayout(false);
            this.tabPageDosk.PerformLayout();
            this.tabPageNWD.ResumeLayout(false);
            this.tabPageNWD.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBubbleSort.ResumeLayout(false);
            this.tabPageBubbleSort.PerformLayout();
            this.tabPageFibIt.ResumeLayout(false);
            this.tabPageFibIt.PerformLayout();
            this.tabPageFibRek.ResumeLayout(false);
            this.tabPageFibRek.PerformLayout();
            this.tabPageOdwracanieKolorow.ResumeLayout(false);
            this.tabPage3or5.ResumeLayout(false);
            this.tabPage3or5.PerformLayout();
            this.tabPagePalindrom.ResumeLayout(false);
            this.tabPagePalindrom.PerformLayout();
            this.tabPageSmallestMultiple.ResumeLayout(false);
            this.tabPageSmallestMultiple.PerformLayout();
            this.tabPageSmallestDivided.ResumeLayout(false);
            this.tabPageSmallestDivided.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPageKolorowanieMapy;
        private System.Windows.Forms.Button Wczytaj;
        private System.Windows.Forms.TabPage tabPagePesel;
        private System.Windows.Forms.TextBox textBox_PESEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageDosk;
        private System.Windows.Forms.Button button_LiczbaDoskonala;
        private System.Windows.Forms.TabPage tabPageNWD;
        private System.Windows.Forms.TextBox WynikEuklidesa;
        private System.Windows.Forms.TextBox textBoxDrugaLiczbaEuklidesa;
        private System.Windows.Forms.TextBox textBoxPierwszaLiczbaEuklidesa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSmallestDivided;
        private System.Windows.Forms.Button buttonCheckCollatz;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxLongestChain;
        private System.Windows.Forms.Button checkLongestCalletz;
        private System.Windows.Forms.TabPage tabPageBubbleSort;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.TabPage tabPageFibIt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPageFibRek;
        private System.Windows.Forms.TextBox textBoxFibRek;
        private System.Windows.Forms.Button buttonFibRek;
        private System.Windows.Forms.TabPage tabPage3or5;
        private System.Windows.Forms.Label label3or5;
        private System.Windows.Forms.Button buttonCheck3or5;
        private System.Windows.Forms.TabPage tabPagePalindrom;
        private System.Windows.Forms.TextBox textBoxPali;
        private System.Windows.Forms.Button buttonPali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSmallestMultiple;
        private System.Windows.Forms.TextBox textBoxSmallestMultiple;
        private System.Windows.Forms.Button buttonSmallestMultiply;
        private System.Windows.Forms.Label labelSmallestMulitple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFibItN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFibRekN;
        private System.Windows.Forms.TabPage tabPageOdwracanieKolorow;
        private System.Windows.Forms.Button buttonWczytajPNG;
        private System.Windows.Forms.RichTextBox richTextBox_BubbleSort;
        private System.Windows.Forms.RichTextBox textBoxShowFib;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.RichTextBox textBoxCollatz;
    }
}

