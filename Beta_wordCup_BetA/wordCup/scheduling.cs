using Oracle.ManagedDataAccess.Client;
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
    internal partial class scheduling : Form
    {
        BuildConnection myCon;

        private int index;
        private const int BYE = -1;
        Label focus;
        List<PictureBox> flags;
        List<Label> labels;
        List<Label> xs;
        Rankings rankTable;
        List<Equipe> listEcatA;
        List<Equipe> listEcatB;
        List<Equipe> listEcatC;
        List<Equipe> listEcatD;
        List<Equipe> listEcatE;
        List<Equipe> listEcatF;
        List<Equipe> listEcatG;
        List<Equipe> listEcatH;

        List<Equipe> temp;

        public scheduling()
        {
            
            InitializeComponent();
            myCon = new BuildConnection();
            myCon.Connect();
            flags = new List<PictureBox>();
            labels = new List<Label>();
            xs = new List<Label>();
            focus = new Label();

            listEcatA = new List<Equipe>();
            listEcatA = new List<Equipe>();
            listEcatB = new List<Equipe>();
            listEcatC = new List<Equipe>();
            listEcatD = new List<Equipe>();
            listEcatE = new List<Equipe>();
            listEcatF = new List<Equipe>();
            listEcatG = new List<Equipe>();
            listEcatH = new List<Equipe>();
            temp = new List<Equipe>();



            index = 0;

            flags.Add(p1);
            flags.Add(p2);
            flags.Add(p3);
            flags.Add(p4);
            flags.Add(p5);
            flags.Add(p6);
            flags.Add(p7);
            flags.Add(p8);
            flags.Add(p9);
            flags.Add(p10);
            flags.Add(p11);
            flags.Add(p12);
            flags.Add(p13);
            flags.Add(p14);
            flags.Add(p15);
            flags.Add(p16);
            flags.Add(p17);
            flags.Add(p18);
            flags.Add(p19);
            flags.Add(p20);
            flags.Add(p21);
            flags.Add(p22);
            flags.Add(p23);
            flags.Add(p24);
            flags.Add(p25);
            flags.Add(p26);
            flags.Add(p27);
            flags.Add(p28);
            flags.Add(p29);
            flags.Add(p30);
            flags.Add(p31);
            flags.Add(p32);
            flags.Add(p33);
            flags.Add(p34);
            flags.Add(p35);
            flags.Add(p36);
            flags.Add(p37);
            flags.Add(p38);
            flags.Add(p39);
            flags.Add(p40);
            flags.Add(p41);
            flags.Add(p42);
            flags.Add(p43);
            flags.Add(p44);
            flags.Add(p45);
            flags.Add(p46);
            flags.Add(p47);
            flags.Add(p48);
            flags.Add(p49);
            flags.Add(p50);
            flags.Add(p51);
            flags.Add(p52);
            flags.Add(p53);
            flags.Add(p54);
            flags.Add(p55);
            flags.Add(p56);
            flags.Add(p57);
            flags.Add(p58);
            flags.Add(p59);
            flags.Add(p60);
            flags.Add(p61);
            flags.Add(p62);
            flags.Add(p63);
            flags.Add(p64);
            flags.Add(p65);
            flags.Add(p66);
            flags.Add(p67);
            flags.Add(p68);
            flags.Add(p69);
            flags.Add(p70);
            flags.Add(p71);
            flags.Add(p72);
            flags.Add(p73);
            flags.Add(p74);
            flags.Add(p75);
            flags.Add(p76);
            flags.Add(p77);
            flags.Add(p78);
            flags.Add(p79);
            flags.Add(p80);
            flags.Add(p81);
            flags.Add(p82);
            flags.Add(p83);
            flags.Add(p84);
            flags.Add(p85);
            flags.Add(p86);
            flags.Add(p87);
            flags.Add(p88);
            flags.Add(p89);
            flags.Add(p90);
            flags.Add(p91);
            flags.Add(p92);
            flags.Add(p93);
            flags.Add(p94);
            flags.Add(p95);
            flags.Add(p96);


            xs.Add(x1);
            xs.Add(x2);
            xs.Add(x3);
            xs.Add(x4);
            xs.Add(x5);
            xs.Add(x6);
            xs.Add(x7);
            xs.Add(x8);
            xs.Add(x9);
            xs.Add(x10);
            xs.Add(x11);
            xs.Add(x12);
            xs.Add(x13);
            xs.Add(x14);
            xs.Add(x15);
            xs.Add(x16);
            xs.Add(x17);
            xs.Add(x18);
            xs.Add(x19);
            xs.Add(x20);
            xs.Add(x21);
            xs.Add(x22);
            xs.Add(x23);
            xs.Add(x24);
            xs.Add(x25);
            xs.Add(x26);
            xs.Add(x27);
            xs.Add(x28);
            xs.Add(x29);
            xs.Add(x30);
            xs.Add(x31);
            xs.Add(x32);
            xs.Add(x33);
            xs.Add(x34);
            xs.Add(x35);
            xs.Add(x36);
            xs.Add(x37);
            xs.Add(x38);
            xs.Add(x39);
            xs.Add(x40);
            xs.Add(x41);
            xs.Add(x42);
            xs.Add(x43);
            xs.Add(x44);
            xs.Add(x45);
            xs.Add(x46);
            xs.Add(x47);
            xs.Add(x48);
            xs.Add(x49);
            xs.Add(x50);
            xs.Add(x51);
            xs.Add(x52);
            xs.Add(x53);
            xs.Add(x54);
            xs.Add(x55);
            xs.Add(x56);
            xs.Add(x57);
            xs.Add(x58);
            xs.Add(x59);
            xs.Add(x60);
            xs.Add(x61);
            xs.Add(x62);
            xs.Add(x63);
            xs.Add(x64);
            xs.Add(x65);
            xs.Add(x66);
            xs.Add(x67);
            xs.Add(x68);
            xs.Add(x69);
            xs.Add(x70);
            xs.Add(x71);
            xs.Add(x72);
            xs.Add(x73);
            xs.Add(x74);
            xs.Add(x75);
            xs.Add(x76);
            xs.Add(x77);
            xs.Add(x78);
            xs.Add(x79);
            xs.Add(x80);
            xs.Add(x81);
            xs.Add(x82);
            xs.Add(x83);
            xs.Add(x84);
            xs.Add(x85);
            xs.Add(x86);
            xs.Add(x87);
            xs.Add(x88);
            xs.Add(x89);
            xs.Add(x90);
            xs.Add(x91);
            xs.Add(x92);
            xs.Add(x93);
            xs.Add(x94);
            xs.Add(x95);
            xs.Add(x96);







            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);
            labels.Add(label14);
            labels.Add(label15);
            labels.Add(label16);
            labels.Add(label17);
            labels.Add(label18);
            labels.Add(label19);
            labels.Add(label20);
            labels.Add(label21);
            labels.Add(label22);
            labels.Add(label23);
            labels.Add(label24);
            labels.Add(label25);
            labels.Add(label26);
            labels.Add(label27);
            labels.Add(label28);
            labels.Add(label29);
            labels.Add(label30);
            labels.Add(label31);
            labels.Add(label32);
            labels.Add(label33);
            labels.Add(label34);
            labels.Add(label35);
            labels.Add(label36);
            labels.Add(label37);
            labels.Add(label38);
            labels.Add(label39);
            labels.Add(label40);
            labels.Add(label41);
            labels.Add(label42);
            labels.Add(label43);
            labels.Add(label44);
            labels.Add(label45);
            labels.Add(label46);
            labels.Add(label47);
            labels.Add(label48);
            labels.Add(label49);
            labels.Add(label50);
            labels.Add(label51);
            labels.Add(label52);
            labels.Add(label53);
            labels.Add(label54);
            labels.Add(label55);
            labels.Add(label56);
            labels.Add(label57);
            labels.Add(label58);
            labels.Add(label59);
            labels.Add(label60);
            labels.Add(label61);
            labels.Add(label62);
            labels.Add(label63);
            labels.Add(label64);
            labels.Add(label65);
            labels.Add(label66);
            labels.Add(label67);
            labels.Add(label68);
            labels.Add(label69);
            labels.Add(label70);
            labels.Add(label71);
            labels.Add(label72);
            labels.Add(label73);
            labels.Add(label74);
            labels.Add(label75);
            labels.Add(label76);
            labels.Add(label77);
            labels.Add(label78);
            labels.Add(label79);
            labels.Add(label80);
            labels.Add(label81);
            labels.Add(label82);
            labels.Add(label83);
            labels.Add(label84);
            labels.Add(label85);
            labels.Add(label86);
            labels.Add(label87);
            labels.Add(label88);
            labels.Add(label89);
            labels.Add(label90);
            labels.Add(label91);
            labels.Add(label92);
            labels.Add(label93);
            labels.Add(label94);
            labels.Add(label95);
            labels.Add(label96);





        }

 
        public void buildSchedule()
        {
            ResourceManager rm = Resources.ResourceManager;
            OracleCommand command = myCon.getConnection().CreateCommand();
            String query = @"SELECT * FROM RENCONTRE order by id";
            command.CommandText = query;
            OracleDataReader reader = command.ExecuteReader();



            //while (reader.Read())
            //{
            //    if (i < 12)
            //    {
            //        flags[i].Image = (Bitmap)rm.GetObject(reader["drap1"].ToString());
            //        i = i + 2;
            //    }
            //}

            //reader = command.ExecuteReader();

            //i = 1;
            //while (reader.Read())
            //{
            //    if (i < 12)
            //    {
            //        flags[i].Image = (Bitmap)rm.GetObject(reader["drap2"].ToString());
            //        i = i + 2;

            //    }
            //}


            while (reader.Read())
            {
                temp.Add(new Equipe(reader["TEAM1"].ToString(), null, reader["drap1"].ToString()));
                temp.Add(new Equipe(reader["TEAM2"].ToString(), null, reader["drap2"].ToString()));
            }

            int j = 0;

            foreach( PictureBox ctrl in flags)
            {
                if( j< temp.Count())
                ctrl.Image = (Bitmap)rm.GetObject(temp[j++].flag);
            }

             j = 0;
            foreach (Label ctrl in labels)
            {
                if (j < temp.Count())
                    ctrl.Text = temp[j++].nom;
            }



        }


        private void calculateScheduling( List<Equipe> list)
        {
            // Get the schedule.
            OracleCommand command = myCon.getConnection().CreateCommand();



            int num_teams = 4;
            int[,] results = GenerateRoundRobin(num_teams);

            // Display the result.
            for (int round = 0; round <= results.GetUpperBound(1); round++)
            {

                for (int team = 0; team < num_teams; team++)
                {
                    if (team < results[team, round])
                    {

                        String RCATEGORY = list[team].teamCategory;
                        String TEAM1 = list[results[team, round]].nom;
                        String TEAM2 = list[team].nom;
                        String SEMAINE = round.ToString();
                        String drap1  = list[results[team, round]].flag;
                        String drap2 = list[team].flag;


                        OracleCommand updateCommend = myCon.getConnection().CreateCommand();
                            updateCommend.CommandType = CommandType.Text;
                        updateCommend.CommandText = "insert into RENCONTRE(ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,drap1,drap2) " +
                            "values("+(index++) + ",'" + RCATEGORY + "','" +TEAM1+ "','" +TEAM2 + "','" +SEMAINE + "','" + drap1 + "','" + drap2 + "')";



                        updateCommend.ExecuteNonQuery();


                    }
                }

            }

        }


        // Return an array where results(i, j) gives
        // the opponent of team i in round j.
        private int[,] GenerateRoundRobin(int num_teams)
        {
            if (num_teams % 2 == 0)
                return GenerateRoundRobinEven(num_teams);
            else
                return GenerateRoundRobinOdd(num_teams);
        }

        // Return an array where results(i, j) gives
        // the opponent of team i in round j.
        // Note: num_teams must be odd.
        private int[,] GenerateRoundRobinOdd(int num_teams)
        {
            int n2 = (int)((num_teams - 1) / 2);
            int[,] results = new int[num_teams, num_teams];

            // Initialize the list of teams.
            int[] teams = new int[num_teams];
            for (int i = 0; i < num_teams; i++) teams[i] = i;

            // Start the rounds.
            for (int round = 0; round < num_teams; round++)
            {
                for (int i = 0; i < n2; i++)
                {
                    int team1 = teams[n2 - i];
                    int team2 = teams[n2 + i + 1];
                    results[team1, round] = team2;
                    results[team2, round] = team1;
                }

                // Set the team with the bye.
                results[teams[0], round] = BYE;

                // Rotate the array.
                RotateArray(teams);
            }

            return results;
        }

        // Return an array where results(i, j) gives
        // the opponent of team i in round j.
        // Note: num_teams must be even.
        private int[,] GenerateRoundRobinEven(int num_teams)
        {
            // Generate the result for one fewer teams.
            int[,] results = GenerateRoundRobinOdd(num_teams - 1);

            // Copy the results into a bigger array,
            // replacing the byes with the extra team.
            int[,] results2 = new int[num_teams, num_teams - 1];
            for (int team = 0; team < num_teams - 1; team++)
            {
                for (int round = 0; round < num_teams - 1; round++)
                {
                    if (results[team, round] == BYE)
                    {
                        // Change the bye to the new team.
                        results2[team, round] = num_teams - 1;
                        results2[num_teams - 1, round] = team;
                    }
                    else
                    {
                        results2[team, round] = results[team, round];
                    }
                }
            }

            return results2;
        }

        // Rotate the entries one position.
        private void RotateArray(int[] teams)
        {
            int tmp = teams[teams.Length - 1];
            Array.Copy(teams, 0, teams, 1, teams.Length - 1);
            teams[0] = tmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoadTeams();
            // buildSchedule();
            setTables();
            calculateTableData();

            rankTable = new Rankings();
            rankTable.listA = this.listEcatA;
            rankTable.listB = this.listEcatB;
            rankTable.listC = this.listEcatC;
            rankTable.listD = this.listEcatD;
            rankTable.listE = this.listEcatE;
            rankTable.listF = this.listEcatF;
            rankTable.listG = this.listEcatG;
            rankTable.listH = this.listEcatH;
            rankTable.setTeamsInGraphicalTables();
            rankTable.sc = this;
            rankTable.Show();
            this.Visible = false;
            button3.Enabled = true;

            button1.Enabled = false;
            numericUpDown1.Enabled = false;



        }


        public void LoadTeams()
        {

            OracleCommand command = myCon.getConnection().CreateCommand();






            // Category A


            String query = @"SELECT * FROM equipe where TEAMCATEGORY = 'A' Order by classement ";
            command.CommandText = query;
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatA.Add(new Equipe(reader["NOM"].ToString(), "A", reader["FLAG"].ToString())) ;

            }

            if(listEcatA.Count().Equals(4))
            {
                calculateScheduling(listEcatA);
                setRanking("gA");
            }



           // Category B

            query = @"SELECT * FROM equipe where TEAMCATEGORY ='B' Order by classement ";
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatB.Add(new Equipe(reader["NOM"].ToString(), "A", reader["FLAG"].ToString()));

            }

            if (listEcatB.Count().Equals(4))
            {
                calculateScheduling(listEcatB);
                setRanking("gB");
            }


            // Category C

            query = @"SELECT * FROM equipe where TEAMCATEGORY ='C' Order by classement ";
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatC.Add(new Equipe(reader["NOM"].ToString(), "C", reader["FLAG"].ToString()));

            }

            if (listEcatC.Count().Equals(4))
            {
                calculateScheduling(listEcatC);
                setRanking("gC");
            }


            // Category D

            query = @"SELECT * FROM equipe where TEAMCATEGORY ='D' Order by classement ";
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatD.Add(new Equipe(reader["NOM"].ToString(), "D", reader["FLAG"].ToString()));

            }

            if (listEcatD.Count().Equals(4))
            {
                calculateScheduling(listEcatD);
                setRanking("gD");
            }



            // Category E

            query = @"SELECT * FROM equipe where TEAMCATEGORY ='E' Order by classement ";
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatE.Add(new Equipe(reader["NOM"].ToString(), "E", reader["FLAG"].ToString()));

            }

            if (listEcatE.Count().Equals(4))
            {
                calculateScheduling(listEcatE);
                setRanking("gE");
            }



            // Category F

            query = @"SELECT * FROM equipe where TEAMCATEGORY ='F' Order by classement ";
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatF.Add(new Equipe(reader["NOM"].ToString(), "F", reader["FLAG"].ToString()));

            }

            if (listEcatF.Count().Equals(4))
            {
                calculateScheduling(listEcatF);
                setRanking("gF");
            }


            // Category G

            query = @"SELECT * FROM equipe where TEAMCATEGORY ='G' Order by classement ";
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatG.Add(new Equipe(reader["NOM"].ToString(), "G", reader["FLAG"].ToString()));

            }

            if (listEcatG.Count().Equals(4))
            {
                calculateScheduling(listEcatG);
                setRanking("gG");
            }


            // Category G

            query = @"SELECT * FROM equipe where TEAMCATEGORY ='H' Order by classement ";
            command.CommandText = query;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                listEcatH.Add(new Equipe(reader["NOM"].ToString(), "H", reader["FLAG"].ToString()));

            }

            if (listEcatH.Count().Equals(4))
            {
                calculateScheduling(listEcatH);
                setRanking("gH");
            }





            //String[,] fer9a = new String[4,2];
            //String cat;                            
            //int i = 0;                               
            //while (reader.Read())                   
            //{                                       
            //    if( i < 4)
            //    {
            //        fer9a[i, 0] = reader["NOM"].ToString();
            //        fer9a[i++, 1] = reader["FLAG"].ToString();

            //    }


            //}


            //cat= "A";




            //// Category B


            //query = @"SELECT * FROM equipe where TEAMCATEGORY = 'B' Order by classement ";
            //command.CommandText = query;
            //reader = command.ExecuteReader();


            //fer9a = new String[5];
            //int i = 0;
            //int j = 0;
            //while (reader.Read())
            //{
            //    fer9a[i++] = reader["NOM"].ToString();
            //    if (j <= 2)
            //    {
            //        drapeaux[j++] = reader["FLAG"].ToString();
            //    }

            //}


            //fer9a[4] = "B";


            //calculateScheduling(fer9a, drapeaux);







            //// Category C

            //query = @"SELECT * FROM equipe where TEAMCATEGORY = 'C' Order by classement ";
            //command.CommandText = query;
            //reader = command.ExecuteReader();


            //fer9a = new String[5];
            //i = 0;
            //j = 0;
            //while (reader.Read())
            //{
            //    fer9a[i++] = reader["NOM"].ToString();
            //    if (j <= 2)
            //    {
            //        drapeaux[j++] = reader["FLAG"].ToString();
            //    }

            //}


            //fer9a[4] = "C";


            //calculateScheduling(fer9a, drapeaux);




            //// Category D


            //query = @"SELECT * FROM equipe where TEAMCATEGORY = 'D' Order by classement ";
            //command.CommandText = query;
            //reader = command.ExecuteReader();


            //fer9a = new String[5];
            // i = 0;
            //j = 0;
            //while (reader.Read())
            //{
            //    fer9a[i++] = reader["NOM"].ToString();
            //    if (j <= 2)
            //    {
            //        drapeaux[j++] = reader["FLAG"].ToString();
            //    }
            //}


            //fer9a[4] = "D";


            //calculateScheduling(fer9a, drapeaux);





            ////Category E

            //query = @"SELECT * FROM equipe where TEAMCATEGORY = 'E' Order by classement ";
            //command.CommandText = query;
            //reader = command.ExecuteReader();


            //fer9a = new String[5];
            // i = 0;
            // j = 0;
            //while (reader.Read())
            //{
            //    fer9a[i++] = reader["NOM"].ToString();
            //    if (j <= 2)
            //    {
            //        drapeaux[j++] = reader["FLAG"].ToString();
            //    }

            //}


            //fer9a[4] = "E";


            //calculateScheduling(fer9a, drapeaux);






            ////Category F

            //query = @"SELECT * FROM equipe where TEAMCATEGORY = 'F' Order by classement ";
            //command.CommandText = query;
            //reader = command.ExecuteReader();


            //fer9a = new String[5];
            // i = 0;
            // j = 0;
            //while (reader.Read())
            //{
            //    fer9a[i++] = reader["NOM"].ToString();
            //    if (j <= 2)
            //    {
            //        drapeaux[j++] = reader["FLAG"].ToString();
            //    }
            //}


            //fer9a[4] = "F";


            //calculateScheduling(fer9a, drapeaux);






            ////Category G


            //query = @"SELECT * FROM equipe where TEAMCATEGORY = 'G' Order by classement ";
            //command.CommandText = query;
            //reader = command.ExecuteReader();


            //fer9a = new String[5];
            // i = 0;
            // j = 0;
            //while (reader.Read())
            //{
            //    fer9a[i++] = reader["NOM"].ToString();
            //    if (j <= 2)
            //    {
            //        drapeaux[j++] = reader["FLAG"].ToString();
            //    }

            //}


            //fer9a[4] = "G";


            //calculateScheduling(fer9a, drapeaux);






            //// Category H

            //query = @"SELECT * FROM equipe where TEAMCATEGORY = 'H' Order by classement ";
            //command.CommandText = query;
            //reader = command.ExecuteReader();


            //fer9a = new String[5];
            // i = 0;
            // j = 0;
            //while (reader.Read())
            //{
            //    fer9a[i++] = reader["NOM"].ToString();
            //    if (j <= 2)
            //    {
            //        drapeaux[j++] = reader["FLAG"].ToString();
            //    }

            //}


            //fer9a[4] = "H";


            //calculateScheduling(fer9a, drapeaux);






        }


        private void scheduling_FormClosed(object sender, FormClosedEventArgs e)
        {
            myCon.Close();
        }

        private void x1_Click(object sender, EventArgs e)
        {
            focus = (Label)sender;
            foreach (Label l in xs)
            {
                l.BackColor = Color.White;
            }

            focus.BackColor = Color.Yellow;

            if ( (focus.Text.ToString().Equals("x")) == false)
            {
                numericUpDown1.Value = Int32.Parse(focus.Text.ToString());

            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           if(focus != null)
            {
                focus.Text = numericUpDown1.Value.ToString();
            }

        }

        public void setRanking(string gp)
        {
            Random r = new Random();

            switch(gp)
            {
                case "gA":
                    for (int i = 0; i < 12; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }

                    break;
                case "gB":
                    for (int i = 12; i < 24; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }

                    break;

                case "gC":
                    for (int i = 24; i < 36; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }
                    break;

                case "gD":
                    for (int i = 36; i < 48; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }
                    break;

                case "gE":
                    for (int i = 48; i < 60; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }
                    break;

                case "gF":
                    for (int i = 60; i < 72; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }
                    break;

                case "gG":
                    for (int i = 72; i < 84; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }
                    break;

                case "gH":
                    for (int i = 84; i < 96; i++)
                    {
                        xs[i].Text = r.Next(0, 7).ToString();
                    }
                    break;


            }


        }

        public void setTables()
        {
            for (int i = 0 , k =0 ; i < temp.Count() && k < xs.Count(); k=k+2 , i+=2)
            {
                    if(temp[i].nom.Equals(labels[k].Text)&& temp[i+1].nom.Equals(labels[k+1].Text))
                    {
                    if (Int32.Parse(xs[k].Text).Equals(Int32.Parse(xs[k + 1].Text)))
                        {
                            temp[i + 1].d = 1;
                            temp[i].d = 1;

                            temp[i].gF = Int32.Parse(xs[k].Text);
                            temp[i].gA = Int32.Parse(xs[k + 1].Text);

                            temp[i + 1].gF = Int32.Parse(xs[k + 1].Text);
                            temp[i + 1].gA = Int32.Parse(xs[k].Text);

                            temp[i + 1].w = 0;
                            temp[i].l = 0;
                         }
                        else
                        {
                                if (Int32.Parse(xs[k].Text) > Int32.Parse(xs[k + 1].Text))
                                {
                                    temp[i].w = 1;
                                    temp[i + 1].l = 1;
                                }
                                else
                                {
                                    temp[i + 1].w = 1;
                                    temp[i].l = 1;
                                }

                            temp[i].gF = Int32.Parse(xs[k].Text);
                            temp[i].gA = Int32.Parse(xs[k + 1].Text);

                            temp[i + 1].gF = Int32.Parse(xs[k + 1].Text);
                            temp[i + 1].gA = Int32.Parse(xs[k].Text);

                        }
                    }   
                    
            }
        }

        public void calculateTableData()
        {
           
            foreach( Equipe equiA in listEcatA)
            {
                if(!equiA.Equals(null))
                {
                    equiA.w = 0;
                    equiA.l = 0;
                    equiA.gF = 0;
                    equiA.gA = 0;
                    equiA.d = 0;
                    equiA.pts = 0;
                    equiA.gD = 0;


                    for (int i = 0; i < 12; i++)
                    {
                        if (equiA.nom.Equals(temp[i].nom))
                        {
                            equiA.w += temp[i].w;
                            equiA.l += temp[i].l;
                            equiA.gF += temp[i].gF;
                            equiA.gA += temp[i].gA;
                            equiA.d += temp[i].d;
                        }

                        equiA.pts = (equiA.w * 3) + equiA.d;
                        equiA.gD = equiA.gF - equiA.gA;

                    }
                }
            }

            foreach (Equipe equiB in listEcatB)
            {
                if (!equiB.Equals(null))
                {
                    equiB.w = 0;
                    equiB.l = 0;
                    equiB.gF = 0;
                    equiB.gA = 0;
                    equiB.d = 0;
                    equiB.pts = 0;
                    equiB.gD = 0;


                    for (int i = 12; i < 24; i++)
                    {
                        if (equiB.nom.Equals(temp[i].nom))
                        {
                            equiB.w += temp[i].w;
                            equiB.l += temp[i].l;
                            equiB.gF += temp[i].gF;
                            equiB.gA += temp[i].gA;
                            equiB.d += temp[i].d;
                        }
                    }
                    equiB.pts = (equiB.w * 3) + equiB.d;
                    equiB.gD = equiB.gF - equiB.gA;
                }
            }

            foreach (Equipe equiC in listEcatC)
            {
                if (!equiC.Equals(null))
                {

                    equiC.w = 0;
                    equiC.l = 0;
                    equiC.gF = 0;
                    equiC.gA = 0;
                    equiC.d = 0;
                    equiC.pts = 0;
                    equiC.gD = 0;



                    for (int i = 24; i < 36; i++)
                    {
                        if (equiC.nom.Equals(temp[i].nom))
                        {
                            equiC.w += temp[i].w;
                            equiC.l += temp[i].l;
                            equiC.gF += temp[i].gF;
                            equiC.gA += temp[i].gA;
                            equiC.d += temp[i].d;
                        }
                    }
                    equiC.pts = (equiC.w * 3) + equiC.d;
                    equiC.gD = equiC.gF - equiC.gA;
                }

            }

            foreach (Equipe equiD in listEcatD)
            {
                if (!equiD.Equals(null))
                {

                    equiD.w = 0;
                    equiD.l = 0;
                    equiD.gF = 0;
                    equiD.gA = 0;
                    equiD.d = 0;
                    equiD.pts = 0;
                    equiD.gD = 0;


                    for (int i = 36; i < 48; i++)
                    {
                        if (equiD.nom.Equals(temp[i].nom))
                        {
                            equiD.w += temp[i].w;
                            equiD.l += temp[i].l;
                            equiD.gF += temp[i].gF;
                            equiD.gA += temp[i].gA;
                            equiD.d += temp[i].d;
                        }
                    }
                    equiD.pts = (equiD.w * 3) + equiD.d;
                    equiD.gD = equiD.gF - equiD.gA;

                }
            }


            foreach (Equipe equiE in listEcatE)
            {
                if (!equiE.Equals(null))
                {

                    equiE.w = 0;
                    equiE.l = 0;
                    equiE.gF = 0;
                    equiE.gA = 0;
                    equiE.d = 0;
                    equiE.pts = 0;
                    equiE.gD = 0;

                    for (int i = 48; i < 60; i++)
                    {
                        if (equiE.nom.Equals(temp[i].nom))
                        {
                            equiE.w += temp[i].w;
                            equiE.l += temp[i].l;
                            equiE.gF += temp[i].gF;
                            equiE.gA += temp[i].gA;
                            equiE.d += temp[i].d;
                        }
                    }

                    equiE.pts = (equiE.w * 3) + equiE.d;
                    equiE.gD = equiE.gF - equiE.gA;

                }
            }

            foreach (Equipe equiF in listEcatF)
            {
                if (!equiF.Equals(null))
                {

                    equiF.w = 0;
                    equiF.l = 0;
                    equiF.gF = 0;
                    equiF.gA = 0;
                    equiF.d = 0;
                    equiF.pts = 0;
                    equiF.gD = 0;

                    for (int i = 60; i < 72; i++)
                    {
                        if (equiF.nom.Equals(temp[i].nom))
                        {
                            equiF.w += temp[i].w;
                            equiF.l += temp[i].l;
                            equiF.gF += temp[i].gF;
                            equiF.gA += temp[i].gA;
                            equiF.d += temp[i].d;
                        }
                    }

                    equiF.pts = (equiF.w * 3) + equiF.d;
                    equiF.gD = equiF.gF - equiF.gA;
                }
            }

            foreach (Equipe equiG in listEcatG)
            {
                if (!equiG.Equals(null))
                {

                    equiG.w = 0;
                    equiG.l = 0;
                    equiG.gF = 0;
                    equiG.gA = 0;
                    equiG.d = 0;
                    equiG.pts = 0;
                    equiG.gD = 0;

                    for (int i = 72; i < 84; i++)
                    {
                        if (equiG.nom.Equals(temp[i].nom))
                        {
                            equiG.w += temp[i].w;
                            equiG.l += temp[i].l;
                            equiG.gF += temp[i].gF;
                            equiG.gA += temp[i].gA;
                            equiG.d += temp[i].d;
                        }
                    }
                    equiG.pts = (equiG.w * 3) + equiG.d;
                    equiG.gD = equiG.gF - equiG.gA;
                }

            }

            foreach (Equipe equiH in listEcatH)
            {
                if (!equiH.Equals(null))
                {

                    equiH.w = 0;
                    equiH.l = 0;
                    equiH.gF = 0;
                    equiH.gA = 0;
                    equiH.d = 0;
                    equiH.pts = 0;
                    equiH.gD = 0;

                    for (int i = 84; i < 96; i++)
                    {
                        if (equiH.nom.Equals(temp[i].nom))
                        {
                            equiH.w += temp[i].w;
                            equiH.l += temp[i].l;
                            equiH.gF += temp[i].gF;
                            equiH.gA += temp[i].gA;
                            equiH.d += temp[i].d;
                        }
                    }

                    equiH.pts = (equiH.w * 3) + equiH.d;
                    equiH.gD = equiH.gF - equiH.gA;
                }
            }


        }

        public void saveToDBA()
        {
        }

        private void scheduling_Load(object sender, EventArgs e)
        {

        }

        private void scheduling_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
           e.Cancel = true; // this cancels the close event.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if(rankTable != null)
            {
                rankTable.Visible = true;
            }
        }
    }


}
