﻿using FindaCook.Maui.Models;

namespace FindaCook
{
    public partial class App : Application
    {
        public static User user;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}