namespace Calc
{
    partial class Miniräknare
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
            this.buttonLikamed = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Svar = new System.Windows.Forms.TextBox();
            this.buttonDivison = new System.Windows.Forms.Button();
            this.buttonMultiplikation = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonKomma = new System.Windows.Forms.Button();
            this.buttonNegativ = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpphöjt = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.buttonKabeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLikamed
            // 
            this.buttonLikamed.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonLikamed.Location = new System.Drawing.Point(189, 490);
            this.buttonLikamed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLikamed.Name = "buttonLikamed";
            this.buttonLikamed.Size = new System.Drawing.Size(168, 49);
            this.buttonLikamed.TabIndex = 24;
            this.buttonLikamed.TabStop = false;
            this.buttonLikamed.Text = "=";
            this.buttonLikamed.UseVisualStyleBackColor = true;
            this.buttonLikamed.Click += new System.EventHandler(this.ButtonLikamed_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.buttonClear.Location = new System.Drawing.Point(13, 490);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(168, 49);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonNollställ_Click);
            // 
            // Svar
            // 
            this.Svar.Enabled = false;
            this.Svar.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.Svar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Svar.Location = new System.Drawing.Point(13, 54);
            this.Svar.Margin = new System.Windows.Forms.Padding(4);
            this.Svar.MaxLength = 25;
            this.Svar.Name = "Svar";
            this.Svar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Svar.Size = new System.Drawing.Size(344, 34);
            this.Svar.TabIndex = 2;
            this.Svar.TabStop = false;
            this.Svar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonDivison
            // 
            this.buttonDivison.Font = new System.Drawing.Font("Yu Gothic Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonDivison.Location = new System.Drawing.Point(277, 96);
            this.buttonDivison.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDivison.Name = "buttonDivison";
            this.buttonDivison.Size = new System.Drawing.Size(80, 62);
            this.buttonDivison.TabIndex = 6;
            this.buttonDivison.TabStop = false;
            this.buttonDivison.Text = "÷";
            this.buttonDivison.UseVisualStyleBackColor = true;
            this.buttonDivison.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonMultiplikation
            // 
            this.buttonMultiplikation.Font = new System.Drawing.Font("Bahnschrift Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonMultiplikation.Location = new System.Drawing.Point(189, 96);
            this.buttonMultiplikation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMultiplikation.Name = "buttonMultiplikation";
            this.buttonMultiplikation.Size = new System.Drawing.Size(80, 62);
            this.buttonMultiplikation.TabIndex = 5;
            this.buttonMultiplikation.TabStop = false;
            this.buttonMultiplikation.Text = "x";
            this.buttonMultiplikation.UseVisualStyleBackColor = true;
            this.buttonMultiplikation.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonMinus.Location = new System.Drawing.Point(101, 96);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(80, 62);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonPlus.Location = new System.Drawing.Point(13, 96);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(80, 62);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonKomma
            // 
            this.buttonKomma.Font = new System.Drawing.Font("Yu Gothic UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonKomma.Location = new System.Drawing.Point(277, 409);
            this.buttonKomma.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKomma.Name = "buttonKomma";
            this.buttonKomma.Size = new System.Drawing.Size(80, 74);
            this.buttonKomma.TabIndex = 9;
            this.buttonKomma.TabStop = false;
            this.buttonKomma.Text = ",";
            this.buttonKomma.UseVisualStyleBackColor = true;
            this.buttonKomma.Click += new System.EventHandler(this.ButtonKomma_Click);
            // 
            // buttonNegativ
            // 
            this.buttonNegativ.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonNegativ.Location = new System.Drawing.Point(277, 327);
            this.buttonNegativ.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNegativ.Name = "buttonNegativ";
            this.buttonNegativ.Size = new System.Drawing.Size(80, 74);
            this.buttonNegativ.TabIndex = 10;
            this.buttonNegativ.TabStop = false;
            this.buttonNegativ.Text = "+";
            this.buttonNegativ.UseVisualStyleBackColor = true;
            this.buttonNegativ.Click += new System.EventHandler(this.ButtonNegative_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button0.Location = new System.Drawing.Point(101, 409);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(80, 74);
            this.button0.TabIndex = 12;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button9.Location = new System.Drawing.Point(189, 165);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 74);
            this.button9.TabIndex = 21;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button8.Location = new System.Drawing.Point(101, 165);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 74);
            this.button8.TabIndex = 20;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button7.Location = new System.Drawing.Point(13, 165);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 74);
            this.button7.TabIndex = 19;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button6.Location = new System.Drawing.Point(189, 246);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 74);
            this.button6.TabIndex = 18;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button5.Location = new System.Drawing.Point(101, 246);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 74);
            this.button5.TabIndex = 17;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button4.Location = new System.Drawing.Point(13, 246);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 74);
            this.button4.TabIndex = 16;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button3.Location = new System.Drawing.Point(189, 327);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 74);
            this.button3.TabIndex = 15;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button2.Location = new System.Drawing.Point(101, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 74);
            this.button2.TabIndex = 14;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.button1.Location = new System.Drawing.Point(13, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 74);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSiffra_Click);
            // 
            // buttonUpphöjt
            // 
            this.buttonUpphöjt.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonUpphöjt.Location = new System.Drawing.Point(277, 165);
            this.buttonUpphöjt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpphöjt.Name = "buttonUpphöjt";
            this.buttonUpphöjt.Size = new System.Drawing.Size(80, 74);
            this.buttonUpphöjt.TabIndex = 7;
            this.buttonUpphöjt.TabStop = false;
            this.buttonUpphöjt.Text = "^";
            this.buttonUpphöjt.UseVisualStyleBackColor = true;
            this.buttonUpphöjt.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 31F);
            this.buttonPi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPi.Location = new System.Drawing.Point(189, 409);
            this.buttonPi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(80, 74);
            this.buttonPi.TabIndex = 11;
            this.buttonPi.TabStop = false;
            this.buttonPi.Text = "𝜋";
            this.buttonPi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.buttonSqrt.Location = new System.Drawing.Point(277, 246);
            this.buttonSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(80, 74);
            this.buttonSqrt.TabIndex = 8;
            this.buttonSqrt.TabStop = false;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.Label.Location = new System.Drawing.Point(13, 9);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(344, 41);
            this.Label.TabIndex = 3;
            this.Label.Text = "Du kan använda tangenter för att mata in det matematiska uttrycket.\r\nP=pi, N=nega" +
    "tivt, S=kvadratrot, U=upphöjt, M=gånger, D=delat\r\nEnter=\"=\", Space=Clear, ESC=Ex" +
    "it. Resten är som på tangentbordet.";
            // 
            // buttonKabeb
            // 
            this.buttonKabeb.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.buttonKabeb.Location = new System.Drawing.Point(13, 409);
            this.buttonKabeb.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKabeb.Name = "buttonKabeb";
            this.buttonKabeb.Size = new System.Drawing.Size(80, 74);
            this.buttonKabeb.TabIndex = 22;
            this.buttonKabeb.TabStop = false;
            this.buttonKabeb.Text = "Kabeb";
            this.buttonKabeb.UseVisualStyleBackColor = true;
            this.buttonKabeb.Click += new System.EventHandler(this.ButtonKabeb_Click);
            // 
            // Miniräknare
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 551);
            this.Controls.Add(this.buttonKabeb);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonUpphöjt);
            this.Controls.Add(this.buttonLikamed);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.Svar);
            this.Controls.Add(this.buttonDivison);
            this.Controls.Add(this.buttonMultiplikation);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonKomma);
            this.Controls.Add(this.buttonNegativ);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Miniräknare";
            this.ShowIcon = false;
            this.Text = "Miniräknare";
            this.Load += new System.EventHandler(this.Miniräknare_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Miniräknare_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLikamed;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiplikation;
        private System.Windows.Forms.Button buttonDivison;
        private System.Windows.Forms.Button buttonKomma;
        private System.Windows.Forms.Button buttonNegativ;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonUpphöjt;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonKabeb;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox Svar;
    }
}