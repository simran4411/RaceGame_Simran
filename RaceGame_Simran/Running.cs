using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame_Simran
{
    public  class Running
    {
        // object of the random class that is used to generate the 
        Random instanceRandom = new Random();

        // user define method that is used to generate  the next random no 
        public int runNext() {
            return instanceRandom.Next(1,40);
        }

        public int move4th(PictureBox pb, Timer tm)
        {
            if (pb.Left < 430)
            {
                pb.Left += runNext();
                return 0;
            }
            else
            {
                tm.Stop();
                MessageBox.Show("Forth Dog is the winner ");
                return 4;
            }
        }
        public int move2nd(PictureBox pb, Timer tm)
        {
            if (pb.Left < 430)
            {
                pb.Left +=runNext();
                return 0;
            }
            else
            {
                tm.Stop();
                MessageBox.Show("Second Dog is the winner ");
                return 2;
            }
        }
        public int move3rd(PictureBox pb, Timer tm)
        {
            if (pb.Left < 430)
            {
                pb.Left +=runNext();
                return 0;
            }
            else
            {
                tm.Stop();
                MessageBox.Show("Third Dog is the winner ");
                return 3;
            }
        }


        public int moveFirst(PictureBox pb, Timer tm)
        {
            if (pb.Left < 430)
            {
                pb.Left += runNext();
                return 0;
            }
            else
            {
                tm.Stop();
                MessageBox.Show("First Dog is the winner ");
                return 1;
            }
        }



    }
}
