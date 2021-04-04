using HardwareSoftwareMonitor.src;
using System.Collections.Generic;
using System.Windows;
using System.Management;
using Microsoft.Win32;
using System;
using System.Linq;

namespace HardwareSoftwareMonitor
{
    public partial class MainWindow : Window
    {
        List<InstalledApp> apps = new List<InstalledApp>();
        List<string> keys = new List<string>() {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
            @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
        };

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            GetInstalledApps();
            softDG.ItemsSource = apps;
        }

        public void GetInstalledApps()
        {
            FindInstalls(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64), keys, apps);
            FindInstalls(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64), keys, apps);

            apps = apps.Where(x => !string.IsNullOrWhiteSpace(x.Name)).Distinct().ToList();        
        }

        private void FindInstalls(RegistryKey regKey, List<string> keys, List<InstalledApp> installs)
        {
            foreach (string key in keys)
            {
                using (RegistryKey rk = regKey.OpenSubKey(key))
                {
                    if (rk == null)
                    {
                        continue;
                    }
                    foreach (string skName in rk.GetSubKeyNames())
                    {
                        using (RegistryKey sk = rk.OpenSubKey(skName))
                        {
                            try
                            {
                                installs.Add(new InstalledApp(Convert.ToString(sk.GetValue("DisplayName")),Convert.ToString(sk.GetValue("DisplayVersion"))));
                            }
                            catch (Exception ex)
                            { }
                        }
                    }
                }
            }
        }
    }
}
