using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordCup.Properties;

namespace wordCup
{
    internal partial class TreeFinal : Form
    {
        List<Equipe> s1;
        List<Equipe> s2;
        List<Equipe> s3;
        List<Equipe> s4;
        List<Equipe> s5;
        List<Equipe> s6;
        List<Equipe> s7;
        List<Equipe> s8;

       public  List<Equipe> gA;
       public  List<Equipe> gB;
       public  List<Equipe> gC;
       public  List<Equipe> gD;
       public  List<Equipe> gE;
       public  List<Equipe> gF;
       public  List<Equipe> gG;
       public  List<Equipe> gH;

        public Rankings rk;

        ResourceManager rm;
        Label focus;


        public TreeFinal()
        {
            InitializeComponent();

            rm = Resources.ResourceManager;
            button1.BackColor = Color.Transparent;
            rk =  new Rankings();
            gA  = new List<Equipe>();
            gB  = new List<Equipe>();
            gC  = new List<Equipe>();
            gD  = new List<Equipe>();
            gE  = new List<Equipe>();
            gF  = new List<Equipe>();
            gG  = new List<Equipe>();
            gH  = new List<Equipe>();

             s1 = new List<Equipe>();
             s2 = new List<Equipe>();
             s3 = new List<Equipe>();
             s4 = new List<Equipe>();
             s5 = new List<Equipe>();
             s6 = new List<Equipe>();
             s7 = new List<Equipe>();
             s8 = new List<Equipe>();


        }

        public void setData()
        {

            Random r = new Random();

            //----
            if(gA.Count >0 && gB.Count > 0)
            {
                s1.Add(gA[0]);
                s1.Add(gB[1]);

                S1_A1.Image = (Bitmap)rm.GetObject(s1[0].flag);
                S1_B2.Image = (Bitmap)rm.GetObject(s1[1].flag);
                S1A1_L.Text = s1[0].nom;
                S1B2_L.Text = s1[1].nom;
                S1A1_X.Text = r.Next(0, 6).ToString();
                S1B2_X.Text = random_except_N(r, Int32.Parse(S1A1_X.Text)).ToString();


                s3.Add(gB[0]);
                s3.Add(gA[1]);
                S3_B1.Image = (Bitmap)rm.GetObject(s3[0].flag);
                S3_A2.Image = (Bitmap)rm.GetObject(s3[1].flag);
                S3B1_L.Text = s3[0].nom;
                S3A2_L.Text = s3[1].nom;
                S3B1_X.Text = r.Next(0, 6).ToString();
                S3A2_X.Text = random_except_N(r,Int32.Parse(S3B1_X.Text)).ToString();

            }



            if (gC.Count > 0 && gD.Count > 0)
            {
                s2.Add(gC[0]);
                s2.Add(gD[1]);
                S2_C1.Image = (Bitmap)rm.GetObject(s2[0].flag);
                S2_D2.Image = (Bitmap)rm.GetObject(s2[1].flag);
                S2C1_L.Text = s2[0].nom;
                S2D2_L.Text = s2[1].nom;
                S2C1_X.Text = r.Next(0, 6).ToString();
                S2D2_X.Text = random_except_N(r, Int32.Parse(S2C1_X.Text)).ToString();


                s4.Add(gD[0]);
                s4.Add(gC[1]);
                S4_D1.Image = (Bitmap)rm.GetObject(s4[0].flag);
                S4_C2.Image = (Bitmap)rm.GetObject(s4[1].flag);
                S4D1_L.Text = s4[0].nom;
                S4C2_L.Text = s4[1].nom;
                S4D1_X.Text = r.Next(0, 6).ToString();
                S4C2_X.Text = random_except_N(r, Int32.Parse(S4D1_X.Text)).ToString();
            }


            if (gE.Count > 0 && gF.Count > 0)
            {

                s5.Add(gE[0]);
                s5.Add(gF[1]);
                S5_E1.Image = (Bitmap)rm.GetObject(s5[0].flag);
                S5_F2.Image = (Bitmap)rm.GetObject(s5[1].flag);
                S5E1_L.Text = s5[0].nom;
                S5F2_L.Text = s5[1].nom;
                S5E1_X.Text = r.Next(0, 6).ToString();
                S5F2_X.Text = random_except_N(r, Int32.Parse(S5E1_X.Text)).ToString();


                s7.Add(gF[0]);
                s7.Add(gE[1]);
                S7_F1.Image = (Bitmap)rm.GetObject(s7[0].flag);
                S7_E2.Image = (Bitmap)rm.GetObject(s7[1].flag);
                S7F1_L.Text = s7[0].nom;
                S7E2_L.Text = s7[1].nom;
                S7F1_X.Text = r.Next(0, 6).ToString();
                S7E2_X.Text = random_except_N(r, Int32.Parse(S7F1_X.Text)).ToString();
            }


            if (gE.Count > 0 && gF.Count > 0)
            {
                s6.Add(gG[0]);
                s6.Add(gH[1]);
                S6_G1.Image = (Bitmap)rm.GetObject(s6[0].flag);
                S6_H2.Image = (Bitmap)rm.GetObject(s6[1].flag);
                S6G1_L.Text = s6[0].nom;
                S6H2_L.Text = s6[1].nom;
                S6G1_X.Text = r.Next(0, 6).ToString();
                S6H2_X.Text = random_except_N(r, Int32.Parse(S6G1_X.Text)).ToString();


                s8.Add(gH[0]);
                s8.Add(gG[1]);
                S8_H1.Image = (Bitmap)rm.GetObject(s8[0].flag);
                S8_G2.Image = (Bitmap)rm.GetObject(s8[1].flag);
                S8H1_L.Text = s8[0].nom;
                S8G2_L.Text = s8[1].nom;
                S8H1_X.Text = r.Next(0, 6).ToString();
                S8G2_X.Text = random_except_N(r, Int32.Parse(S8H1_X.Text)).ToString();
            }

        }

