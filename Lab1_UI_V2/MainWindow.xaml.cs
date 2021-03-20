﻿using System;
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
        //TextBlock text = new TextBlock();
       
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainCollection;
            //text.Text = mainCollection.Average.ToString();
        }

        private void AddDef_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection.AddTest();
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
            var selectedMain = this.listBox_Main.SelectedItems;
            List<V2Data> selectedItems = new List<V2Data>();
            selectedItems.AddRange(selectedMain.Cast<V2Data>());

            foreach (V2Data item in selectedItems)
            {
                mainCollection.Remove(item.Info, item.Freq);
            }
        }

        
        private void DataCollection(object sender, FilterEventArgs args)
        {
            var item = args.Item;
            if (item != null)
            {
                if (item.GetType() == typeof(V2DataCollection)) args.Accepted = true;
                else args.Accepted = false;
            }
        }
        
        private void DataOnGrid(object sender, FilterEventArgs args)
        {
            var item = args.Item;
            if (item != null)
            {
                if (item.GetType() == typeof(V2DataOnGrid)) args.Accepted = true;
                else args.Accepted = false;
            }
        }

        private void New_btn_Click(object sender, RoutedEventArgs e)
        {
            mainCollection = new V2MainCollection();
            DataContext = mainCollection;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            if ((bool)dialog.ShowDialog())
                mainCollection.Save(dialog.FileName);
        }

        /*private void Average(object sender, FilterEventArgs args)
        {

        }
        */
    }
}
