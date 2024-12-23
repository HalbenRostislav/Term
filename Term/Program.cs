using System;
using System.Windows.Forms;
using RestaurantInterface;

namespace Term // Простір імен має бути таким самим, як у Form1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Form1 повинен бути доступний
        }
    }
}