        private void TreeFinal_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            setQuarter();
            setSemi();
            setFinal();
            setClassement();
        }

        public void setQuarter()
        {
            Random r = new Random();

            if (!S1A1_X.Text.Equals("X") && !S1B2_X.Text.Equals("X") && !S2C1_X.Text.Equals("X") && !S2D2_X.Text.Equals("X"))
            {
                if (Int32.Parse(S1A1_X.Text) > Int32.Parse(S1B2_X.Text))
                {
                    Q1S1.Image = (Bitmap)rm.GetObject(s1[0].flag);
                    S1A1_W.Image = Resources.green;
                    S1B2_W.Image = Resources.red;
                    Q1S1_L.Text = s1[0].nom;
                    Q1S1_X.Text = r.Next(0, 6).ToString();

                }
                else
                {
                    S1A1_W.Image = Resources.red;
                    S1B2_W.Image = Resources.green;
                    Q1S1.Image = (Bitmap)rm.GetObject(s1[1].flag);
                    Q1S1_L.Text = s1[1].nom;
                    Q1S1_X.Text = r.Next(0, 6).ToString();
                }


                if (Int32.Parse(S3B1_X.Text) > Int32.Parse(S3A2_X.Text))
                {
                    S3_B1_W.Image = Resources.green;
                    S3_B2_W.Image = Resources.red;
                    Q3S3.Image = (Bitmap)rm.GetObject(s3[0].flag);
                    Q3S3_L.Text = s3[0].nom;
                    Q3S3_X.Text = r.Next(0, 6).ToString();
                }
                else
                {
                    S3_B1_W.Image = Resources.red;
                    S3_B2_W.Image = Resources.green;
                    Q3S3.Image = (Bitmap)rm.GetObject(s3[1].flag);
                    Q3S3_L.Text = s3[1].nom;
                    Q3S3_X.Text = r.Next(0, 6).ToString();

                }


                if (Int32.Parse(S2C1_X.Text) > Int32.Parse(S2D2_X.Text))
                {
                    S2_C1_W.Image = Resources.green;
                    S2_D2_W.Image = Resources.red;
                    Q1S2.Image = (Bitmap)rm.GetObject(s2[0].flag);
                    Q1S2_L.Text = s2[0].nom;
                    Q1S2_X.Text = random_except_N(r, Int32.Parse(Q1S1_X.Text)).ToString();

                }
                else
                {
                    S2_C1_W.Image = Resources.red;
                    S2_D2_W.Image = Resources.green;
                    Q1S2.Image = (Bitmap)rm.GetObject(s2[1].flag);
                    Q1S2_L.Text = s2[1].nom;
                    Q1S2_X.Text = random_except_N(r, Int32.Parse(Q3S3_X.Text)).ToString();
                }


                if (Int32.Parse(S4D1_X.Text) > Int32.Parse(S4C2_X.Text))
                {
                    S4_D1_W.Image = Resources.green;
                    S4_C2_W.Image = Resources.red;
                    Q3S4.Image = (Bitmap)rm.GetObject(s4[0].flag);
                    Q3S4_L.Text = s4[0].nom;
                    Q3S4_X.Text = random_except_N(r, Int32.Parse(Q3S3_X.Text)).ToString();
                }
                else
                {
                    S4_D1_W.Image = Resources.red;
                    S4_C2_W.Image = Resources.green;
                    Q3S4.Image = (Bitmap)rm.GetObject(s4[1].flag);
                    Q3S4_L.Text = s4[1].nom;
                    Q3S4_X.Text = random_except_N(r, Int32.Parse(Q3S3_X.Text)).ToString();

                }

            }

            //////////

            if (!S3B1_X.Text.Equals("X") && !S3A2_X.Text.Equals("X") && !S4D1_X.Text.Equals("X") && !S4C2_X.Text.Equals("X"))
            {
                if (Int32.Parse(S5E1_X.Text) > Int32.Parse(S5F2_X.Text))
                {
                    S5_E1_W.Image = Resources.green;
                    S5_F2_W.Image = Resources.red;
                    Q2S5.Image = (Bitmap)rm.GetObject(s5[0].flag);
                    Q2S5_L.Text = s5[0].nom;
                    Q2S5_X.Text = r.Next(0, 6).ToString();

                }
                else
                {
                    S5_E1_W.Image = Resources.red;
                    S5_F2_W.Image = Resources.green;
                    Q2S5.Image = (Bitmap)rm.GetObject(s5[1].flag);
                    Q2S5_L.Text = s5[1].nom;
                    Q2S5_X.Text = r.Next(0, 6).ToString();
                }

                if (Int32.Parse(S7F1_X.Text) > Int32.Parse(S7E2_X.Text))
                {
                    S7_F1_W.Image = Resources.green;
                    S7_E2_W.Image = Resources.red;
                    Q4S7.Image = (Bitmap)rm.GetObject(s7[0].flag);
                    Q4S7_L.Text = s7[0].nom;
                    Q4S7_X.Text = r.Next(0, 6).ToString();

                }
                else
                {
                    S7_F1_W.Image = Resources.red;
                    S7_E2_W.Image = Resources.green;
                    Q4S7.Image = (Bitmap)rm.GetObject(s7[1].flag);
                    Q4S7_L.Text = s7[1].nom;
                    Q4S7_X.Text = r.Next(0, 6).ToString();
                }


                if (Int32.Parse(S6G1_X.Text) > Int32.Parse(S6H2_X.Text))
                {
                    S6_G1_W.Image = Resources.green;
                    S6_H2_W.Image = Resources.red;
                    Q2S6.Image = (Bitmap)rm.GetObject(s6[0].flag);
                    Q2S6_L.Text = s6[0].nom;
                    Q2S6_X.Text = random_except_N(r, Int32.Parse(Q2S5_X.Text)).ToString();

                }
                else
                {
                    S6_G1_W.Image = Resources.red;
                    S6_H2_W.Image = Resources.green;
                    Q2S6.Image = (Bitmap)rm.GetObject(s6[1].flag);
                    Q2S6_L.Text = s6[1].nom;
                    Q2S6_X.Text = random_except_N(r, Int32.Parse(Q2S5_X.Text)).ToString();
                }


                if (Int32.Parse(S8H1_X.Text) > Int32.Parse(S8G2_X.Text))
                {
                    S8_H1_W.Image = Resources.green;
                    S8_G2_W.Image = Resources.red;
                    Q4S8.Image = (Bitmap)rm.GetObject(s8[0].flag);
                    Q4S8_L.Text = s8[0].nom;
                    Q4S8_X.Text = random_except_N(r, Int32.Parse(Q2S6_X.Text)).ToString();

                }
                else
                {
                    S8_H1_W.Image = Resources.red;
                    S8_G2_W.Image = Resources.green;
                    Q4S8.Image = (Bitmap)rm.GetObject(s8[1].flag);
                    Q4S8_L.Text = s8[1].nom;
                    Q4S8_X.Text = random_except_N(r, Int32.Parse(Q2S6_X.Text)).ToString();
                }


            }

        }


