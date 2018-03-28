using System.Windows;

namespace Inlämningsuppgiftny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CompetionViewmodel vm = new CompetionViewmodel();
        public MainWindow()
        {
            InitializeComponent();
            vm = new CompetionViewmodel();
            DataContext = vm;
        }
    }
}
