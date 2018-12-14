enum EBuildings
{
    BUILDING_NONE,
    BUILDING_MINING_STATION,
    BUILDING_SMELTING_STATION,
};
enum EPosition
{
    POSITION_RIGHT,
    POSITION_LEFT,
    POSITION_TOP,
    POSITION_DOWN,
};
enum EState
{
    STATE_NONE,
    STATE_LOADING,
    STATE_RUN,
    STATE_UNDERGROUND,
    STATE_FREEZE,
}
public class global
{
    public static bool isDebug = true;
    public static bool isGraphicDebug = false;
    public static int BaseIdx = 5;
    public static int BaseUnlocked = 1*2+1;
//GRAPHIC
    public static bool EnableAnimation = true;
    public static int slide_speed = 25;

}
public class v
{
    public static byte app_state = (int)EState.STATE_NONE;
    public static bool[] unlocked = new bool[11];
    public static int[] buildings = new int[11];

    public static bool isFrozen(){return app_state == (int)EState.STATE_FREEZE;}


    public static ulong money = 10000000000000000000;
}