        public static int random_except_N(Random rand ,int n)
        {
            Random r = rand;
            int result = r.Next(0, 6);
            while (result.Equals(n))
            {
                result = r.Next(0, 6);
            }
            
            return result;
        }


        public void setSemi()
        {
            Random r = new Random();

            if (!Q1S1_X.Text.Equals("X") && !Q1S2_X.Text.Equals("X") && !Q2S5_X.Text.Equals("X") && !Q2S6_X.Text.Equals("X"))
            {
                if (Int32.Parse(Q1S1_X.Text) > Int32.Parse(Q1S2_X.Text))
                {
                    Q1S1_W.Image = Resources.green;
                    Q1S2_W.Image = Resources.red;


                    SF1Q1.Image = Q1S1.Image;
                    SF1Q1_L.Text = Q1S1_L.Text;
                    SF1Q1_X.Text = r.Next(0, 6).ToString();

                }
                else
                {
                    Q1S1_W.Image = Resources.red;
                    Q1S2_W.Image = Resources.green;
                    SF1Q1.Image = Q1S2.Image;
                    SF1Q1_L.Text = Q1S2_L.Text;
                    SF1Q1_X.Text = r.Next(0, 6).ToString();
                }

                if (Int32.Parse(Q2S5_X.Text) > Int32.Parse(Q2S6_X.Text))
                {
                    Q2S5_W.Image = Resources.green;
                    Q2S6_W.Image = Resources.red;
                    SF1Q2.Image = Q2S5.Image;
                    SF1Q2_L.Text = Q2S5_L.Text;
                    SF1Q2_X.Text = random_except_N(r, Int32.Parse(SF1Q1_X.Text)).ToString();

                }
                else
                {
                    Q2S5_W.Image = Resources.red;
                    Q2S6_W.Image = Resources.green;
                    SF1Q2.Image = Q2S6.Image;
                    SF1Q2_L.Text = Q2S6_L.Text;
                    SF1Q2_X.Text = random_except_N(r, Int32.Parse(SF1Q1_X.Text)).ToString();
                }

            }


            if(!Q3S3_X.Text.Equals("X") && !Q3S4_X.Text.Equals("X") && !Q4S7_X.Text.Equals("X") && !Q4S8_X.Text.Equals("X"))
            {
                if (Int32.Parse(Q3S3_X.Text) > Int32.Parse(Q3S4_X.Text))
                {
                    Q3S3_W.Image = Resources.green;
                    Q3S4_W.Image = Resources.red;
                    SF2Q3.Image = Q3S3.Image;
                    SF2Q3_L.Text = Q3S3_L.Text;
                    SF2Q3_X.Text = r.Next(0, 6).ToString();

                }
                else
                {
                    Q3S3_W.Image = Resources.red;
                    Q3S4_W.Image = Resources.green;
                    SF2Q3.Image = Q3S4.Image;
                    SF2Q3_L.Text = Q3S4_L.Text;
                    SF2Q3_X.Text = r.Next(0, 6).ToString();
                }

                if (Int32.Parse(Q4S7_X.Text) > Int32.Parse(Q4S8_X.Text))
                {
                    Q4S7_W.Image = Resources.green;
                    Q4S8_W.Image = Resources.red;
                    SF2Q4.Image = Q4S7.Image;
                    SF2Q4_L.Text = Q4S7_L.Text;
                    SF2Q4_X.Text = random_except_N(r, Int32.Parse(SF2Q3_X.Text)).ToString();

                }
                else
                {
                    Q4S7_W.Image = Resources.red;
                    Q4S8_W.Image = Resources.green;
                    SF2Q4.Image = Q4S8.Image;
                    SF2Q4_L.Text = Q4S8_L.Text;
                    SF2Q4_X.Text = random_except_N(r, Int32.Parse(SF2Q3_X.Text)).ToString();
                }

            }

        }

