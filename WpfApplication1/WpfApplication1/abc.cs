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
    class abc
    {
        public void zad7(int[] a, int x, int y)
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

                if (i >= x && i <= y&&m[i] > sr1) m[i] = sr;      
                else m[i] = a[i];
                k += m[i] + "  ";
            }
            MessageBox.Show("Среднее значение массива: " + sr + "\nПолученный массив: " + k);
        }
        public void zad8(int[] a,double L,int x,int y)
        {
            double sum = 0, sr = 0, sr1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            sr = sum / a.Length*1.0;
            double[] m = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                m[i] = a[i] - sr;
                sum += m[i];
            }
            sr1 = sum / a.Length * L;
            string k = "";
            for (int i = 0; i < a.Length; i++)
            {
                    if (i >= x && i <= y && m[i] > sr1) m[i] = sr;
                    else m[i] = a[i];                    
                k += m[i] + "  ";
            }
            MessageBox.Show("Среднее значение массива: " + sr + "\nПолученный массив: " + k);
        }
        public void zad9(int[] a,double L,double Z, int x, int y)
        {
            double sum = 0, sr = 0;
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
            sr = sum / a.Length * L;
            string k = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i >= x && i <= y && m[i] > sr) m[i] = Z;
                else m[i] = a[i];
                k += m[i] + "  ";
            }
            MessageBox.Show("\nПолученный массив: " + k);
        }
        double sred(double[] a, double l)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum / a.Length * l;
        }
        public void zad10(int[]a,double L,double Z)
        {
            double[] m = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                m[i] = a[i] * 1.0;
            }
            double sr = sred(m, 1);
            for (int i = 0; i < a.Length; i++)
            {
                m[i] = a[i] - sr;
            }
            sr = sred(m, L);
            string k = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (m[i] > sr) m[i] = Z;
                else m[i] = a[i];
                k += m[i] + "  ";
            }
            MessageBox.Show("\nПолученный массив: " + k);
        }
    }
}
