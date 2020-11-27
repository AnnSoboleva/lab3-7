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


namespace WpfApplication1
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
        int[] a;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a = new int[Convert.ToInt32(Tb1.Text)];
            int index;
            int itemCount = Convert.ToInt32(Tb1.Text);
            Random rnd1 = new Random();
            lb1.Content = "";
            a[0] = rnd1.Next(40);
            lb1.Content += Convert.ToString(a[0]);
            for (index = 1; index < itemCount; index++)
            {
                a[index] = rnd1.Next(40);
                lb1.Content += ", " + Convert.ToString(a[index]);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//1
        {
            gen b = new gen();
            b.zad1(a);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//2
        {
            gen b = new gen();
            b.zad2(a);
        }


        private void Button_Click_4(object sender, RoutedEventArgs e) //4
        {
            gen b = new gen();
            b.zad4(a);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)//5
        {
            gen b = new gen();
            b.zad5(a);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)//3
        {
            gen b = new gen();
            b.zad3(a);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)//6
        {
            gen b = new gen();
            b.zad6(a);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)//8//16
        {
            gen b = new gen();
            b.zad16(Convert.ToInt32(textBox_Copy.Text));    
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            gen b = new gen();
            b.zad13(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            abc b = new abc();
            b.zad7(a, Convert.ToInt32(Tb7.Text), Convert.ToInt32(Tb7_1.Text));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            abc b = new abc();
            b.zad8(a, Convert.ToInt32(Tb3.Text)/100.0,Convert.ToInt32(Tb7.Text),Convert.ToInt32(Tb7_1.Text));
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            abc b = new abc();
            b.zad9(a, Convert.ToInt32(Tb3.Text) / 100.0, Convert.ToInt32(Tb4.Text), Convert.ToInt32(Tb7.Text), Convert.ToInt32(Tb7_1.Text));
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            abc b = new abc();
            b.zad10(a, Convert.ToInt32(Tb3.Text) / 100.0, Convert.ToInt32(Tb4.Text));     
        }
    }
}