        public void setFinal()
        {
            Random r = new Random();

            if (!SF1Q1_X.Text.Equals("X") && !SF1Q2_X.Text.Equals("X") && !SF2Q3_X.Text.Equals("X") && !SF2Q4_X.Text.Equals("X"))
            {
                if (Int32.Parse(SF1Q1_X.Text) > Int32.Parse(SF1Q2_X.Text))
                {
                    final1.Image = SF1Q1.Image;
                    final1_L.Text = SF1Q1_L.Text;
                    final1_X.Text = r.Next(0, 6).ToString();

                    SF1Q1_W.Image = Resources.green;
                    SF1Q2_W.Image = Resources.red;



                    thirdPlace1.Image = SF1Q2.Image;
                    thirdPlace1_L.Text = SF1Q2_L.Text;
                    thirdPlace1_X.Text = r.Next(0, 6).ToString();

                }
                else
                {
                    SF1Q1_W.Image = Resources.red;
                    SF1Q2_W.Image = Resources.green;

                    final1.Image = SF1Q2.Image;
                    final1_L.Text = SF1Q2_L.Text;
                    final1_X.Text = r.Next(0, 6).ToString();

                    thirdPlace1.Image = SF1Q1.Image;
                    thirdPlace1_L.Text = SF1Q1_L.Text;
                    thirdPlace1_X.Text = r.Next(0, 6).ToString();
                }

                if (Int32.Parse(SF2Q3_X.Text) > Int32.Parse(SF2Q4_X.Text))
                {
                    SF2Q3_W.Image = Resources.green;
                    SF2Q4_W.Image = Resources.red;
                    final2.Image = SF2Q3.Image;
                    final2_L.Text = SF2Q3_L.Text;
                    final2_X.Text = random_except_N(r, Int32.Parse(final1_X.Text)).ToString();

                    thirdPlace2.Image = SF2Q4.Image;
                    thirdPlace2_L.Text = SF2Q4_L.Text;
                    thirdPlace2_X.Text = random_except_N(r, Int32.Parse(thirdPlace1_X.Text)).ToString();

                }
                else
                {
                    SF2Q3_W.Image = Resources.red;
                    SF2Q4_W.Image = Resources.green;

                    final2.Image = SF2Q4.Image;
                    final2_L.Text = SF2Q4_L.Text;
                    final2_X.Text = random_except_N(r, Int32.Parse(final1_X.Text)).ToString();

                    thirdPlace2.Image = SF2Q3.Image;
                    thirdPlace2_L.Text = SF2Q3_L.Text;
                    thirdPlace2_X.Text = random_except_N(r, Int32.Parse(thirdPlace1_X.Text)).ToString();
                }
            }

        }

