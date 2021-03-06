﻿using JMMClient.Downloads;
using System.Windows;
using System.Windows.Controls;

namespace JMMClient.UserControls
{
    /// <summary>
    /// Interaction logic for DownloadSettingsTorSources.xaml
    /// </summary>
    public partial class DownloadSettingsTorSources : UserControl
    {
        public DownloadSettingsTorSources()
        {
            InitializeComponent();

            btnMoveRight.Click += new RoutedEventHandler(btnMoveRight_Click);
            btnMoveLeft.Click += new RoutedEventHandler(btnMoveLeft_Click);
            btnMoveUp.Click += new RoutedEventHandler(btnMoveUp_Click);
            btnMoveDown.Click += new RoutedEventHandler(btnMoveDown_Click);
        }

        void btnMoveDown_Click(object sender, RoutedEventArgs e)
        {

            if (lbSelectedTorrentSources.SelectedItem == null) return;

            TorrentSourceVM ts = lbSelectedTorrentSources.SelectedItem as TorrentSourceVM;

            int newPos = UserSettingsVM.Instance.MoveDownTorrentSource(ts.TorrentSource);
            if (newPos >= 0)
            {
                lbSelectedTorrentSources.SelectedIndex = newPos;
                lbSelectedTorrentSources.Focus();
            }
        }

        void btnMoveUp_Click(object sender, RoutedEventArgs e)
        {
            if (lbSelectedTorrentSources.SelectedItem == null) return;

            TorrentSourceVM ts = lbSelectedTorrentSources.SelectedItem as TorrentSourceVM;

            int newPos = UserSettingsVM.Instance.MoveUpTorrentSource(ts.TorrentSource);
            if (newPos >= 0)
            {
                lbSelectedTorrentSources.SelectedIndex = newPos;
                lbSelectedTorrentSources.Focus();
            }
        }

        void btnMoveLeft_Click(object sender, RoutedEventArgs e)
        {
            if (lbSelectedTorrentSources.SelectedItem == null) return;

            TorrentSourceVM ts = lbSelectedTorrentSources.SelectedItem as TorrentSourceVM;

            UserSettingsVM.Instance.RemoveTorrentSource(ts.TorrentSource);
        }

        void btnMoveRight_Click(object sender, RoutedEventArgs e)
        {
            if (lbUnselectedTorrentSources.SelectedItem == null) return;

            TorrentSourceVM ts = lbUnselectedTorrentSources.SelectedItem as TorrentSourceVM;

            UserSettingsVM.Instance.AddTorrentSource(ts.TorrentSource);
        }
    }
}
