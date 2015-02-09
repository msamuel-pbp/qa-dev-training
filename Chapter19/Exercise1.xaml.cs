using System;
using System.Collections.Generic;
using System.Windows;

namespace Chapter19 {
    /// <summary>
    /// Interaction logic for Exercise1.xaml
    /// </summary>
    public partial class Exercise1 {
        private Random rand = new Random(Guid.NewGuid().GetHashCode());

        public Exercise1() {
            InitializeComponent();
        }

        private void btnName_Click(object sender, RoutedEventArgs e) {
            var Names = new List<string> {"Doug Camel", "James Sandwich", "Space Moose", "Aard vark"};
            txtName.Text = Names[rand.Next(Names.Count)];
        }

        private void btnGender_Click(object sender, RoutedEventArgs e) {
            var Gender = new List<string> { "Male", "Female", "Divergent", "None"};
            txtGender.Text = Gender[rand.Next(Gender.Count)];
        }

        private void btnClass_Click(object sender, RoutedEventArgs e) {
            var Class = new List<string> { "Fighter", "Mage", "Thief", "Know-It-all", "Jester" };
            txtClass.Text = Class[rand.Next(Class.Count)];
        }

        private void btnLevel_Click(object sender, RoutedEventArgs e) {
            var Level = new List<int> { 1,2,3,5,8,13,21,34,55,89};
            txtLevel.Text = Level[rand.Next(Level.Count)].ToString();
        }
    }
}
