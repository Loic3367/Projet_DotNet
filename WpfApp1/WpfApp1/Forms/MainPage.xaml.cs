﻿using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        private ObservableCollection<Ingredient> listIngre;
        public MainPage()
        {
            InitializeComponent();
            //LoginWindow myLogWindow = new LoginWindow();
            //myLogWindow.Show();                    
            DataAccess.SelectAllIngredients();
            listIngre = new ObservableCollection<Ingredient>(DataAccess.SelectAllIngredients());
            lvMainIngre.ItemsSource = listIngre;
        }

        private void AddIngre_click(object sender, RoutedEventArgs e)
        {
            AddIngredients addIngredient = new AddIngredients(listIngre);
            addIngredient.Show();
        }
    }
}
