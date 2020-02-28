using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private const int BYE = -1;
        Boolean mouseDown;
        Point mouseDownLocation;
        scheduling sc;
        List<PictureBox> pot1;
        List<PictureBox> pot2;
        List<PictureBox> pot3;
        List<PictureBox> pot4;

        List<PictureBox> all;
        List<Point> originalLocation;

        BuildConnection myCon;

        private int[] eachGroupeContinentCounter;

        public Form1()
        {
            InitializeComponent();
            myCon = new BuildConnection();
            myCon.Connect();

            if (myCon.isConnected())
            {
                this.Hide();


                p1.BackColor = Color.Transparent;
                p2.BackColor = Color.Transparent;
                p3.BackColor = Color.Transparent;
                p4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent; 

                eachGroupeContinentCounter = new int[8];



                mouseDown = false;
                pot1 = new List<PictureBox>();
                pot2 = new List<PictureBox>();
                pot3 = new List<PictureBox>();
                pot4 = new List<PictureBox>();


                originalLocation = new List<Point>();

                all = new List<PictureBox>();
                all.Add(pictureBox1);
                all.Add(pictureBox2);
                all.Add(pictureBox3);
                all.Add(pictureBox4);
                all.Add(pictureBox5);
                all.Add(pictureBox6);
                all.Add(pictureBox7);
                all.Add(pictureBox8);
                all.Add(pictureBox9);
                all.Add(pictureBox10);
                all.Add(pictureBox11);
                all.Add(pictureBox12);
                all.Add(pictureBox13);
                all.Add(pictureBox14);
                all.Add(pictureBox15);
                all.Add(pictureBox16);
                all.Add(pictureBox17);
                all.Add(pictureBox18);
                all.Add(pictureBox19);
                all.Add(pictureBox20);
                all.Add(pictureBox21);
                all.Add(pictureBox22);
                all.Add(pictureBox23);
                all.Add(pictureBox24);
                all.Add(pictureBox25);
                all.Add(pictureBox26);
                all.Add(pictureBox27);
                all.Add(pictureBox28);
                all.Add(pictureBox29);
                all.Add(pictureBox30);
                all.Add(pictureBox31);
                all.Add(pictureBox32);




                foreach (PictureBox ctrl in all)
                {
                    originalLocation.Add(ctrl.Location);
                }

                for (int i = 0; i < 8; i++)
                {
                    pot1.Add(all[i]);
                    pot2.Add(all[i + 8]);
                    pot3.Add(all[i + 16]);
                    pot4.Add(all[i + 24]);
                }

            }
        }



        public void loadFlags()
        {
            // myCon.Connect();


            //  myCon.open();
            OracleCommand command = myCon.getConnection().CreateCommand();

            String query = @"SELECT * FROM equipe Order by classement ";

            command.CommandText = query;

            OracleDataReader reader = command.ExecuteReader();




            ResourceManager rm = Resources.ResourceManager;


            foreach (PictureBox ctrl in all)
            {

                ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                if (reader.Read() == true)
                {
                    ctrl.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                    ctrl.Image.Tag = reader["FLAG"].ToString();
                }


            }

            //  myCon.Close();
            setTags();

        }


        public void hideFlags()
        {


            foreach (PictureBox ctrl in all)
            {
                if ((ctrl.Image.Tag != null) && ctrl.Image.Tag.ToString().Equals("rus"))
                    ctrl.Image = Properties.Resources.fifa1;
                else
                {
                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                    ctrl.Image = Properties.Resources.fifa;
                }


            }
        }
        public void shuffle(int p)
        {

            Random rnd = new Random();
            Point temp = new Point();


            switch (p)
            {
                case 1:

                    for (int i = 0; i <= 7; i++)
                    {
                        int a = rnd.Next(0, 7);
                        if (i != a)
                        {
                            temp = all.ElementAt(i).Location;
                            all.ElementAt(i).Location = all.ElementAt(a).Location;
                            all.ElementAt(a).Location = temp;
                        }

                    }

                    break;

                case 2:

                    for (int i = 8; i <= 15; i++)
                    {
                        int a = rnd.Next(8, 15);
                        if (i != a)
                        {
                            temp = all.ElementAt(i).Location;
                            all.ElementAt(i).Location = all.ElementAt(a).Location;
                            all.ElementAt(a).Location = temp;
                        }
                    }

                    break;
                case 3:

                    for (int i = 16; i <= 23; i++)
                    {
                        int a = rnd.Next(16, 23);
                        if (i != a)
                        {
                            temp = all.ElementAt(i).Location;
                            all.ElementAt(i).Location = all.ElementAt(a).Location;
                            all.ElementAt(a).Location = temp;
                        }


                    }

                    break;
                case 4:
                    for (int i = 24; i <= 31; i++)
                    {
                        int a = rnd.Next(24, 31);
                        if (i != a)
                        {
                            temp = all.ElementAt(i).Location;
                            all.ElementAt(i).Location = all.ElementAt(a).Location;
                            all.ElementAt(a).Location = temp;
                        }


                    }

                    break;
                case 5:
                    break;
            }

            int k = 0;

            foreach (PictureBox ctrl in all)
            {
                if (k < all.Count())
                    originalLocation[k++] = ctrl.Location;
            }



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //foreach (PictureBox ctrl in gA)
            //{
            //    ctrl.Image = Properties.Resources.brazil;
            //    groupA.Controls.Add(ctrl);
            //}


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            if (myCon.isConnected())
            {
                loadFlags();
                setTags();
                hideFlags();
                resetCategories();
                deleteRencontre();
            }


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {

        }

        private void potMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox b = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                mouseDownLocation = e.Location;
            }

            b.BringToFront();



        }

        private void potMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                PictureBox b = (PictureBox)sender;

                Point p = new Point();//in form coordinates


                p.X = e.X + b.Left;
                p.Y = e.Y + b.Top;
                b.Left = p.X - mouseDownLocation.X;
                b.Top = p.Y - mouseDownLocation.Y;



            }

        }

        private void potMouseUp(object sender, MouseEventArgs e)
        {
            //  myCon.Connect();
            // myCon.open();

            PictureBox b = ((PictureBox)sender);

            if (b.Location.X >= groupA.Left && b.Location.Y >= groupA.Top && b.Location.X <= groupA.Right && b.Location.Y <= groupA.Bottom && (groupA.Controls.Count < 4))
            {
                if (!checkPot(b, "gA"))
                {
                    if (!moreThanOneEurop(b, "gA"))
                    {
                        if (checkContinent(b, "gA") == false)
                        {

                            groupA.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[0]++;
                            }



                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {


                                    int a = all.IndexOf(ctrl);


                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'A' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();




                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + "";

                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();
                                    }


                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }
                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }


            }


            if (b.Location.X >= groupB.Left && b.Location.Y >= groupB.Top && b.Location.X <= groupB.Right && b.Location.Y <= groupB.Bottom && (groupB.Controls.Count < 4))
            {
                if (!checkPot(b, "gB"))
                {
                    if (!moreThanOneEurop(b, "gB"))
                    {
                        if (checkContinent(b, "gB") == false)
                        {
                            groupB.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[1]++;
                            }

                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {

                                    int a = all.IndexOf(ctrl);
                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'B' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();



                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + "";

                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();

                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }
                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }

            }

            if (b.Location.X >= groupC.Left && b.Location.Y >= groupC.Top && b.Location.X <= groupC.Right && b.Location.Y <= groupC.Bottom && (groupC.Controls.Count < 4))
            {
                if (!checkPot(b, "gC"))
                {
                    if (!moreThanOneEurop(b, "gC"))
                    {
                        if (checkContinent(b, "gC") == false)
                        {

                            groupC.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[2]++;
                            }

                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {

                                    int a = all.IndexOf(ctrl);
                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'C' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();




                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + " order by classement";

                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();
                                    }

                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }

                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }

            }



            if (b.Location.X >= groupD.Left && b.Location.Y >= groupC.Top && b.Location.X <= groupD.Right && b.Location.Y <= groupD.Bottom && (groupD.Controls.Count < 4))
            {
                if (!checkPot(b, "gD"))
                {
                    if (!moreThanOneEurop(b, "gD"))
                    {
                        if (checkContinent(b, "gD") == false)
                        {

                            groupD.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[3]++;
                            }


                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {

                                    int a = all.IndexOf(ctrl);
                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'D' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();




                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + "Order by classement";

                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }
                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }

            }

            if (b.Location.X >= groupE.Left && b.Location.Y >= groupE.Top && b.Location.X <= groupE.Right && b.Location.Y <= groupE.Bottom && (groupE.Controls.Count < 4))
            {
                if (!checkPot(b, "gE"))
                {
                    if (!moreThanOneEurop(b, "gE"))
                    {

                        if (checkContinent(b, "gE") == false)
                        {
                            groupE.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[4]++;
                            }

                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {

                                    int a = all.IndexOf(ctrl);
                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'E' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();




                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + "Order by classement";

                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }
                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }

            }





            if (b.Location.X >= groupF.Left && b.Location.Y >= groupF.Top && b.Location.X <= groupF.Right && b.Location.Y <= groupF.Bottom && (groupF.Controls.Count < 4))
            {
                if (!checkPot(b, "gF"))
                {
                    if (!moreThanOneEurop(b, "gF"))
                    {

                        if (checkContinent(b, "gF") == false)
                        {

                            groupF.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[5]++;
                            }

                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {

                                    int a = all.IndexOf(ctrl);
                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'F' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();



                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + "Order by classement";

                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }
                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }

            }



            if (b.Location.X >= groupG.Left && b.Location.Y >= groupG.Top && b.Location.X <= groupG.Right && b.Location.Y <= groupG.Bottom && (groupG.Controls.Count < 4))
            {
                if (!checkPot(b, "gG"))
                {
                    if (!moreThanOneEurop(b, "gG"))
                    {

                        if (checkContinent(b, "gG") == false)
                        {

                            groupG.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[6]++;
                            }

                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {

                                    int a = all.IndexOf(ctrl);
                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'G' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();



                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + "Order by classement";


                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }
                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }

            }


            if (b.Location.X >= groupH.Left && b.Location.Y >= groupH.Top && b.Location.X <= groupH.Right && b.Location.Y <= groupH.Bottom && (groupH.Controls.Count < 4))
            {
                if (!checkPot(b, "gH"))
                {
                    if (!moreThanOneEurop(b, "gH"))
                    {
                        if (checkContinent(b, "gH") == false)
                        {
                            groupH.Controls.Add(b);
                            if (getcontinent(b.Image.Tag.ToString()).Equals("euro"))
                            {
                                eachGroupeContinentCounter[7]++;
                            }

                            foreach (PictureBox ctrl in all)
                            {
                                if (ctrl.Equals(b))
                                {

                                    int a = all.IndexOf(ctrl);
                                    OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                                    updateCommend.CommandType = CommandType.Text;
                                    updateCommend.CommandText = "update equipe set TEAMCATEGORY = 'H' where classement = " + a + "";
                                    updateCommend.ExecuteNonQuery();





                                    OracleCommand command = myCon.getConnection().CreateCommand();

                                    String query = @"SELECT * FROM equipe where classement = " + a + "Order by classement";

                                    command.CommandText = query;

                                    OracleDataReader reader = command.ExecuteReader();




                                    ResourceManager rm = Resources.ResourceManager;



                                    ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

                                    if (reader.Read() == true)
                                    {
                                        b.Image = (Bitmap)rm.GetObject(reader["FLAG"].ToString() + "1");
                                        b.Image.Tag = reader["FLAG"].ToString();
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Same Continent , Move on To the Next Pot ! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Already two european teams in that Groupe ");
                    }
                }
                else
                {
                    MessageBox.Show("Put in the NEXT POT ");
                }

            }
            foreach (PictureBox ctrl in all)
            {
                if (ctrl.Equals(b))
                {
                    b.Location = originalLocation.ElementAt(all.IndexOf(ctrl));
                }
            }

            mouseDown = false;

            //  myCon.Close();

            setTags();
            // MessageBox.Show(b.Image.Tag.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideFlags();
        }

        private void p1_MouseClick(object sender, MouseEventArgs e)
        {
            shuffle(1);
        }

        private void p2_MouseClick(object sender, MouseEventArgs e)
        {
            shuffle(2);
        }

        private void p3_MouseClick(object sender, MouseEventArgs e)
        {
            shuffle(3);
        }

        private void p4_MouseClick(object sender, MouseEventArgs e)
        {
            shuffle(4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadFlags();
        }

        private void p2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((groupA.Controls.Count == 4 && (groupB.Controls.Count == 4)
                &&
                (groupC.Controls.Count == 4) && groupD.Controls.Count == 4
                &&
                (groupE.Controls.Count == 4) && groupF.Controls.Count == 4
                &&
                (groupG.Controls.Count == 4) && groupH.Controls.Count == 4))
            {

                myCon.Close();
                button1.Enabled = false;
                button2.Enabled = false;

                if (sc == null)
                {
                    sc = new scheduling();
                    sc.Visible = true;
                    sc.LoadTeams();
                    sc.buildSchedule();

                }

                button3.Enabled = false;
                button5.Enabled = true;

            }
            else
            {
                MessageBox.Show(" please Fill in all groups !");
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myCon.Close();
        }

        private bool checkPot(PictureBox pic, String gr)
        {

            if (gr.Equals("gA"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupA.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupA.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupA.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupA.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }

            if (gr.Equals("gB"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupB.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupB.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupB.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupB.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }

            if (gr.Equals("gC"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupC.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupC.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupC.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupC.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }

            if (gr.Equals("gD"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupD.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupD.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupD.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupD.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }

            if (gr.Equals("gE"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupE.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupE.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupE.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupE.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }

            if (gr.Equals("gF"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupF.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupF.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupF.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupF.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }

            if (gr.Equals("gG"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupG.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupG.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupG.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupG.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }

            if (gr.Equals("gH"))
            {
                if (pot1.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupH.Controls)
                    {
                        if (pot1.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }

                if (pot2.Contains(pic))
                {
                    foreach (PictureBox ctrl in groupH.Controls)
                    {
                        if (pot2.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot3.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupH.Controls)
                    {
                        if (pot3.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


                if (pot4.Contains(pic) == true)
                {
                    foreach (PictureBox ctrl in groupH.Controls)
                    {
                        if (pot4.Contains(ctrl))
                        {
                            return true;
                        }
                    }
                }


            }



            return false;
        }

        private bool checkContinent(PictureBox p, String gp)
        {
            setTags();
            // myCon.Connect();
            //  myCon.open();

            OracleCommand command = myCon.getConnection().CreateCommand();

            String query = @"SELECT * FROM equipe where CONTINENT = 'euro'";

            command.CommandText = query;
            OracleDataReader reader;


            String conti = getcontinent(p.Image.Tag.ToString());

            if (conti.Equals("euro"))
            {
                return false;
            }
            else
            {
                switch (gp)
                {
                    case "gA":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupA.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;

                    case "gB":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupB.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;

                    case "gC":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupC.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;

                    case "gD":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupD.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;


                    case "gE":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupE.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;


                    case "gF":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupF.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;

                    case "gG":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupG.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;

                    case "gH":

                        if (checkMovedContinent(p, conti))
                        {

                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                foreach (PictureBox ctrl in groupH.Controls)
                                {
                                    if (checkMovedContinent(ctrl, conti))
                                    {
                                        return true;
                                    }
                                }
                            }

                        }

                        break;

                }
            }




            return false;
        }


        public bool moreThanOneEurop(PictureBox p, String gp)
        {
            setTags();
            String conti = getcontinent(p.Image.Tag.ToString());

            if (conti.Equals("euro"))
            {
                switch (gp)
                {
                    case "gA":
                        if (eachGroupeContinentCounter[0] > 1)
                            return true;
                        break;

                    case "gB":
                        if (eachGroupeContinentCounter[1] > 1)
                            return true;
                        break;

                    case "gC":
                        if (eachGroupeContinentCounter[2] > 1)
                            return true;
                        break;
                    case "gD":
                        if (eachGroupeContinentCounter[3] > 1)
                            return true;
                        break;

                    case "gE":
                        if (eachGroupeContinentCounter[4] > 1)
                            return true;
                        break;

                    case "gF":
                        if (eachGroupeContinentCounter[5] > 1)
                            return true;
                        break;
                    case "gG":
                        if (eachGroupeContinentCounter[6] > 1)
                            return true;
                        break;
                    case "gH":
                        if (eachGroupeContinentCounter[7] > 1)
                            return true;
                        break;


                }
            }

            return false;
        }
        public bool checkMovedContinent(PictureBox p, String conti)
        {
            OracleCommand command = myCon.getConnection().CreateCommand();

            String query = @"SELECT * FROM equipe where CONTINENT = '" + conti + "' and FLAG = '" + p.Image.Tag.ToString() + "'";

            command.CommandText = query;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                    return true;
            }

            return false;
        }


        private String getcontinent(String equi)
        {
            //  myCon.Connect();
            //  myCon.open();
            OracleCommand command = myCon.getConnection().CreateCommand();

            String query = @"SELECT * FROM equipe where FLAG = '" + equi + "'";

            command.CommandText = query;

            OracleDataReader reader = command.ExecuteReader();


            reader.Read();
            String rs = reader["CONTINENT"].ToString();
            return rs;
        }

        private void resetCategories()
        {
            //  myCon.Connect();
            //  myCon.open();
            OracleCommand updateCommend = myCon.getConnection().CreateCommand();
            updateCommend.CommandType = CommandType.Text;
            updateCommend.CommandText = "update EQUIPE set TEAMCATEGORY = ' '";
            updateCommend.ExecuteNonQuery();
            // myCon.Close();
        }

        public void setTags()
        {
            //  myCon.Connect();


            //  myCon.open();
            OracleCommand command = myCon.getConnection().CreateCommand();

            String query = @"SELECT * FROM equipe Order by classement ";

            command.CommandText = query;

            OracleDataReader reader = command.ExecuteReader();


            foreach (PictureBox ctrl in all)
            {

                if (reader.Read() == true)
                {
                    ctrl.Image.Tag = reader["FLAG"].ToString();
                }


            }

            //myCon.Close();

        }

        public void deleteRencontre()
        {
            // myCon.Connect();
            // myCon.open();
            OracleCommand updateCommend = myCon.getConnection().CreateCommand();
            updateCommend.CommandType = CommandType.Text;
            updateCommend.CommandText = "DELETE FROM RENCONTRE";
            updateCommend.ExecuteNonQuery();
            // myCon.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(sc != null)
            sc.Visible = true;
        }
    }

}
