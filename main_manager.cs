using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryTycoon
{
    class main_manager
    {

        public static int position_idx;
        public static int building_owned_count;
        public static int unlocked_count;

        public static int getPositionIdx() { return position_idx; }
        public static void setPositionIdx(int idx) { position_idx = idx; }
        public static int getBuildingsOwnedCount() { return building_owned_count; }
        public static void setBuildingsOwnedCount(int count) { building_owned_count = count; }
        public static int getUnlockedCount() { return unlocked_count; }
        public static void setUnlockedCount(int count) { unlocked_count = count; }

        public static int getBuildingID(int idx) { return v.buildings[idx]; }
    }
}
