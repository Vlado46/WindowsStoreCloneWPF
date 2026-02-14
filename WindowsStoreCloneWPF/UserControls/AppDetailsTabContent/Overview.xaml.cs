using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsStoreCloneWPF.UserControls.AppDetailsTabContent
{
    public partial class Overview : UserControl
    {
        //TODO: Step 7: Create event and delegate
        public delegate void OnAppDetailsAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppDetailsAppClicked AppClicked;
        public Overview()
        {
            InitializeComponent();
            //TODO: Step 8: Hook up the app clicked event in AppsViewer
            AppsViewerInsedeOwerviewTab.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
        }

        private void AppsViewerInsideOwerviewTab_AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            //TODO: Step 9: Hire the event
            //GOTO: AppDetails.xaml.cs
            AppClicked(sender, e);
        }
    }
}
