﻿using BookLibrary.Storage.Repositories;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BookLibrary.UI.Windows
{
    public partial class BookLibraryWindow : Window
    {
        protected readonly IBookLibraryRepository DataStore = new BookLibraryRepository();

        public BookLibraryWindow() : base()
        {
            Icon = (BitmapSource)new ImageSourceConverter()
                    .ConvertFrom(Properties.Resources.favicon);
        }

        protected void Window_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        protected void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        protected void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
