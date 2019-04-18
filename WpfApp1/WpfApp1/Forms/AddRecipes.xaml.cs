﻿using System;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour AjoutRecette.xaml
    /// </summary>

    public partial class AddRecipes : Window
    {
        RecipeViewModel vm;
        public AddRecipes(RecipeViewModel vm)
        {
            this.vm = vm;
            this.DataContext = this.vm;
            InitializeComponent();
          
        }

        private void ButtonAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            var nextVm = this.vm.ShowListIngreForm();
            var nextForm = new AddListIngredient(nextVm,this.vm.allRecipies);
            nextForm.Show();
        }
    }
}
