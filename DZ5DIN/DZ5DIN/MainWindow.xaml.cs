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

namespace DZ5DIN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class equation
    {
        public double A;
        public double B;
        public double C;
        public string exists;
        public double answer1;
        public double answer2;


        public equation()
        {
            A = 0;
            B = 0;
            C = 0;
            exists = "";
            answer1 = 0;
            answer2 = 0;

        }

        public void Addequation(double a, double b, double c, string d, double f, double g)
        {
            A = a;
            B = b;
            C = c;
            exists = d;
            answer1 = f;
            answer2 = g;
        }


    }
    public partial class MainWindow : Window
    {
        int K = 0;
        equation[] infoequation = new equation[10];
        public MainWindow()
        {
            InitializeComponent();
            infoequation[0] = new equation();
            infoequation[1] = new equation();
            infoequation[2] = new equation();
            infoequation[3] = new equation();
            infoequation[4] = new equation();
            infoequation[5] = new equation();
            infoequation[6] = new equation();
            infoequation[7] = new equation();
            infoequation[8] = new equation();
            infoequation[9] = new equation();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(tA.Text);
                double b = Convert.ToDouble(tB.Text);
                double c = Convert.ToDouble(tC.Text);
                infoequation[K].A= Convert.ToDouble(tA.Text);
                infoequation[K].B = Convert.ToDouble(tB.Text);
                infoequation[K].C = Convert.ToDouble(tC.Text);
                double x1, x2;
                double D = Math.Pow(b,2)-4*a*c;
                if (D > 0)
                {
                    infoequation[K].exists = " cуществует два корня ";
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    infoequation[K].answer1 = Math.Round(x1, 3);
                    infoequation[K].answer2 = Math.Round(x2, 3);
                    tanswer.Content = infoequation[K].exists + Math.Round(x1, 3) + " и " + Math.Round(x2, 3);

                }
                if (D == 0)
                {
                    infoequation[K].exists = " cуществует один корень ";
                    x1 = -b  / (2 * a);
                    infoequation[K].answer1 = Math.Round(x1,3);
                    infoequation[K].answer2 = Math.Round(x1,3);
                    tanswer.Content = infoequation[K].exists + Math.Round(x1, 3);
                }
                if (D < 0)
                {
                    infoequation[K].exists = " корней не существует ";
                    tanswer.Content = infoequation[K].exists;
                }
                K++;
            }
            catch (Exception)
            {
                tanswer.Content = "Проверьте правильность введённых данных ";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tall.Text = "";
            for (int i = 0; i < K; i++)
            {
                tall.Text += "уравнение " + (i + 1)+" ";
                tall.Text += infoequation[i].A + "x^2*";
                tall.Text += infoequation[i].B+"x+";
                tall.Text +=  infoequation[i].C+"=0 ";
                if(infoequation[i].exists== " cуществует два корня ")
                {
                    tall.Text += infoequation[i].exists+ infoequation[i].answer1+" и "+ infoequation[i].answer2;
                }
                if(infoequation[i].exists == " cуществует один корень ")
                {
                    tall.Text += infoequation[i].exists + infoequation[i].answer1 ;
                }
                if (infoequation[i].exists == " корней не существует ")
                {
                    tall.Text += infoequation[i].exists;
                }
                tall.Text += "\n";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < K; i++)
            {
                infoequation[i].A = 0;
                infoequation[i].B = 0;
                infoequation[i].C = 0;
                infoequation[i].exists = "";
                infoequation[i].answer1 = 0;
                infoequation[i].answer2 = 0;

            }
            K = 0;
            tall.Text = "";
            }
    }
}
