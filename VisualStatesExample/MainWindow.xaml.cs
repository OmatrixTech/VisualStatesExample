﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisualStatesExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void rect_MouseEvent(object sender, MouseEventArgs e)
        {
            if (rect.IsMouseOver)
            {
                VisualStateManager.GoToElementState(rect, "MouseEnter", true);
            }
            else
            {
                VisualStateManager.GoToElementState(rect, "MouseLeave", true);
            }
        }
       
    }
}