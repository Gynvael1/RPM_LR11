using System;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace LR9_RPM
{
    public partial class MyVideoBlock : UserControl
    {
        public MyVideoBlock()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video files (*.mp4;*.avi;*.mkv;*.mov;*.wmv)|*.mp4;*.avi;*.mkv;*.mov;*.wmv|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    MyVideo.Source = new Uri(dialog.FileName);
                    MyVideo.Visibility = Visibility.Visible;
                    Placeholder.Visibility = Visibility.Collapsed;
                    MyVideo.Play();
                    MyVideo.Pause();
                    SystemSounds.Beep.Play();
                }
                catch
                {
                    MyVideo.Source = null;
                    MyVideo.Visibility = Visibility.Collapsed;
                    Placeholder.Visibility = Visibility.Visible;
                }
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            MyVideo.Play();
            SystemSounds.Asterisk.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            MyVideo.Pause();
            SystemSounds.Exclamation.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            MyVideo.Stop();
            SystemSounds.Hand.Play();
        }
    }
}