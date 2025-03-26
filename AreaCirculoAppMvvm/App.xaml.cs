using AreaCirculoAppMvvm.View;

namespace AreaCirculoAppMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AreaCirculoView();
        }
    }
}
