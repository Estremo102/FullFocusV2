using System;
using System.IO;
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

namespace turniej_v2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //bool fullscreen = true;
        string[] category = "Gra,Przedmioty,Postacie,E-Sport,Lore,Skiny,Geografia,Umiejętności".Split(',');
        int[] rounds = new int[10];
        int round = 0;
        int seconds = 45;
        int timeLeft;
        bool timeGo = false;
        bool badAnswer = false;
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += Minutnik;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            //punktacja
            rounds[0] = 200;
            rounds[1] = 200;
            rounds[2] = 200;
            rounds[3] = 300;
            rounds[4] = 300;
            rounds[5] = 300;
            rounds[6] = 400;
            rounds[7] = 400;
            rounds[8] = 400;
            rounds[9] = 500;
        }

        private void P1r_Click(object sender, RoutedEventArgs e)
        {
            p1r.IsEnabled = false;
            DoublePoints();
        }

        private void P1g_Click(object sender, RoutedEventArgs e)
        {
            p1g.IsEnabled = false;
            whoFirst.Text = "a";
        }

        private void P1b_Click(object sender, RoutedEventArgs e)
        {
            p1b.IsEnabled = false;
        }

        private void P2r_Click(object sender, RoutedEventArgs e)
        {
            p2r.IsEnabled = false;
            DoublePoints();
        }

        private void P2g_Click(object sender, RoutedEventArgs e)
        {
            p2g.IsEnabled = false;
            whoFirst.Text = "6";
        }

        private void P2b_Click(object sender, RoutedEventArgs e)
        {
            p2b.IsEnabled = false;
        }

        private void Img1set_Click(object sender, RoutedEventArgs e)
        {
            commandGrid.Visibility = Visibility.Visible;
            commandBox.Text = "p1 ";
            commandBox.Focus();
            commandBox.CaretIndex = commandBox.Text.Length;
        }
        private void Img2set_Click(object sender, RoutedEventArgs e)
        {
            commandGrid.Visibility = Visibility.Visible;
            commandBox.Text = "p2 ";
            commandBox.Focus();
            commandBox.CaretIndex = commandBox.Text.Length;
        }
        private void Sumbit_Click(object sender, RoutedEventArgs e)
        {
            Execute_Command();
        }

        private void Execute_Command()
        {
            commandBox.Text = commandBox.Text.Replace(", ", ",");
            string[] command = commandBox.Text.Split(' ');
            try
            {
                switch (command[0])
                {
                    case "p1":
                        switch (command[1])
                        {
                            case "random":
                                img1p.Source = new BitmapImage(new Uri(@"https://thispersondoesnotexist.com/image"));
                                break;
                            case "randomcat":
                                img1p.Source = new BitmapImage(new Uri(@"https://thiscatdoesnotexist.com/"));
                                break;
                            default:
                                img1p.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\img\" + command[1]));
                                break;
                        }
                        break;
                    case "p2":
                        switch (command[1])
                        {
                            case "random":
                                img2p.Source = new BitmapImage(new Uri(@"https://thispersondoesnotexist.com/image"));
                                break;
                            case "randomcat":
                                img2p.Source = new BitmapImage(new Uri(@"https://thiscatdoesnotexist.com/"));
                                break;
                            default:
                                img2p.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\img\" + command[1]));
                                break;
                        }
                        break;
                    case "set":
                        switch (command[1])
                        {
                            case "category":
                                category = command[2].Split(',');
                                break;
                            case "points":
                                switch (command[2])
                                {
                                    case "p1":
                                        p1points.Content = command[3];
                                        break;
                                    case "p2":
                                        p2points.Content = command[3];
                                        break;
                                    case "q":
                                        questionPoints.Content = command[3];
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "background":
                                background.Source = new BitmapImage(new Uri(command[2]));
                                break;
                            case "localbackground":
                                background.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\img\" + command[2]));
                                break;
                            case "time":
                                seconds = Convert.ToInt32(command[2]);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "jordan":
                        Close();
                        break;
                    default:
                        throw new Exception();
                }
                commandGrid.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                commandBox.Text = "niepoprawna komenda";
            }
        }

        private void Losuj_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(0, category.Length);
            kategorie.Content = category[num];
        }
        private void Set_Category(object sender, RoutedEventArgs e)
        {
            commandGrid.Visibility = Visibility.Visible;
            commandBox.Text = "set category ";
            commandBox.Focus();
            commandBox.CaretIndex = commandBox.Text.Length;
        }

        private void Set_Points(object sender, RoutedEventArgs e)
        {
            commandGrid.Visibility = Visibility.Visible;
            commandBox.Text = "set points q ";
            commandBox.Focus();
            commandBox.CaretIndex = commandBox.Text.Length;
        }

        private void Submit(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                Execute_Command();
            }
        }

        private void TimeButton_Click(object sender, RoutedEventArgs e)
        {
            time.Content = Convert.ToString(seconds);
            timeLeft = seconds;
            timeGo = true;
            whoFirst.Focus();
        }
        private void TimeButton_RClick(object sender, RoutedEventArgs e)
        {
            timeGo = !timeGo;
        }

        private void Minutnik(object sender, EventArgs e)
        {
            if (timeLeft > 0 && timeGo)
            {
                time.Content = Convert.ToString(--timeLeft);
            }
            else if(timeGo)
            {
                if(!badAnswer)
                {
                    timeGo = false;
                    p1points.Content = Convert.ToString(Convert.ToInt32(p1points.Content) - Convert.ToInt32(questionPoints.Content));
                    p2points.Content = Convert.ToString(Convert.ToInt32(p2points.Content) - Convert.ToInt32(questionPoints.Content));
                    if (Convert.ToInt32(p1points.Content) < 0)
                    {
                        p1points.Content = 0;
                    }
                    if (Convert.ToInt32(p2points.Content) < 0)
                    {
                        p2points.Content = 0;
                    }
                }
                Good();
            }
        }

        private void G1btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                p1points.Content = Convert.ToString(Convert.ToInt32(p1points.Content) + Convert.ToInt32(questionPoints.Content));
            }
            catch (Exception) { }
            Good();
        }

        private void B1btn_Click(object sender, RoutedEventArgs e)
        {
            Bad();
            try
            {
                p1points.Content = Convert.ToString(Convert.ToInt32(p1points.Content) - (Convert.ToInt32(questionPoints.Content) / 2));
            }
            catch (Exception) { }
            if (Convert.ToInt32(p1points.Content) < 0)
            {
                p1points.Content = 0;
            }
        }

        private void G2btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                p2points.Content = Convert.ToString(Convert.ToInt32(p2points.Content) + Convert.ToInt32(questionPoints.Content));
            }
            catch(Exception){}
            Good();
        }

        private void B2btn_Click(object sender, RoutedEventArgs e)
        {
            Bad();
            try
            {
                p2points.Content = Convert.ToString(Convert.ToInt32(p2points.Content) - (Convert.ToInt32(questionPoints.Content) / 2));
            }
            catch (Exception) { }
            if (Convert.ToInt32(p2points.Content) < 0)
            {
                p2points.Content = 0;
            }
        }

        private void Good()
        {
            try
            {
                badAnswer = false;
                timeGo = false;
                time.Content = "time";
                whoFirst.Text = "";
                questionPoints.Content = Convert.ToString(rounds[++round]);
            }
            catch (Exception)
            {
                questionPoints.Content = "WIN";
            }
        }

        private void Bad()
        {
            badAnswer = true;
            timeGo = true;
            whoFirst.Text = "";
            whoFirst.Focus();
        }

        private void WhoFirst_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (whoFirst.Text == "a")
            {
                p1select.Visibility = Visibility.Visible;
                timeGo = false;
            }
            else if(whoFirst.Text == "6")
            {
                p2select.Visibility = Visibility.Visible;
                timeGo = false;
            }
            else if(whoFirst.Text == "")
            {
                p1select.Visibility = Visibility.Hidden;
                p2select.Visibility = Visibility.Hidden;
            }
        }

        private void DoublePoints()
        {
            questionPoints.Content = Convert.ToString(2 * Convert.ToInt32(questionPoints.Content));
        }
    }
}
