
using Microsoft.Win32; // For OpenFileDialog
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MP3player
{
    public partial class MainWindow : Window
    {
        private MediaElement mediaPlayer;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer = new MediaElement();
            mediaPlayer.LoadedBehavior = MediaState.Manual;
            mediaPlayer.UnloadedBehavior = MediaState.Manual;
            mediaPlayer.MediaOpened += MediaPlayer_MediaOpened;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

            sldVolume.Value = 0.5; // Set initial volume
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Source = new Uri(openFileDialog.FileName);
                mediaPlayer.Play();
                lstPlaylist.Items.Add(openFileDialog.FileName);
            }
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
            timer.Start();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            timer.Stop();
        }

        private void MediaPlayer_MediaOpened(object sender, EventArgs e)
        {
            lblTotalTime.Content = mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
            sldProgress.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null && mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                sldProgress.Value = mediaPlayer.Position.TotalSeconds;
                lblCurrentTime.Content = mediaPlayer.Position.ToString(@"mm\:ss");
            }
        }

        private void SldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaPlayer.Volume = sldVolume.Value;
        }

        private void SldProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                mediaPlayer.Position = TimeSpan.FromSeconds(sldProgress.Value);
            }
        }
    }
}
