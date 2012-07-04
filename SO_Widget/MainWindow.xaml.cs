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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using StackExchange.StacMan;
using System.Windows.Media.Animation;

namespace SO_Widget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int userId;
        private string profileLink = null;
        private System.Windows.Threading.DispatcherTimer timer = null;
        private int currentRep;
        private int lastRep;

        public MainWindow()
        {
            InitializeComponent();
            Top = 5;
            Left = SystemParameters.PrimaryScreenWidth - Width - 10;
        }

        private void ReadLastRep()
        {
            TextReader repRdr = null;
            try
            {
                repRdr = new StreamReader("rep.txt");
                currentRep = Int32.Parse(repRdr.ReadLine());
                lastRep = currentRep;
            }
            catch
            {
                currentRep = 0;
                lastRep = currentRep;
            }
            finally
            {
                if (repRdr != null) repRdr.Close();
            }
        }

        private void InitTimer()
        {
            TextReader rdr = null;
            try
            {
                rdr = new StreamReader("user.txt");
                userId = Int32.Parse(rdr.ReadLine());
                profileLink = "http://stackoverflow.com/users/" + userId;
                timer = new System.Windows.Threading.DispatcherTimer();
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Interval = new TimeSpan(0, 0, 60);
                timer.Start();
                Timer_Tick(this, null);
            }
            catch
            {
                ValLabel.Content = "Invalid user id";
            }
            finally
            {
                if (rdr != null) rdr.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReadLastRep();
            InitTimer();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var client = new StacManClient(FilterBehavior.Strict, key: "QSWiEZktKmMv8QlQObPl8Q((");
                var request = client.Users.GetByIds("stackoverflow", new int[] { userId });
                int rep = request.Result.Data.Items[0].Reputation;                
                ValLabel.Content = rep.ToString();

                string sign = "";
                int diff = rep - lastRep;
                if (diff != 0)
                {
                    if (diff > 0) sign = "+";
                    DiffLabel.Content = sign + diff.ToString();
                    DiffLabel.Visibility = System.Windows.Visibility.Visible;
                }
                currentRep = rep;

                var time = DateTime.Now;
                LastUpdLabel.Content = time.ToShortTimeString();
            }
            catch
            {
                ValLabel.Content = "Server unreachable";
            }
        }

        private void ProfileLabel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(profileLink != null) System.Diagnostics.Process.Start(profileLink);
        }

        private void RefreshLabel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Timer_Tick(this, null);
        }

        private void CloseImg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (timer != null) timer.Stop();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            using (TextWriter wr = new StreamWriter("rep.txt", false))
            {
                wr.WriteLine(currentRep);
            }
        }

        private void DiffLabel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (profileLink != null) System.Diagnostics.Process.Start(profileLink + "?tab=reputation");
            DiffLabel.Visibility = System.Windows.Visibility.Hidden;
            lastRep = currentRep;
        }
    }
}
