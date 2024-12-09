using Proyecto1_Adrian.MVVM;

namespace Proyecto1_Adrian
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListaTareasView());
        }
    }
}
