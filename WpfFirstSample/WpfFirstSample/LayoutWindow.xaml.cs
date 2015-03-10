using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfFirstSample
{
    /// <summary>
    /// Логика взаимодействия для LayoutWindow.xaml
    /// </summary>
    public partial class LayoutWindow : Window
    {
        public LayoutWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox1.Text))
            {
                MessageBox.Show(textbox1.Text, "Message");
            }
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            button1.IsEnabled = !string.IsNullOrEmpty(textbox1.Text);
            button2.Content = "Text: " + textbox1.Text;
        }
    }
}