        public void setClassement()
        {
            if (!final1_X.Text.Equals("X") && !final2_X.Text.Equals("X") && !thirdPlace1_X.Text.Equals("X") && !thirdPlace2_X.Text.Equals("X"))
            {
                if (Int32.Parse(final1_X.Text) > Int32.Parse(final2_X.Text))
                {
                    first.Image = final1.Image;
                    first_L.Text = final1_L.Text;

                    final1_W.Image = Resources.green;
                    final2_W.Image = Resources.red;



                    sec.Image = final2.Image;
                    sec_L.Text = final2_L.Text;

                }
                else
                {
                    final1_W.Image = Resources.red;
                    final2_W.Image = Resources.green;

                    first.Image = final2.Image;
                    first_L.Text = final2_L.Text;

                    sec.Image = final1.Image;
                    sec_L.Text = final1_L.Text;

                }

                if (Int32.Parse(thirdPlace1_X.Text) > Int32.Parse(thirdPlace2_X.Text))
                {
                    thirdPlace1_W.Image = Resources.green;
                    thirdPlace2_W.Image = Resources.red;


                    third.Image = thirdPlace1.Image;
                    third_L.Text = thirdPlace1_L.Text;

                    fourth.Image = thirdPlace2.Image;
                    fourth_L.Text = thirdPlace2_L.Text;
                }
                else
                {
                    thirdPlace1_W.Image = Resources.red;
                    thirdPlace2_W.Image = Resources.green;

                    third.Image = thirdPlace2.Image;
                    third_L.Text = thirdPlace2_L.Text;

                    fourth.Image = thirdPlace1.Image;
                    fourth_L.Text = thirdPlace1_L.Text;
                }

                Win w = new Win();
                w.setPicture(first_L.Text.ToString());
                w.Show();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rk.Visible = true;
        }

        private void TreeFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void S1A1_X_Click(object sender, EventArgs e)
        {
            focus = (Label)sender;
            ///

            S1A1_X.BackColor = Color.White; S3B1_X.BackColor = Color.White; 
            S1B2_X.BackColor = Color.White; S3A2_X.BackColor = Color.White;

            S2C1_X.BackColor = Color.White; S4D1_X.BackColor = Color.White;
            S2D2_X.BackColor = Color.White; S4C2_X.BackColor = Color.White;

            S5E1_X.BackColor = Color.White; S7F1_X.BackColor = Color.White;
            S5F2_X.BackColor = Color.White; S7E2_X.BackColor = Color.White;

            S6G1_X.BackColor = Color.White;  S8H1_X.BackColor = Color.White;
            S6H2_X.BackColor = Color.White;  S8G2_X.BackColor = Color.White;

            ///

            focus.BackColor = Color.Yellow;

            if (!focus.Text.Equals("X"))
            {
                numericUpDown1.Value = Int32.Parse(focus.Text.ToString());
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(focus != null)
              focus.Text = numericUpDown1.Value.ToString();
        }
    }
}





