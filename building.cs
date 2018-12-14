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
    public partial class new_buildingWnd : Form
    {
        public new_buildingWnd()
        {
            InitializeComponent();
            init();
        }

        private void buildingWnd_Load(object sender, EventArgs e)
        {

        }
        public static void init()
        {
            //enabled
            int i_Smelting_station_cost = 322;
            int i_Crafting_station_cost = 2137;
            string s_Smelting_station_cost = " ("+i_Smelting_station_cost.ToString()+")";
            string s_Crafting_station_cost = " (" + i_Crafting_station_cost.ToString() + ")";
            building_1_label.Text = locale.building_smelting_station+s_Smelting_station_cost;
            building_2_label.Text = locale.building_crafting_station + s_Crafting_station_cost;
            building_3_label.Text = locale.building_locked;
            building_4_label.Text = locale.building_locked;
            building_5_label.Text = locale.building_locked;
            building_6_label.Text = locale.building_locked;
            building_7_label.Text = locale.building_locked;
            building_8_label.Text = locale.building_locked;


            building_1_buy_logo.Image = global::IndustryTycoon.Properties.Resources.buy_logo;
            building_2_buy_logo.Image = global::IndustryTycoon.Properties.Resources.buy_logo;
            building_3_buy_logo.Image = global::IndustryTycoon.Properties.Resources.locked_logo;
            building_4_buy_logo.Image = global::IndustryTycoon.Properties.Resources.locked_logo;
            building_5_buy_logo.Image = global::IndustryTycoon.Properties.Resources.locked_logo;
            building_6_buy_logo.Image = global::IndustryTycoon.Properties.Resources.locked_logo;
            building_7_buy_logo.Image = global::IndustryTycoon.Properties.Resources.locked_logo;
            building_8_buy_logo.Image = global::IndustryTycoon.Properties.Resources.locked_logo;



            building_1_logo.Image = global::IndustryTycoon.Properties.Resources.smelting_logo;
            building_2_logo.Image = global::IndustryTycoon.Properties.Resources.crafting_logo;
            building_3_logo.Image = global::IndustryTycoon.Properties.Resources.question_mark;
            building_4_logo.Image = global::IndustryTycoon.Properties.Resources.question_mark;
            building_5_logo.Image = global::IndustryTycoon.Properties.Resources.question_mark;
            building_6_logo.Image = global::IndustryTycoon.Properties.Resources.question_mark;
            building_7_logo.Image = global::IndustryTycoon.Properties.Resources.question_mark;
            building_8_logo.Image = global::IndustryTycoon.Properties.Resources.question_mark;


        }
        private static void buy(int id)
        {

        }




        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.SetState((int)EState.STATE_RUN);
        }
        private void building_1_buy(object sender, EventArgs e)
        {
            buy(1);
        }
        private void building_2_buy(object sender, EventArgs e)
        {
            buy(2);
        }
        private void building_3_buy(object sender, EventArgs e)
        {
            buy(3);
        }
        private void building_4_buy(object sender, EventArgs e)
        {
            buy(4);
        }
        private void building_5_buy(object sender, EventArgs e)
        {
            buy(5);
        }
        private void building_6_buy(object sender, EventArgs e)
        {
            buy(6);
        }
        private void building_7_buy(object sender, EventArgs e)
        {
            buy(7);
        }
        private void building_8_buy(object sender, EventArgs e)
        {
            buy(8);
        }
    }
}
