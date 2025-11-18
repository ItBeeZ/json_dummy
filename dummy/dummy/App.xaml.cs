using dummy.MVVM.View;

namespace dummy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListPage());
        }
    }
}
