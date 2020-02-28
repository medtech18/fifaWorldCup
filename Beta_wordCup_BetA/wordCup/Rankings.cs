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
    internal partial class Rankings : Form
    {
       public List<Equipe> listA;
       public List<Equipe> listB;
       public List<Equipe> listC;
       public List<Equipe> listD;
       public List<Equipe> listE;
       public List<Equipe> listF;
       public List<Equipe> listG;
       public List<Equipe> listH;
       public scheduling sc;
       public TreeFinal t;

        public Rankings()
        {
            InitializeComponent();
            sc = new scheduling();
            listA = new List<Equipe>();
            listB = new List<Equipe>();
            listC = new List<Equipe>();
            listD = new List<Equipe>();
            listE = new List<Equipe>();
            listF = new List<Equipe>();
            listG = new List<Equipe>();
            listH = new List<Equipe>();
        }

        private void Rankings_Load(object sender, EventArgs e)
        {
           
        }

        public void setTeamsInGraphicalTables()
        {
            ResourceManager rm = Resources.ResourceManager;

            if (listA.Count() >0)
            {
                listA =listA.OrderByDescending(o=>o.pts).ToList();

                A1.Image = (Bitmap)rm.GetObject(listA[0].flag);
                A1_w.Text = listA[0].w.ToString();
                A1_l.Text = listA[0].l.ToString();
                A1_d.Text = listA[0].d.ToString();
                A1_gF.Text = listA[0].gF.ToString();
                A1_gA.Text = listA[0].gA.ToString();
                // A1_gD.Text = (Int32.Parse(listA[0].gF.ToString()) - Int32.Parse(listA[0].gA.ToString())).ToString();
                //A1_pts.Text = ((listA[0].w * 3) + (listA[0].d)).ToString();
                A1_gD.Text = listA[0].gD.ToString();
                A1_pts.Text = listA[0].pts.ToString();

                A2.Image = (Bitmap)rm.GetObject(listA[1].flag);
                A2_w.Text = listA[1].w.ToString();
                A2_l.Text = listA[1].l.ToString();
                A2_d.Text = listA[1].d.ToString();
                A2_gF.Text = listA[1].gF.ToString();
                A2_gA.Text = listA[1].gA.ToString();
                //A2_gD.Text = (Int32.Parse(listA[1].gF.ToString()) - Int32.Parse(listA[1].gA.ToString())).ToString();
                //A1_pts.Text = ((listA[1].w * 3) + (listA[1].d)).ToString();
                A2_gD.Text = listA[1].gD.ToString();
                A2_pts.Text = listA[1].pts.ToString();


                A3.Image = (Bitmap)rm.GetObject(listA[2].flag);
                A3_w.Text = listA[2].w.ToString();
                A3_l.Text = listA[2].l.ToString();
                A3_d.Text = listA[2].d.ToString();
                A3_gF.Text = listA[2].gF.ToString();
                A3_gA.Text = listA[2].gA.ToString();
                // A3_gD.Text = (Int32.Parse(listA[2].gF.ToString()) - Int32.Parse(listA[2].gA.ToString())).ToString();
                A3_gD.Text = listA[2].gD.ToString();
                A3_pts.Text = listA[2].pts.ToString();



                A4.Image = (Bitmap)rm.GetObject(listA[3].flag);
                A4_w.Text =  listA[3].w.ToString();
                A4_l.Text =  listA[3].l.ToString();
                A4_d.Text =  listA[3].d.ToString();
                A4_gF.Text = listA[3].gF.ToString();
                A4_gA.Text = listA[3].gA.ToString();
                // A4_gD.Text = (Int32.Parse(listA[3].gF.ToString()) - Int32.Parse(listA[3].gA.ToString())).ToString();
                A4_gD.Text = listA[3].gD.ToString();
                A4_pts.Text = listA[3].pts.ToString();

                label1.Text = listA[0].nom;
                label2.Text = listA[1].nom;
                label3.Text = listA[2].nom;
                label4.Text = listA[3].nom;



            }
            if (listB.Count() > 0)
            {
                listB = listB.OrderByDescending(o => o.pts).ToList();

                B1.Image = (Bitmap)rm.GetObject(listB[0].flag);
                B1_w.Text = listB[0].w.ToString();
                B1_l.Text = listB[0].l.ToString();
                B1_d.Text = listB[0].d.ToString();
                B1_gF.Text = listB[0].gF.ToString();
                B1_gA.Text = listB[0].gA.ToString();
                B1_gD.Text = listB[0].gD.ToString();
                B1_pts.Text = listB[0].pts.ToString();

                B2.Image = (Bitmap)rm.GetObject(listB[1].flag);
                B2_w.Text = listB[1].w.ToString();
                B2_l.Text = listB[1].l.ToString();
                B2_d.Text = listB[1].d.ToString();
                B2_gF.Text = listB[1].gF.ToString();
                B2_gA.Text = listB[1].gA.ToString();
                B2_pts.Text = listB[1].pts.ToString();


                B3.Image = (Bitmap)rm.GetObject(listB[2].flag);
                B3_w.Text = listB[2].w.ToString();
                B3_l.Text = listB[2].l.ToString();
                B3_d.Text = listB[2].d.ToString();
                B3_gF.Text = listB[2].gF.ToString();
                B3_gA.Text = listB[2].gA.ToString();
                B3_gD.Text = listB[2].gD.ToString();
                B3_pts.Text = listB[2].pts.ToString();



                B4.Image = (Bitmap)rm.GetObject(listB[3].flag);
                B4_w.Text = listB[3].w.ToString();
                B4_l.Text = listB[3].l.ToString();
                B4_d.Text = listB[3].d.ToString();
                B4_gF.Text = listB[3].gF.ToString();
                B4_gA.Text = listB[3].gA.ToString();
                B4_gD.Text = listB[3].gD.ToString();
                B4_pts.Text = listB[3].pts.ToString();


                label5.Text = listB[0].nom;
                label6.Text = listB[1].nom;
                label7.Text = listB[2].nom;
                label8.Text = listB[3].nom;


            }

            if (listC.Count() > 0)
            {
                listC = listC.OrderByDescending(o => o.pts).ToList();

                C1.Image = (Bitmap)rm.GetObject(listC[0].flag);
                C1_w.Text = listC[0].w.ToString();
                C1_l.Text = listC[0].l.ToString();
                C1_d.Text = listC[0].d.ToString();
                C1_gF.Text = listC[0].gF.ToString();
                C1_gA.Text = listC[0].gA.ToString();
                C1_gD.Text = listC[0].gD.ToString();
                C1_pts.Text = listC[0].pts.ToString();

                C2.Image = (Bitmap)rm.GetObject(listC[1].flag);
                C2_w.Text = listC[1].w.ToString();
                C2_l.Text = listC[1].l.ToString();
                C2_d.Text = listC[1].d.ToString();
                C2_gF.Text = listC[1].gF.ToString();
                C2_gA.Text = listC[1].gA.ToString();
                C2_gD.Text = listC[1].gD.ToString();
                C2_pts.Text = listC[1].pts.ToString();


                C3.Image = (Bitmap)rm.GetObject(listC[2].flag);
                C3_w.Text = listC[2].w.ToString();
                C3_l.Text = listC[2].l.ToString();
                C3_d.Text = listC[2].d.ToString();
                C3_gF.Text = listC[2].gF.ToString();
                C3_gA.Text = listC[2].gA.ToString();
                C3_gD.Text = listC[2].gD.ToString();
                C3_pts.Text = listC[2].pts.ToString();



                C4.Image = (Bitmap)rm.GetObject(listC[3].flag);
                C4_w.Text = listC[3].w.ToString();
                C4_l.Text = listC[3].l.ToString();
                C4_d.Text = listC[3].d.ToString();
                C4_gF.Text = listC[3].gF.ToString();
                C4_gA.Text = listC[3].gA.ToString();
                C4_gD.Text = listC[3].gD.ToString();
                C4_pts.Text = listC[3].pts.ToString();


                label9.Text = listC[0].nom;
                label10.Text = listC[1].nom;
                label11.Text = listC[2].nom;
                label12.Text = listC[3].nom;

            }
            if (listD.Count() > 0)
            {
                listD = listD.OrderByDescending(o => o.pts).ToList();

                D1.Image = (Bitmap)rm.GetObject(listD[0].flag);
                D1_w.Text = listD[0].w.ToString();
                D1_l.Text = listD[0].l.ToString();
                D1_d.Text = listD[0].d.ToString();
                D1_gF.Text = listD[0].gF.ToString();
                D1_gA.Text = listD[0].gA.ToString();
                D1_gD.Text = listD[0].gD.ToString();
                D1_pts.Text = listD[0].pts.ToString();

                D2.Image = (Bitmap)rm.GetObject(listD[1].flag);
                D2_w.Text = listD[1].w.ToString();
                D2_l.Text = listD[1].l.ToString();
                D2_d.Text = listD[1].d.ToString();
                D2_gF.Text = listD[1].gF.ToString();
                D2_gA.Text = listD[1].gA.ToString();
                D2_gD.Text = listD[1].gD.ToString();
                D2_pts.Text = listD[1].pts.ToString();


                D3.Image = (Bitmap)rm.GetObject(listD[2].flag);
                D3_w.Text = listD[2].w.ToString();
                D3_l.Text = listD[2].l.ToString();
                D3_d.Text = listD[2].d.ToString();
                D3_gF.Text = listD[2].gF.ToString();
                D3_gA.Text = listD[2].gA.ToString();
                D3_gD.Text = listD[2].gD.ToString();
                D3_pts.Text = listD[2].pts.ToString();



                D4.Image = (Bitmap)rm.GetObject(listD[3].flag);
                D4_w.Text = listD[3].w.ToString();
                D4_l.Text = listD[3].l.ToString();
                D4_d.Text = listD[3].d.ToString();
                D4_gF.Text = listD[3].gF.ToString();
                D4_gA.Text = listD[3].gA.ToString();
                D4_gD.Text = listD[3].gD.ToString();
                D4_pts.Text = listD[3].pts.ToString();

                label13.Text = listD[0].nom;
                label14.Text = listD[1].nom;
                label15.Text = listD[2].nom;
                label16.Text = listD[3].nom;

            }

            if (listE.Count() > 0)
            {
                listE = listE.OrderByDescending(o => o.pts).ToList();

                E1.Image = (Bitmap)rm.GetObject(listE[0].flag);
                E1_w.Text = listE[0].w.ToString();
                E1_l.Text = listE[0].l.ToString();
                E1_d.Text = listE[0].d.ToString();
                E1_gF.Text = listE[0].gF.ToString();
                E1_gA.Text = listE[0].gA.ToString();

                E1_gD.Text = listE[0].gD.ToString();
                E1_pts.Text = listE[0].pts.ToString();

                E2.Image = (Bitmap)rm.GetObject(listE[1].flag);
                E2_w.Text = listE[1].w.ToString();
                E2_l.Text = listE[1].l.ToString();
                E2_d.Text = listE[1].d.ToString();
                E2_gF.Text = listE[1].gF.ToString();
                E2_gA.Text = listE[1].gA.ToString();
                E2_gD.Text = listE[1].gD.ToString();
                E2_pts.Text = listE[1].pts.ToString();


                E3.Image = (Bitmap)rm.GetObject(listE[2].flag);
                E3_w.Text = listE[2].w.ToString();
                E3_l.Text = listE[2].l.ToString();
                E3_d.Text = listE[2].d.ToString();
                E3_gF.Text = listE[2].gF.ToString();
                E3_gA.Text = listE[2].gA.ToString();
                E3_gD.Text = listE[2].gD.ToString();
                E3_pts.Text = listE[2].pts.ToString();



                E4.Image = (Bitmap)rm.GetObject(listE[3].flag);
                E4_w.Text = listE[3].w.ToString();
                E4_l.Text = listE[3].l.ToString();
                E4_d.Text = listE[3].d.ToString();
                E4_gF.Text = listE[3].gF.ToString();
                E4_gA.Text = listE[3].gA.ToString();
                E4_gD.Text = listE[3].gD.ToString();
                E4_pts.Text = listE[3].pts.ToString();

                label17.Text = listE[0].nom;
                label18.Text = listE[1].nom;
                label19.Text = listE[2].nom;
                label20.Text = listE[3].nom;


            }
            if (listF.Count() > 0)
            {
                listF = listF.OrderByDescending(o => o.pts).ToList();

                F1.Image = (Bitmap)rm.GetObject(listF[0].flag);
                F1_w.Text = listF[0].w.ToString();
                F1_l.Text = listF[0].l.ToString();
                F1_d.Text = listF[0].d.ToString();
                F1_gF.Text = listF[0].gF.ToString();
                F1_gA.Text = listF[0].gA.ToString();

                F1_gD.Text = listF[0].gD.ToString();
                F1_pts.Text = listF[0].pts.ToString();

                F2.Image = (Bitmap)rm.GetObject(listF[1].flag);
                F2_w.Text = listF[1].w.ToString();
                F2_l.Text = listF[1].l.ToString();
                F2_d.Text = listF[1].d.ToString();
                F2_gF.Text = listF[1].gF.ToString();
                F2_gA.Text = listF[1].gA.ToString();
                F2_gD.Text = listF[1].gD.ToString();
                F2_pts.Text = listF[1].pts.ToString();


                F3.Image = (Bitmap)rm.GetObject(listF[2].flag);
                F3_w.Text = listF[2].w.ToString();
                F3_l.Text = listF[2].l.ToString();
                F3_d.Text = listF[2].d.ToString();
                F3_gF.Text = listF[2].gF.ToString();
                F3_gA.Text = listF[2].gA.ToString();
                F3_gD.Text = listF[2].gD.ToString();
                F3_pts.Text = listF[2].pts.ToString();



                F4.Image = (Bitmap)rm.GetObject(listF[3].flag);
                F4_w.Text = listF[3].w.ToString();
                F4_l.Text = listF[3].l.ToString();
                F4_d.Text = listF[3].d.ToString();
                F4_gF.Text = listF[3].gF.ToString();
                F4_gA.Text = listF[3].gA.ToString();
                F4_gD.Text = listF[3].gD.ToString();
                F4_pts.Text = listF[3].pts.ToString();

                label21.Text = listF[0].nom;
                label22.Text = listF[1].nom;
                label23.Text = listF[2].nom;
                label24.Text = listF[3].nom;


            }

            if (listG.Count() > 0)
            {
                listG = listG.OrderByDescending(o => o.pts).ToList();

                G1.Image = (Bitmap)rm.GetObject(listG[0].flag);
                G1_w.Text = listG[0].w.ToString();
                G1_l.Text = listG[0].l.ToString();
                G1_d.Text = listG[0].d.ToString();
                G1_gF.Text = listG[0].gF.ToString();
                G1_gA.Text = listG[0].gA.ToString();

                G1_gD.Text = listG[0].gD.ToString();
                G1_pts.Text = listG[0].pts.ToString();

                G2.Image = (Bitmap)rm.GetObject(listG[1].flag);
                G2_w.Text = listG[1].w.ToString();
                G2_l.Text = listG[1].l.ToString();
                G2_d.Text = listG[1].d.ToString();
                G2_gF.Text = listG[1].gF.ToString();
                G2_gA.Text = listG[1].gA.ToString();
                G2_gD.Text = listG[1].gD.ToString();
                G2_pts.Text = listG[1].pts.ToString();


                G3.Image = (Bitmap)rm.GetObject(listG[2].flag);
                G3_w.Text = listG[2].w.ToString();
                G3_l.Text = listG[2].l.ToString();
                G3_d.Text = listG[2].d.ToString();
                G3_gF.Text = listG[2].gF.ToString();
                G3_gA.Text = listG[2].gA.ToString();
                G3_gD.Text = listG[2].gD.ToString();
                G3_pts.Text = listG[2].pts.ToString();



                G4.Image = (Bitmap)rm.GetObject(listG[3].flag);
                G4_w.Text = listG[3].w.ToString();
                G4_l.Text = listG[3].l.ToString();
                G4_d.Text = listG[3].d.ToString();
                G4_gF.Text = listG[3].gF.ToString();
                G4_gA.Text = listG[3].gA.ToString();
                G4_gD.Text = listG[3].gD.ToString();
                G4_pts.Text = listG[3].pts.ToString();

                label25.Text = listG[0].nom;
                label26.Text = listG[1].nom;
                label27.Text = listG[2].nom;
                label28.Text = listG[3].nom;




            }

            if (listH.Count() > 0)
            {
                listH = listH.OrderByDescending(o => o.pts).ToList();

                H1.Image = (Bitmap)rm.GetObject(listH[0].flag);
                H1_w.Text = listH[0].w.ToString();
                H1_l.Text = listH[0].l.ToString();
                H1_d.Text = listH[0].d.ToString();
                H1_gF.Text = listH[0].gF.ToString();
                H1_gA.Text = listH[0].gA.ToString();
                H1_gD.Text = listH[0].gD.ToString();
                H1_pts.Text = listH[0].pts.ToString();

                H2.Image = (Bitmap)rm.GetObject(listH[1].flag);
                H2_w.Text = listH[1].w.ToString();
                H2_l.Text = listH[1].l.ToString();
                H2_d.Text = listH[1].d.ToString();
                H2_gF.Text = listH[1].gF.ToString();
                H2_gA.Text = listH[1].gA.ToString();
                H2_gD.Text = listH[1].gD.ToString();
                H2_pts.Text = listH[1].pts.ToString();


                H3.Image = (Bitmap)rm.GetObject(listH[2].flag);
                H3_w.Text = listH[2].w.ToString();
                H3_l.Text = listH[2].l.ToString();
                H3_d.Text = listH[2].d.ToString();
                H3_gF.Text = listH[2].gF.ToString();
                H3_gA.Text = listH[2].gA.ToString();
                H3_gD.Text = listH[2].gD.ToString();
                H3_pts.Text = listH[2].pts.ToString();



                H4.Image = (Bitmap)rm.GetObject(listH[3].flag);
                H4_w.Text = listH[3].w.ToString();
                H4_l.Text = listH[3].l.ToString();
                H4_d.Text = listH[3].d.ToString();
                H4_gF.Text = listH[3].gF.ToString();
                H4_gA.Text = listH[3].gA.ToString();
                H4_gD.Text = listH[3].gD.ToString();
                H4_pts.Text = listH[3].pts.ToString();


                label29.Text = listH[0].nom;
                label30.Text = listH[1].nom;
                label31.Text = listH[2].nom;
                label32.Text = listH[3].nom;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = new TreeFinal();
            t.rk = this;
            t.gA = listA;
            t.gB = listB;
            t.gC = listC;
            t.gD = listD;
            t.gE = listE;
            t.gF = listF;
            t.gG = listG;
            t.gH = listH;
            t.setData();

            button1.Enabled = false;
            button3.Enabled = true;
            this.Visible = false;

            t.Show();
        }

        private void Rankings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            sc.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            t.Visible = true;
        }
    }
}
