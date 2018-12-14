using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace IndustryTycoon
{
    public class ui
    {
        public static void MoveRight()
        {
            Move((int)EPosition.POSITION_RIGHT);
        }
        public static void MoveLeft()
        {
            Move((int)EPosition.POSITION_LEFT);
        }
        public static void MoveUp()
        {
            Move((int)EPosition.POSITION_TOP);
        }
        public static void MoveDown()
        {
            Move((int)EPosition.POSITION_DOWN);
        }
        public static void ClickBuilding(int idx)
        {
        }

        private static bool CanMove(int idx, int pos, bool[] unlocked)
        {
            int dif = -1;
            if (pos == (int)EPosition.POSITION_RIGHT)
                dif = 1;

            int arg = idx + dif;

            if (arg <= 0 || arg >= 11)
            {
                if (global.isDebug)
                    Console.WriteLine("ARRAY_EXCEED");
                return false;
            }

            if (global.isDebug)
                Console.WriteLine("IS_UNLOCKED {0} idx: {1} arg: {2} dif: {3} ", unlocked[arg], idx, arg, dif);

            return unlocked[arg];

        }

        private static void Move(int pos)
        {
            int idx = main_manager.getPositionIdx();
            bool [] unlocked = v.unlocked;

            if (v.isFrozen())
                return;

            if (pos == (int)EPosition.POSITION_DOWN)
            {
                if(main_manager.getBuildingID(idx) == (int)EBuildings.BUILDING_MINING_STATION){
                    //gounderground
                    return;
                }
            }
                

            if (!CanMove(idx, pos, unlocked))
                return;

            int dif = -1;

            if (pos == (int)EPosition.POSITION_RIGHT)
                dif = 1;

            if (global.EnableAnimation)
                Background.MakeSlide(pos);

            main_manager.setPositionIdx(idx + dif);
            Form1.Refresh();
        }
    }
    public class Background
    {
        public static void MakeSlide(int position)
        {
            int x = Form1.buildingImg.Location.X;
            int y = Form1.buildingImg.Location.Y;
            int width = Form1.buildingImg.Width;
            int screen_width = Form1.ActiveForm.Width;
            int dif = global.slide_speed;

            if (global.isGraphicDebug) { 
                Console.WriteLine("--------------------------------");
                Console.WriteLine(x);
                Console.WriteLine(width);
                Console.WriteLine(screen_width);
                Console.WriteLine("--------------------------------");
            }

            if (position == (int)EPosition.POSITION_RIGHT)
            {
                bool outside = false;

                while (outside == false)
                {
                    if (x >= screen_width)
                    {
                        outside = true;
                        break;
                    }
                    x += dif;
                    Form1.buildingImg.Location = new System.Drawing.Point(x, y);
                    Form1.buildingImg.Update();
                    
                }
            }
        }
    }
}
