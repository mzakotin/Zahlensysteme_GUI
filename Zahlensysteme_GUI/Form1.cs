using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlensysteme_GUI
{
    public partial class Fm_Zahlensysteme : Form
    {
        public Fm_Zahlensysteme()
        {
            InitializeComponent();
            //string binaer = TB_Binaer.Text;
            //string oktal = TB_Oktal.Text;
            //int dezimal = Convert.ToInt32(TB_Dezimal.Text);
            //string hexa = TB_Hexadezimal.Text;
        }

        private void Fm_Zahlensysteme_Load(object sender, EventArgs e)
        {
            RB_Binaer.Checked = false;
            RB_Oktal.Checked = false;
            RB_Dezimal.Checked = false;
            RB_Hexadezimal.Checked = false;
        }


        private void Bt_umrechnen_Click(object sender, EventArgs e)
        { //1 von 4 Radiobuttons auf true gesetzt

                foreach (var item in GB_Zahlensysteme.Controls)
                {
                    Console.WriteLine(item.ToString());

                //Binärsystem ausgewählt
                if (RB_Binaer.Checked == true)
                {
                    string binaer = TB_Binaer.Text;
                    int dezimal = 0;
                    int rest;
                    int dezimal_okt;
                    int dezimal_hexa;
                    string reverse = "";
                    int exponent = 0;
                    string oktal = "";
                    string hex = "";

                    //Umrechnung in dezimal
                    foreach (char c in binaer)
                    {
                        reverse = c + reverse;
                    }
                    foreach (char c in reverse)
                    {
                        dezimal = dezimal + int.Parse(c.ToString()) * (int)Math.Pow(2, exponent);
                        exponent = exponent + 1;
                    }
                    TB_Dezimal.Text = dezimal.ToString();

                    //Umrechnung in oktal
                    dezimal_okt = dezimal;
                    while (dezimal_okt > 0)
                    {
                        rest = dezimal_okt % 8;
                        dezimal_okt = dezimal_okt / 8;
                        oktal = rest + oktal;
                    }
                    TB_Oktal.Text = oktal;

                    //Umrechnung in hexadezimal
                    dezimal_hexa = dezimal;
                    while (dezimal_hexa > 0)
                    {
                        rest = dezimal_hexa % 16;
                        dezimal_hexa = dezimal_hexa / 16;

                        switch (rest)
                        {
                            case 10: { hex = "A" + hex; } break;
                            case 11: { hex = "B" + hex; } break;
                            case 12: { hex = "C" + hex; } break;
                            case 13: { hex = "D" + hex; } break;
                            case 14: { hex = "E" + hex; } break;
                            case 15: { hex = "F" + hex; } break;
                            default: { hex = rest + hex; } break;


                        }
                    }
                    TB_Hexadezimal.Text = hex;
                }

                //Oktalsystem ausgewählt
                else if (RB_Oktal.Checked == true)
                {
                    string oktal = TB_Oktal.Text;
                    int dezimal = 0;
                    int rest;
                    int dezimal_bin;
                    int dezimal_hexa;
                    string reverse = "";
                    int exponent = 0;
                    string binaer = "";
                    string hex = "";

                    //Umrechnung in dezimal
                    foreach (char c in oktal)
                    {
                        reverse = c + reverse;
                    }
                    foreach (char c in reverse)
                    {
                        dezimal = dezimal + int.Parse(c.ToString()) * (int)Math.Pow(8, exponent);
                        exponent = exponent + 1;
                    }
                    TB_Dezimal.Text = dezimal.ToString();

                    //Umrechung in binär
                    dezimal_bin = dezimal;
                    while (dezimal_bin > 0)
                    {
                        rest = dezimal_bin % 2;
                        dezimal_bin = dezimal_bin / 2;
                        binaer = rest + binaer;
                    }
                    TB_Binaer.Text = binaer;

                    //Umrechung in hexadezimal
                    dezimal_hexa = dezimal;
                    while (dezimal_hexa > 0)
                    {
                        rest = dezimal_hexa % 16;
                        dezimal_hexa = dezimal_hexa / 16;

                        switch (rest)
                        {
                            case 10: { hex = "A" + hex; } break;
                            case 11: { hex = "B" + hex; } break;
                            case 12: { hex = "C" + hex; } break;
                            case 13: { hex = "D" + hex; } break;
                            case 14: { hex = "E" + hex; } break;
                            case 15: { hex = "F" + hex; } break;
                            default: { hex = rest + hex; } break;


                        }

                    }
                    TB_Hexadezimal.Text = hex;
                }

                //Dezimalsystem ausgewählt
                else if (RB_Dezimal.Checked == true && TB_Dezimal.Text != "")
                {
                    int dezimal_bin;
                    int dezimal_okt;
                    int dezimal_hex;
                    int rest;
                    string binaer = "";
                    string oktal = "";
                    string hex = "";

                    //Umrechnung in binär
                    dezimal_bin = Convert.ToInt32(TB_Dezimal.Text);
                    while (dezimal_bin > 0)
                    {
                        rest = dezimal_bin % 2;
                        dezimal_bin = dezimal_bin / 2;
                        binaer = rest + binaer;
                    }
                    TB_Binaer.Text = binaer;

                    //Umrechnung in oktal
                    dezimal_okt = Convert.ToInt32(TB_Dezimal.Text);
                    while (dezimal_okt > 0)
                    {
                        rest = dezimal_okt % 8;
                        dezimal_okt = dezimal_okt / 8;
                        oktal = rest + oktal;
                    }
                    TB_Oktal.Text = oktal;

                    //Umrechung in hexadezimal
                    dezimal_hex = Convert.ToInt32(TB_Dezimal.Text);
                    while (dezimal_hex > 0)
                    {
                        rest = dezimal_hex % 16;
                        dezimal_hex = dezimal_hex / 16;

                        switch (rest)
                        {
                            case 10: { hex = "A" + hex; } break;
                            case 11: { hex = "B" + hex; } break;
                            case 12: { hex = "C" + hex; } break;
                            case 13: { hex = "D" + hex; } break;
                            case 14: { hex = "E" + hex; } break;
                            case 15: { hex = "F" + hex; } break;
                            default: { hex = rest + hex; } break;


                        }
                    }
                    TB_Hexadezimal.Text = hex;
                } 
                


                    //Hexadezimalsystem ausgewählt
                    else if (RB_Hexadezimal.Checked == true)
                    {
                        string hex = TB_Hexadezimal.Text;
                        int dezimal = 0;
                        int rest;
                        int dezimal_bin;
                        int dezimal_okt;
                        string reverse = "";
                        int exponent = 0;
                        string binaer = "";
                        string oktal = "";

                        //Umrechnung in dezimal
                        foreach (char c in hex)
                        {
                            reverse = c + reverse;
                        }

                        foreach (char c in reverse)
                        {
                            switch (c)
                            {
                                case 'A': { dezimal = dezimal + 10 * (int)Math.Pow(16, exponent); } break;
                                case 'B': { dezimal = dezimal + 11 * (int)Math.Pow(16, exponent); } break;
                                case 'C': { dezimal = dezimal + 12 * (int)Math.Pow(16, exponent); } break;
                                case 'D': { dezimal = dezimal + 13 * (int)Math.Pow(16, exponent); } break;
                                case 'E': { dezimal = dezimal + 14 * (int)Math.Pow(16, exponent); } break;
                                case 'F': { dezimal = dezimal + 15 * (int)Math.Pow(16, exponent); } break;
                                default: { dezimal = dezimal + int.Parse(c.ToString()) * (int)Math.Pow(16, exponent); } break;
                            }
                            exponent = exponent + 1;
                        }
                        TB_Dezimal.Text = dezimal.ToString();

                        //Umrechnung in binär
                        dezimal_bin = dezimal;
                        while (dezimal_bin > 0)
                        {
                            rest = dezimal_bin % 2;
                            dezimal_bin = dezimal_bin / 2;
                            binaer = rest + binaer;
                        }
                        TB_Binaer.Text = binaer;

                        //Umrechnung in oktal
                        dezimal_okt = dezimal;
                        while (dezimal_okt > 0)
                        {
                            rest = dezimal_okt % 8;
                            dezimal_okt = dezimal_okt / 8;
                            oktal = rest + oktal;
                        }
                        TB_Oktal.Text = oktal;
                    }


                }
            

            //falls alle Radiobuttons auf false gesetzt
            if ((TB_Binaer.Text == "" && RB_Binaer.Checked == false) && (TB_Oktal.Text == "" && RB_Oktal.Checked == false) &&
                (TB_Dezimal.Text == "" && RB_Dezimal.Checked == false) && (TB_Hexadezimal.Text == "" && RB_Hexadezimal.Checked == false))
            {
                MessageBox.Show("Kein Zahlensystem ausgewählt!");
            }

            if (RB_Binaer.Checked == true && TB_Binaer.Text == "") { MessageBox.Show("Keine Binärzahl eingetragen!");  }
            if (RB_Oktal.Checked == true && TB_Oktal.Text == "") { MessageBox.Show("Keine Oktalzahl eingetragen!"); }
            if (RB_Dezimal.Checked == true && TB_Dezimal.Text == "") { MessageBox.Show("Keine Dezimalzahl eingetragen!");  }
            if (TB_Hexadezimal.Text == "" && RB_Hexadezimal.Checked == true) { MessageBox.Show("Keine Hexadezimalzahl eingetragen!"); }

        }

        private void RB_Binaer_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Binaer.Checked == true)
            {
                TB_Binaer.ReadOnly = false;
                TB_Oktal.ReadOnly = true;
                TB_Dezimal.ReadOnly = true;
                TB_Hexadezimal.ReadOnly = true;

                //Textboxen leeren
                TB_Binaer.Clear();
                TB_Oktal.Clear();
                TB_Dezimal.Clear();
                TB_Hexadezimal.Clear();
            }
        }

        private void RB_Oktal_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Oktal.Checked == true)
            {
                TB_Binaer.ReadOnly = true;
                TB_Oktal.ReadOnly = false;
                TB_Dezimal.ReadOnly = true;
                TB_Hexadezimal.ReadOnly = true;

                //Textboxen leeren
                TB_Binaer.Clear();
                TB_Oktal.Clear();
                TB_Dezimal.Clear();
                TB_Hexadezimal.Clear();
            }
        }

        private void RB_Dezimal_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Dezimal.Checked == true)
            {
                TB_Binaer.ReadOnly = true;
                TB_Oktal.ReadOnly = true;
                TB_Dezimal.ReadOnly = false;
                TB_Hexadezimal.ReadOnly = true;

                //Textboxen leeren
                TB_Binaer.Clear();
                TB_Oktal.Clear();
                TB_Dezimal.Clear();
                TB_Hexadezimal.Clear();
            }
        }

        private void RB_Hexadezimal_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Hexadezimal.Checked == true)
            {
                TB_Binaer.ReadOnly = true;
                TB_Oktal.ReadOnly = true;
                TB_Dezimal.ReadOnly = true;
                TB_Hexadezimal.ReadOnly = false;

                //Textboxen leeren
                TB_Binaer.Clear();
                TB_Oktal.Clear();
                TB_Dezimal.Clear();
                TB_Hexadezimal.Clear();
            }
        }

        private void Bt_beenden_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
