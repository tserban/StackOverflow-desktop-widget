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
using System.Timers;
using System.Threading.Tasks;

namespace SO_Widget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int userId;
        private string profileLink = null;
        private Timer timer = null;
        private int currentRep;
        private int lastRep;
        private bool isValidUser;

        /// <summary>
        /// Creates a new instance of class MainWindow.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            SetWindowPosition();
        }

        /// <summary>
        /// Sets the window position to the top-right corner of the screen.
        /// </summary>
        private void SetWindowPosition()
        {
            this.Top = 7;
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width - 10;
        }

        /// <summary>
        /// Reads the recorded reputation from when the application was last closed.
        /// </summary>
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
                ValLabel.Content = currentRep.ToString("#,###");
            }
        }

        /// <summary>
        /// Reads the userId from the user.txt file.
        /// </summary>
        private void ReadUser()
        {
            TextReader rdr = null;
            try
            {
                rdr = new StreamReader("user.txt");
                userId = Int32.Parse(rdr.ReadLine());
                profileLink = "http://stackoverflow.com/users/" + userId;
                isValidUser = true;
            }
            catch
            {
                DiscImg.ToolTip = "Invalid user id";
                DiscImg.Visibility = System.Windows.Visibility.Visible;
            }
            finally
            {
                if (rdr != null) rdr.Close();
            }
        }

        /// <summary>
        /// Initiates the periodic update of the reputation label.
        /// </summary>
        private void InitTimer()
        {
            timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(Timer_Tick);
            timer.Interval = 60000;
            timer.Start();
        }

        /// <summary>
        /// Truncates a string that is longer than 3 characters e.g. "abcd" becomes "ab..."
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>The truncated string.</returns>
        private string DisplayTruncated(string str)
        {
            if (str.Length <= 3) return str;
            else
            {
                return str.Substring(0, 2) + "...";
            }
        }

        /// <summary>
        /// Refreshes the reputation display.
        /// </summary>
        private void Refresh()
        {
            Task.Factory.StartNew(() => Timer_Tick(this, null));
        }

        /// <summary>
        /// Updates the UI with the given Action in a thread-safe manner.
        /// </summary>
        /// <param name="action">The Action used to update the UI.</param>
        private void UpdateUI(Action action)
        {
            if (!this.Dispatcher.CheckAccess())
            {
                this.Dispatcher.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        #region Handlers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReadLastRep();
            ReadUser();
            InitTimer();
            Refresh();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isValidUser)
            {
                try
                {
                    var client = new StacManClient(FilterBehavior.Strict, key: "QSWiEZktKmMv8QlQObPl8Q((");
                    var request = client.Users.GetByIds("stackoverflow", new int[] { userId });
                    int rep = request.Result.Data.Items[0].Reputation;

                    string sign = "";
                    string diffString = "";
                    System.Windows.Visibility visibility = System.Windows.Visibility.Hidden;

                    int diff = rep - lastRep;
                    if (diff != 0)
                    {
                        if (diff > 0) sign = "+";
                        diffString = sign + DisplayTruncated(diff.ToString("#,###"));
                        visibility = System.Windows.Visibility.Visible;
                    }
                    currentRep = rep;

                    var time = DateTime.Now;
                    UpdateUI(
                        (Action)(() =>
                        {
                            DiffLabel.Content = diffString;
                            DiffLabel.Visibility = visibility;
                            ValLabel.Content = rep.ToString("#,###");
                            LastUpdLabel.Content = time.ToShortTimeString();
                            DiscImg.Visibility = System.Windows.Visibility.Hidden;
                        }));
                }
                catch
                {
                    UpdateUI(
                        (Action)(() =>
                        {
                            DiscImg.ToolTip = "Connection failed";
                            DiscImg.Visibility = System.Windows.Visibility.Visible;
                        }));
                }
            }
        }

        private void ProfileLabel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(profileLink != null) System.Diagnostics.Process.Start(profileLink);
        }

        private void RefreshLabel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Refresh();
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

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = this.ContextMenu.Items[0] as MenuItem;
            item.IsChecked = !item.IsChecked;
        }

        private void Window_LocationChanged(object sender, EventArgs e)
        {
            SetWindowPosition();
        }

        #endregion
    }
}
