using System.Windows.Forms;

namespace SCREEN
{
    public static class screen
    {
        public static int screenX()
        {
            Screen primaryScreen = Screen.PrimaryScreen;
            int screenWidth = primaryScreen.Bounds.Width;
            return screenWidth;
        }
        public static int screenY()
        {
            Screen primaryScreen = Screen.PrimaryScreen;
            int screenHeight = primaryScreen.Bounds.Height;
            return screenHeight;
        }
        public static int screenCenterX()
        {
            int consoleX = vars.consoleW;
            int con = ((screenX()) - consoleX) / 2;
            return con;
        }
        public static int screenCenterY()
        {
            int consoleY = vars.consoleH;
            int con = ((screenY()) - consoleY) / 2;
            return con;
        }
    }
}
