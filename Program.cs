using ZooShopDesktop.Forms;

namespace ZooShopDesktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AuthForm authForm = new AuthForm();

            authForm.StartPosition = FormStartPosition.CenterScreen;

            authForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            authForm.MaximizeBox = false;
            authForm.MinimizeBox = false;

            Application.Run(authForm);
        }
    }
}