using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
using ClassLibrary;

namespace Lab1_UI_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        V2MainCollection mainCollection = new V2MainCollection();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddDef_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection.AddDefaults();
        }

        private void AddDefDC_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection.AddDefaultDataCollection();
        }

        private void AddDefDOG_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection.AddDefaultDataOnGrid();
        }

        private void AddElemFile_btn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            if ((bool)dialog.ShowDialog())
                mainCollection.AddElementFromFile(dialog.FileName);
        }

        private void Remove_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
