﻿using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Calc
{
    public partial class Miniräknare : Form
    {
        public Miniräknare()
        {
            InitializeComponent();
        }

        string[] uttryck; //skapar ett fält som ska användas för att beräkna det matematiska uttrycket

        //föjande bool-variabler används för att man inte ska kunna skriva talen hur som helst
        //det är för att det finns vissa regler, som att inte dra roten ur negativa tal

        //dom gör att miniräknaren blir lite mer användarvänlig 
        //dom löser vissa problem för att programmet inte ska krascha
        //villkoren går jag igenom nedan om varför jag gjort så här
        //alla dessa variabler ändrar värde beroende på vilka knappar användaren trycker på

        bool trycktSiffra = false;
        bool trycktNoll = false; //0 är också en siffra,
        //men jag har gjort en bool specifikt för den och förklarar varför nedan

        bool trycktPI = false;
        bool trycktKomma = false;
        bool trycktNegative = false;
        bool trycktSqrt = false;
        bool trycktUpphöjt = false;

        Dictionary<Keys, Button> tangenter = new Dictionary<Keys, Button>();
        //skapar ett lexikon för att kunna använda sifferknapparna på tangentbordet för att trycka på knappar

        private void Miniräknare_Load(object sender, EventArgs e)
        {
            //lägger till knappar och kopplar/binder dem till en viss tangent
            tangenter.Add(Keys.D1, button1);
            tangenter.Add(Keys.D2, button2);
            tangenter.Add(Keys.D3, button3);
            tangenter.Add(Keys.D4, button4);
            tangenter.Add(Keys.D5, button5);
            tangenter.Add(Keys.D6, button6);
            tangenter.Add(Keys.D7, button7);
            tangenter.Add(Keys.D8, button8);
            tangenter.Add(Keys.D9, button9);
            tangenter.Add(Keys.D0, button0);
            tangenter.Add(Keys.P, buttonPi);
            tangenter.Add(Keys.Oemcomma, buttonKomma);
            tangenter.Add(Keys.N, buttonNegativ);
            tangenter.Add(Keys.Oemplus, buttonPlus);
            tangenter.Add(Keys.OemMinus, buttonMinus);
            tangenter.Add(Keys.M, buttonMultiplikation);
            tangenter.Add(Keys.D, buttonDivison);
            tangenter.Add(Keys.U, buttonUpphöjt);
            tangenter.Add(Keys.S, buttonSqrt);
            tangenter.Add(Keys.Space, buttonClear);
            tangenter.Add(Keys.Enter, buttonLikamed);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { //funktionen har jag kopierat från stackoverflow, har inte skrivit den själv

            //tyvärr har jag ingen aning om hur man förklarar denna funktion, men jag vet vad den gör
            //jag vill att man ska kunna använda tangenter för att klicka på knapparna,
            //men om man klickar på pil-tangenterna så blir knapparna fokuserade (får en blå outline).
            //det vill jag inte, bl.a för att miniräknaren ser konstig ut då och man kan inte använda 'ENTER'.
            //för då används knappen som är fokuserad (den med blå outline),
            //istället för knappen "likamed" som jag egentligen har kopplat ENTER-tangenten till.
            //denna funktion gör att man inte kan använda pil-tangenterna.

            if (keyData == Keys.Left || keyData == Keys.Right 
                || keyData == Keys.Up || keyData == Keys.Down)
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Miniräknare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            else
            {
                foreach (KeyValuePair<Keys, Button> button in tangenter)
                {
                    if (e.KeyCode == button.Key)
                        button.Value.PerformClick();
                }
            }
        }

        private void ButtonKabeb_Click(object sender, EventArgs e)
        {
            Label.Focus();

            Svar.Text = "Kabeb Kabeb Kabeb Kabeb Kabeb Kabeb";

            FixaLabel();
            Label.Text = "Denna knapp har ingen funktion just nu.\nTryck 'Clear' för att rensa den här skiten...";

            buttonLikamed.Enabled = false;
        }

        private void ButtonSiffra_Click(object sender, EventArgs e)
        { //anropas om man trycker ner en sifferknapp. används för att skriva ut siffror

            Label.Focus();

            if (trycktPI == false) //kollar om användaren har tryckt PI,
            { //man inte kan lägga till siffror på PI för då blir det inte PI längre

                Button button = (Button)sender;
                //gör att man kan komma år egenskaperna för knappen man tryckte på

                if (button.Text == button0.Text) //kollar om knappens text är lika med 0
                { //just för att man inte ska spamma 0:er därför att det är onödigt, 00042 = 42

                    if (trycktNoll == false || trycktSiffra == true || trycktKomma == true)
                    { //man får skriva noll om man något av följande krav uppfylls:
                      //1. man inte har tryckt 0 tidigare i samma tal
                      //2. man har redan tryckt en siffra som inte är 0, för att skriva t.ex 1000
                      //3. man har tryckt komma, för att skriva typ 4.000012

                        Svar.Text += button.Text; //skriver ut 0:an
                        trycktNoll = true; //blir true eftersom man tryckt 0
                    }
                }
                else if (trycktNoll == false || trycktSiffra == true || trycktKomma == true)
                { //om sifferknappen man trycker på inte är 0, skrivs följande om:
                  //1. man inte har tryckt 0 förr, för att inte skriva typ 00042
                  //2. man redan tryckt en siffra som inte är 0, för att skriva t.ex 1006
                  //3. man har tryckt kommatecknet

                    Svar.Text += button.Text; //skriver ut siffran som står på knappen
                    trycktSiffra = true; //blir true för man tryckt ner en siffra som inte är 0
                }
            }
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        { //anropas när man trycker på pi-tecknet. används för att använda pi i beräkningen

            Label.Focus();

            if (trycktSiffra == false && trycktNoll == false && trycktKomma == false)
            { //man får skriva pi om följande krav uppfylls:
              //1. man får inte ha tryckt en siffra, man kan inte skriva t.ex 2pi,
              //även om det betyder 2 * pi i matten så fattar inte min minräknare, skriv 2 * pi isåfall
              //det gör också att man inte kan spamma pi flera gånger
              //2. samma som ovan, 0 är också en siffra
              //3. man får inte ha gjort ett komma-tecken, man kan inte skriva .3.1415... (.pi)

                Button button = (Button)sender;
                Svar.Text += button.Text; //Skriver ut pi (tecknet), 
                //men betyder egentligen 3.141592...

                trycktPI = true; //blir true eftersom man tryckt pi
                trycktSiffra = true; //blir true eftersom pi innehåller åtminstone en siffra
            }
        }

        private void ButtonKomma_Click(object sender, EventArgs e)
        { //anropas när man trycker '.' (punkt-tecken). används för att skriva decimaltal

            Label.Focus();

            if (trycktKomma == false && trycktPI == false)
            { //kollar om man tryckt kommatecknet redan, 
              //man kan inte skriva typ 3.22313.32 för man kan bara ha ett komma
              //man får inte heller ha tryckt pi, för det är ett decimaltal och innehåller kommatecken redan

                Button button = (Button)sender;
                Svar.Text += button.Text; //skriver ut kommatecknet

                trycktKomma = true; //blir true eftersom man tryckt komma
            }
            //man kan alltså börja talet med att skriva "." t.ex .425 för det betyder samma som 0.425
        }

        private void ButtonNegative_Click(object sender, EventArgs e)
        { //anropas när man trycker på '+/-'. används för att skriva ett negativt tal

            Label.Focus();

            if (trycktSiffra == false
                && trycktNoll == false && trycktKomma == false
                && trycktNegative == false && trycktSqrt == false)
            { //man kan skriva ut ett minustecken för att göra ett negativt tal om följande krav uppfylls:
              // 1. man får inte ha skrivit ut en siffra redan, man markerar ett negativt tal genom att
              // sätta minustecknet direkt framför talet, ska man subrahera två tal så finns en annan knapp för det
              // 2. 0 är också en siffra
              // 3. man får inte ha tryckt komma, eftersom man kan inte ha positiva heltal med negativa decimaltal
              // hela talet måste vara negativt isåfall
              // 3. man får inte ha tryckt knappen förr, för att inte spamma minustecken
              // 4. man får inte ha tryckt på knappen för att dra kvadratroten ur ett tal,
              // man kan ju inte dra roten ur negativa tal

                Svar.Text += buttonMinus.Text; //skriver ut minustecknet
                trycktNegative = true; //blir true eftersom man har markerat att man ska skriva ett negativt tal
            }
        }

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        { //anropas när man trycker på sqrt-knappen. används för att dra kvadratroten ur ett tal

            Label.Focus();

            if (trycktSiffra == false && trycktNoll == false && trycktKomma == false && trycktSqrt == false)
            { //man kan dra roten ur ett tal om följande krav uppfylls:
                // 1. man får inte ha skrivit en siffra innan, talet man vill dra roten ur skriver man efter
                // 2. 0 är också en siffra
                // 3. man får inte ha tryckt komma innan
                // 4. man får inte dra roten ur ett tal man drar roten ur, alltså får man bara trycka en gång per tal
                // och inte inte spamma sqrt(.

                Button button = (Button)sender;
                Svar.Text += button.Text + "("; //skriver ut sqrt och ett parantestecken för att tydligt se
                // vilket tal man vill dra roten ur

                trycktSqrt = true; //blir true eftersom man ska dra roten ur ett tal
            }
        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        { //anropas när man trycker på +, -, x, / eller ^. används som räknesätt

            Label.Focus();

            if (trycktSiffra == true || trycktNoll == true)
            { //man får skriva ut ett räknetecken om följande krav uppfylls:
                // man måste ha skrivit ut minst en siffra innan, 0 räknas som en siffra

                Button button = (Button)sender;

                // nedanstående satser beror på om man tryckt på de vanliga räknesätten (+,-,*,/) eller upphöjt (^)
                if (button.Text == buttonUpphöjt.Text && trycktUpphöjt == false)
                { //har man valt upphöjt skriver programmet ut ^ om följande krav uppfylls:
                    // 1. texten på knappen man tryckte på måste vara ^, obviously
                    // 2. man får inte ha tryckt upphöjt innan, för att man inte ska spamma men också
                    // för att mitt program inte kan upphöja ett tal flera gånger som t.ex 2^4^3^6

                    Svar.Text += button.Text; //skriver ut ^
                    ÅterställBools(); //anropar en funktion som jag förklarar vad den gör nedan
                    trycktUpphöjt = true; //blir true eftersom man tryckt upphöjt
                }
                else if (button.Text != buttonUpphöjt.Text)
                { //om knappen man tryckte på inte är ^, betyder det att man tryckt +,-,* eller /

                    Svar.Text += (" " + button.Text + " "); // skriver ut räknesättet,
                    //två mellanrum görs bredvid räkneoperatorn för att skilja på tal och räkneoperationer

                    ÅterställBools(); //anropar en funktion som jag förklarar nedan
                }
            }
        }

        private void ButtonNollställ_Click(object sender, EventArgs e)
        { //anropas när man trycker på knappen 'Clear'. används för att ta bort det som skrivits och börja om

            Label.Focus();

            Svar.Clear(); //tar bort det som står i rutan
            buttonLikamed.Enabled = true; //gör att man kan anropa en funktion jag förklarar nedan (efter den här)

            //ovanför rutan man skriver i finns en Label som informerar användaren om något har skrivits fel
            Label.Text = null; //tar bort felmeddelandet, man vill bara att det ska synnas efter ett fel
            //och att det ska tas bort när man klickar 'Clear'

            ÅterställBools(); //anropar en funktion jag förklarar nedan
        }

        private void ButtonLikamed_Click(object sender, EventArgs e)
        { //anropas när man trycker på =. används när man vill få svaret till sitt uttryck

            Label.Focus();

            //nedanstående villkor avgör om det uttryck som användaren har matat in är acceptabelt för beräkning
            if (trycktSiffra == true)
            { //uttrycket kan beräknas om det slutar på ett tal, alltså kan uttrycket inte sluta
              //med något av räknetecknen: +, -, x, /, sqrt(  eller ^.

                uttryck = Svar.Text.Split(); //lagrar det matematiska uttrycket som användaren matade in i ett fält
                //som heter 'uttryck', deklarerades i början av koden
                Uträkning(uttryck);

                //ifall uträkningen blir fel eller svaret blir för stort, körs denna kod
                if (!Svar.Text.Any(chr => Char.IsDigit(chr)))
                {
                    FixaLabel();

                    //om svaret blir för stort kommer "öändlighetstecknet" att skrivas (den liggande 8:an).
                    //detta händer för att datatypen "double" kan inte lagra tal som t.ex 9^99999.
                    if (Svar.Text.Count() == 1)
                        Label.Text = "Error! Svaret blir för stort.\nTryck 'Clear' för att fortsätta...";
                    //om svaret inte är för stort, betyder det att det matematiska uttrycket är orealistisk.
                    //det blir helt enkelt fel i beräkningen och tre tecken kommer skrivas ut => (¤¤¤).
                    else
                        Label.Text = "Error! Svaret blir fel.\nTryck 'Clear' för att fortsätta...";

                    buttonLikamed.Enabled = false;
                }
            }
            else
            {
                FixaLabel();

                Label.Text = "Error! Mata in ett uttryck som slutar på ett tal." +
                    "\nTryck 'Clear' för att fortsätta...";

                buttonLikamed.Enabled = false;
            }
        }

        private void ÅterställBools()
        { //anropas av metoderna 'buttonOperator_Click' och 'buttonNollställ_Click'. 
          //används för att kunna mata in tal efter man har skrivit ut ett räknetecken (operator) eller tryckt 'Clear'

          //enkelt sagt: alla bool-variabler återställs till "default" för att mata in ett tal, som när man startade programmet

            trycktSiffra = false;
            trycktNoll = false;

            trycktPI = false;
            trycktKomma = false;
            trycktNegative = false;
            trycktSqrt = false;
            trycktUpphöjt = false;
        }

        private void FixaLabel()
        {
            Label.Text = null;
            Label.Font = new Font("Calibri Light", 13);
        }

        private void Uträkning(string[] uttryck)
        {
            double svar = 0.0f;
            double talTillVänster = UndersökaTalet(uttryck[0]);

            for (int i = 1; i < uttryck.Length; i += 2)
            {
                string op = uttryck[i];
                double talTillHöger = UndersökaTalet(uttryck[i + 1]);

                if (op == buttonMultiplikation.Text)
                    talTillVänster *= talTillHöger;

                else if (op == buttonDivison.Text)
                    talTillVänster /= talTillHöger;

                else if (op == buttonPlus.Text)
                {
                    svar += talTillVänster;
                    talTillVänster = talTillHöger;
                }

                else if (op == buttonMinus.Text)
                {
                    svar += talTillVänster;
                    talTillVänster = 0 - talTillHöger;
                }
            }
            svar += talTillVänster;
            Svar.Text = svar.ToString();
        }

        private double UndersökaTalet(string talAttUndersökas)
        {
            double talet;

            if (talAttUndersökas == buttonPi.Text)
                talet = Math.PI;

            else if (talAttUndersökas == buttonMinus.Text + buttonPi.Text)
                talet = 0 - Math.PI;

            else
            {
                try
                {
                    talet = double.Parse(talAttUndersökas);
                }
                catch
                {
                    if (talAttUndersökas.Contains(buttonUpphöjt.Text))
                    {
                        char[] potens = string.Join(string.Empty, talAttUndersökas.Split()).ToCharArray();

                        talet = PotensTal(potens);
                    }
                    else
                        talet = SquareRootNumExtract(talAttUndersökas);
                }
            }
            return talet;
        }

        private double PotensTal(char[] potensen)
        {
            double detUpphöjdaTalet;

            string num = null;
            double number;

            string expNum = null;
            double exponentialNumber;

            int i;
            for (i = 0; i < potensen.Length; i++)
            {
                if (potensen[i].ToString() == buttonUpphöjt.Text)
                    break;
                else
                    num += potensen[i];
            }
            for (i++; i < potensen.Length; i++)
                expNum += potensen[i];

            number = TalbasExponentKonvertering(num);
            exponentialNumber = TalbasExponentKonvertering(expNum);

            return detUpphöjdaTalet = Math.Pow(number, exponentialNumber);
        }

        private double TalbasExponentKonvertering(string potensNummerAttUndersöka)
        {
            double tal;

            if (potensNummerAttUndersöka == buttonPi.Text)
                tal = Math.PI;

            else if (potensNummerAttUndersöka == buttonMinus.Text + buttonPi.Text)
                tal = 0 - Math.PI;

            else if (potensNummerAttUndersöka.Contains(buttonSqrt.Text + "("))
                tal = SquareRootNumExtract(potensNummerAttUndersöka);

            else if (potensNummerAttUndersöka.Contains(buttonUpphöjt.Text))
                tal = PotensTal(string.Join(string.Empty, potensNummerAttUndersöka.Split()).ToCharArray());

            else
                tal = double.Parse(potensNummerAttUndersöka);

            return tal;
        }

        private double SquareRootNumExtract(string talAttExtrahera)
        {
            double extraheradeTalet;

            string SquareRootNum = null;
            char[] squareRootNumArr = string.Join(string.Empty, talAttExtrahera.Split()).ToCharArray();
            bool negativtTal = false;

            int index;
            if (talAttExtrahera.Contains(buttonMinus.Text))
            {
                index = 3;
                negativtTal = true;
            }
            else
                index = 2;

            for (int i = index; i < squareRootNumArr.Length; i++)
                SquareRootNum += squareRootNumArr[i].ToString();

            if (SquareRootNum == buttonPi.Text)
                extraheradeTalet = Math.Sqrt(Math.PI);
            else
                extraheradeTalet = Math.Sqrt(double.Parse(SquareRootNum));

            if (negativtTal == true)
                extraheradeTalet = 0 - extraheradeTalet;

            return extraheradeTalet;
        }
    }
}