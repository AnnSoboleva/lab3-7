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

    class gen
    {

        
        public void zad1(int[] a)
        {
            Window1 win = new Window1();
            for (int i = 0; i < a.Length; i++)
            {
                Rectangle b = new Rectangle();
                b.Height = 253 / 20 * a[i];
                b.Width = 472 / a.Length;
                b.ToolTip = Convert.ToString(a[i]);
                Thickness thickness = new Thickness(0.2);
                b.Margin = thickness;
                b.Fill = Brushes.Blue;
                b.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                win.SP.Children.Add(b);
            }
            win.ShowDialog(); 
        }
        public void zad2(int[] a)
        {
            int k = 0;
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] > a[i - 1] && a[i] > a[i + 1])
                {
                    k++;
                }
            }
            MessageBox.Show(Convert.ToString(k), "Числа большие своихи соседей.");
        }
        public void zad3(int[] a)
        {
            double sum = 0, sr = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            int k = 10000;
            sr = sum / a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > sr && k > a[i]) k = a[i];
            }
            if (k == 10000) MessageBox.Show("Нет чисел больших среднегоарифметического, значение которого равно " + sr);
            else MessageBox.Show("Число " + k + " больше среднегоарифметического, значение которого равно " + sr);

        }
        public void zad4(int[] a)
        {
            int k = 0, sost1 = 0, sost2 = 0;//1-возростает 2-убывает
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1]) continue;
                if (a[i] < a[i + 1]) sost2 = 2;
                if (a[i] > a[i + 1]) sost2 = 1;
                if (sost1 != sost2) k++;
                sost1 = sost2;
            }
            if (a[a.Length - 1] < a[0] && sost1 == 1) k++;
            if (a[a.Length - 1] > a[0] && sost1 == 2) k++;
            if (k == 0) MessageBox.Show(Convert.ToString(k + 1), "Количество последовательностей");
            else MessageBox.Show(Convert.ToString(k), "Количество последовательностей");
        }
        public void zad5(int[] a)
        {
            int[] b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            if (b[0] == b[1]) b[1] += 1;
            string l = b[0] + ", " + b[1];
            if (b[0] <= b[1])
            {
                for (int i = 1; i < a.Length - 1; i++)
                {
                    if (b[i] < b[i + 1])
                    {
                        l += ", " + b[i + 1];
                    }
                    else
                    {
                        b[i + 1] += b[i] - b[i + 1] + 1;
                        l += ", " + b[i + 1];
                    }
                }
            }
            else if (b[0] > b[1])
            {
                for (int i = 1; i < a.Length - 1; i++)
                {
                    if (b[i] > b[i + 1])
                    {
                        l += ", " + b[i + 1];
                    }
                    else
                    {
                        b[i + 1] += b[i] - b[i + 1] - 1;
                        l += ", " + b[i + 1];
                    }
                }
            }
            MessageBox.Show(l, "Измененный массив");
        }
        public void zad6(int[] a)
        {
            double sum = 0, sr = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            sr = sum / a.Length;
            string k = Convert.ToString(a[0] - sr);
            for (int i = 1; i < a.Length; i++)
            {
                k += ", " + Convert.ToString(a[i] - sr);
            }
            MessageBox.Show("Среднее значение: " + sr + "\nМассив: " + k, "Массив отклонений");
        }
        public void zad7(int[] a)
        {
            double sum = 0, sr = 0, sr1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            sr = sum / a.Length;
            double[] m = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                m[i] = a[i] - sr;
                sum += m[i];
            }
            sr1 = sum / a.Length / 2;
            string k = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (m[i] > sr1) m[i] = sr;
                else m[i] = a[i];
                k += m[i] + "  ";
            }
            MessageBox.Show("Среднее значение массива: " + sr + "\nПолученный массив: " + k);
        }
        public void zad13(int n,int z)
        {
            int[] m = new int[n];
            int k=1;
            string s = "";
            Random r = new Random();
            m[0] = 0;
            s += m[0];
            for(int i = 1; i < n;)
            {
                while (k < z+1&&i<n)
                {
                    m[i] = m[i - 1] - r.Next(40);
                    k++;
                    s += ", " + m[i];
                    i++;
                }
                while(k > 1&&i<n)
                {
                    m[i] = m[i - 1] + r.Next(40);
                    k--;
                    s += ", " + m[i];
                    i++;
                }
                
                
            }
            MessageBox.Show("Полученный массив: " + s);
        }
        public void zad16(int n)
        {
            int[] m = new int[n];
            string k = "";
            m[0] = 100;
            k += m[0];
            Random r = new Random();
            for (int i = 1; i < m.Length; i++)
            {
                m[i] = m[i - 1] - r.Next(10);
                k += ", " + m[i];
            }
            MessageBox.Show("Полученный массив: " + k);
        }
    }
}
