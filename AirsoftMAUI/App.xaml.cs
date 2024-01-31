using AirsoftMAUI.MVVM.Models;

namespace AirsoftMAUI
{
    public partial class App : Application
    {
        public static Usuario AppUser;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
