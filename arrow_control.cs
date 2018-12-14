using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryTycoon
{
    class arrow_control
    {
        private static System.Windows.Forms.PictureBox left = Form1.moveLeftImg;
        private static System.Windows.Forms.PictureBox right = Form1.moveRightImg;
        private static System.Windows.Forms.PictureBox top = Form1.moveTopImg;
        private static System.Windows.Forms.PictureBox bot = Form1.moveDownImg;

        public static void show(int pos) 
        {
            if (pos == (int)EPosition.POSITION_LEFT)
                left.Visible = true;
            if (pos == (int)EPosition.POSITION_RIGHT)
                right.Visible = true;
            if (pos == (int)EPosition.POSITION_TOP)
                top.Visible = true;
            if (pos == (int)EPosition.POSITION_DOWN)
                bot.Visible = true;
        }
        public static void hide(int pos)
        { 
            if(pos == (int)EPosition.POSITION_LEFT)
                left.Visible = false;
            if (pos == (int)EPosition.POSITION_RIGHT)
                right.Visible = false;
            if (pos == (int)EPosition.POSITION_TOP)
                top.Visible = false;
            if (pos == (int)EPosition.POSITION_DOWN)
                bot.Visible = false;
        }
        public static void show_all()
        {
            left.Visible = true;
            right.Visible = true;
            top.Visible = true;
            bot.Visible = true;
        }
        public static void hide_all() {
            left.Visible = false;
            right.Visible = false;
            top.Visible = false;
            bot.Visible = false;
        }
        public static void show_horizontal()
        {
            left.Visible = true;
            right.Visible = true;
        }
        public static void hide_horizontal()
        {
            left.Visible = false;
            right.Visible = false;
        }
        public static void show_vertical()
        {
            top.Visible = true;
            bot.Visible = true;
        }
        public static void hide_vertical()
        {
            top.Visible = false;
            bot.Visible = false;
        }
        //PRESET
        public static void preset_default()
        {
            show_horizontal();
            hide_vertical();
        }
        public static void preset_mining()
        {
            show_all();
            hide((int)EPosition.POSITION_TOP);
        }
    }
}
