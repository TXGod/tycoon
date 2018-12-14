using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustryTycoon
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetState((byte)EState.STATE_LOADING);
            init();
        }
        static void init()
        {
            //init_settings();
            main_manager.position_idx = global.BaseIdx;

            init_unlocked();
            init_buildings();

            SetState((byte)EState.STATE_RUN);
            arrow_control.preset_default();
            Refresh();
            
        }

        private void moveRightImg_Click(object sender, EventArgs e)
        {
            ui.MoveRight();
        }

        private void moveLeftImg_Click(object sender, EventArgs e)
        {
            ui.MoveLeft();
        }

        private void moveTopImg_Click(object sender, EventArgs e)
        {
            ui.MoveUp();
        }

        private void moveDownImg_Click(object sender, EventArgs e)
        {
            ui.MoveDown();
        }

        private void buildingImg_Click(object sender, EventArgs e)
        {
            int bID = main_manager.getBuildingID(main_manager.position_idx);
            if (bID == 0)
            {
                if (!v.isFrozen()) { 
                    Form building = new new_buildingWnd();
                    building.Show();
                    SetState((int)EState.STATE_FREEZE);
                }
            }
            else
            {
                //building options
            }
        }

        
        public static void MakeUnlockButton(int position)
        {
            if (position == (int)EPosition.POSITION_RIGHT)
            {
                Form1.moveRightImg.Visible = false;
            }
            if (position == (int)EPosition.POSITION_LEFT)
            {
                Form1.moveLeftImg.Visible = false;
            }
            if (position == (int)EPosition.POSITION_TOP)
            {
                Form1.moveTopImg.Visible = false;
            }
            if (position == (int)EPosition.POSITION_DOWN)
            {
                Form1.moveDownImg.Visible = false;
            }
        }

        public static void init_unlocked()
        {
            bool idx_0 = false;
            bool idx_1 = false;
            bool idx_2 = false;
            bool idx_3 = false;
            bool idx_4 = true;
            bool idx_5 = true;
            bool idx_6 = true;
            bool idx_7 = false;
            bool idx_8 = false;
            bool idx_9 = false;
            bool idx_10 = false;

            v.unlocked[0] = idx_0;
            v.unlocked[1] = idx_1;
            v.unlocked[2] = idx_2;
            v.unlocked[3] = idx_3;
            v.unlocked[4] = idx_4;
            v.unlocked[5] = idx_5;
            v.unlocked[6] = idx_6;
            v.unlocked[7] = idx_7;
            v.unlocked[8] = idx_8;
            v.unlocked[9] = idx_9;
            v.unlocked[10] = idx_10;
        }
        public static void init_buildings()
        {
            int idx_0 = (int)EBuildings.BUILDING_NONE;
            int idx_1 = (int)EBuildings.BUILDING_NONE;
            int idx_2 = (int)EBuildings.BUILDING_NONE;
            int idx_3 = (int)EBuildings.BUILDING_NONE;
            int idx_4 = (int)EBuildings.BUILDING_NONE;
            int idx_5 = (int)EBuildings.BUILDING_MINING_STATION;
            int idx_6 = (int)EBuildings.BUILDING_NONE;
            int idx_7 = (int)EBuildings.BUILDING_NONE;
            int idx_8 = (int)EBuildings.BUILDING_NONE;
            int idx_9 = (int)EBuildings.BUILDING_NONE;
            int idx_10 = (int)EBuildings.BUILDING_NONE;

            v.buildings[0] = idx_0;
            v.buildings[1] = idx_1;
            v.buildings[2] = idx_2;
            v.buildings[3] = idx_3;
            v.buildings[4] = idx_4;
            v.buildings[5] = idx_5;
            v.buildings[6] = idx_6;
            v.buildings[7] = idx_7;
            v.buildings[8] = idx_8;
            v.buildings[9] = idx_9;
            v.buildings[10] = idx_10;
        }

        public static void SetState(byte state)
        {
            v.app_state = state;
        }
        public static Bitmap GetBuildingCodeName(int idx)
        {
            if (idx == 1)
                return global::IndustryTycoon.Properties.Resources.building_mining;
            if (idx == 2)
                return global::IndustryTycoon.Properties.Resources.building_smelting;
           
            return global::IndustryTycoon.Properties.Resources.building_none;
        }
        public static void Refresh()
        {
            //Console.WriteLine("CURRENT_POS {0}", main_manager.position_idx);
            int bID = main_manager.getBuildingID(main_manager.position_idx);
            Form1.buildingImg.Image = GetBuildingCodeName(bID);
            if (bID == (int)EBuildings.BUILDING_MINING_STATION){
                arrow_control.preset_mining();
            }
            else
            {
                if(v.app_state == (int)EState.STATE_RUN)
                    arrow_control.preset_default();
                if (v.app_state == (int)EState.STATE_UNDERGROUND)
                    arrow_control.show_all();
            }
        }

        

    }
}
