using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordCup.Properties;
using ImageBrush = System.Windows.Media.ImageBrush;

namespace wordCup
{
    class Equipe
    {
        public String nom;
        public string teamCategory;
        public string flag;
        public int w;
        public int l;
        public int d;
        public int gF;
        public int gA;
        public int gD;
        public int pts;

      public  Equipe(string nom , string teamCategory , string flag)
        {
            this.nom = nom;
            this.teamCategory = teamCategory;
            this.flag = flag;
            w = 0;
            l = 0;
            d = 0;
            gF = 0;
            gA = 0;
            pts = 0;
            gD = 0;
        }
    }
}
