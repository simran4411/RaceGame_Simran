using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame_Simran
{
   public class Player
    {
        //this class is used to reset the budget of the player 
        public int  player1(Label lb,int bet,int dog,int winner ) {
            if (dog == winner)
            {
                return (Convert.ToInt32(lb.Text.ToString())+bet);
            }
            else {
                return (Convert.ToInt32(lb.Text.ToString()) - bet);
            }
        }
        public int player2(Label lb, int bet, int dog, int winner)
        {
            if (dog == winner)
            {
                return (Convert.ToInt32(lb.Text.ToString()) + bet);
            }
            else
            {
                return (Convert.ToInt32(lb.Text.ToString()) - bet);
            }
        }
        public int player3(Label lb, int bet, int dog, int winner)
        {
            if (dog == winner)
            {
                return (Convert.ToInt32(lb.Text.ToString()) + bet);
            }
            else
            {
                return (Convert.ToInt32(lb.Text.ToString()) - bet);
            }
        }

    }
}
