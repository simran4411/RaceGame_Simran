using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame_Simran
{
   public abstract class Dog
    {
        //pass the Image of the picture box to main form using static class
        public static void dog1(PictureBox pb) {
            pb.Image = RaceGame_Simran.Properties.Resources.dg1;

        }
        public static void dog2(PictureBox pb)
        {
            pb.Image = RaceGame_Simran.Properties.Resources.dg2;

        }
        public static void dog3(PictureBox pb)
        {
            pb.Image = RaceGame_Simran.Properties.Resources.dg3;

        }
        public static void dog4(PictureBox pb)
        {
            pb.Image = RaceGame_Simran.Properties.Resources.dg4;

        }
    }
}
