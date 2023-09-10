using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //definiert welche Index im ComboBox am Programmstart ausgewält wird
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
        }

        private void ButtonBerechnen_Click(object sender, EventArgs e)
        {
            float zahl1, zahl2, ergebnis = 0;
            bool divDurchNull = false;
            //die beiden Zahlen einlesen und konvertieren
            zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            zahl2 = Convert.ToSingle(textBoxZahl2.Text);
            //die Rechenoperation ermitteln und ausführen
            if (comboBox.SelectedIndex == 0)
                ergebnis = zahl1 + zahl2;
            if (comboBox.SelectedIndex == 1)
                ergebnis = zahl1 - zahl2;
            if (comboBox.SelectedIndex == 2)
                ergebnis = zahl1 * zahl2;
            if (comboBox.SelectedIndex == 3)
            {
                //wird eine Division durch Null versucht?
                if (zahl2 == 0)
                    divDurchNull = true;
                else
                    ergebnis = zahl1 / zahl2;
            }
            //wurde durch Null dividiert?
            if (divDurchNull == true)
                labelAnzeige.Text = "Nicht definiert!";
            else
                labelAnzeige.Text = Convert.ToString(ergebnis);
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
