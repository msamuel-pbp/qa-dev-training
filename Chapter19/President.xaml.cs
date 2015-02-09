using System;
using System.Windows;
using System.Windows.Controls;

namespace Chapter19 {
    /// <summary>
    /// Interaction logic for President.xaml
    /// </summary>
    public partial class President {
        public President() {
            InitializeComponent();
        }

        private void PresPhotoListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            ListBox lb = sender as ListBox;
            if (lb != null) {
                if (lb.SelectedItem != null) {
                    var chosenName = (lb.SelectedItem as ImageURL).Name;
                    Title = chosenName;
                }
            }
            else {
                throw new ArgumentException("Expected ListBox to call selection changed in PresPhotoListBox_SelectionChanged");
            }
        }
    }
}