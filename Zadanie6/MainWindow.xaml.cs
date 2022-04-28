using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Zadanie6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            Data = new ObservableCollection<Person>();
            
            InitializeComponent();
            RegionBox.ItemsSource = Enum.GetValues(typeof(RegionEnum));
        }

        public Person? SelectedPerson { get; set; }
        
        public ObservableCollection<Person> Data { get; }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            var person = CreatePersonBasedOnForms();

            Data.Add(person);
            ClearForms();
        }

        private static double? TryParseDouble(string? text)
        {
            if (text is null)
            {
                return null;
            }

            var result = double.TryParse(text, out var parsedValue);

            if (!result)
            {
                return null;
            }

            return parsedValue;
        }

        private static RegionEnum? TryParseRegionEnum(string? text)
        {
            if (text is null)
            {
                return null;
            }

            var result = Enum.TryParse(text, out RegionEnum parsedValue);

            if (!result)
            {
                return null;
            }

            return parsedValue;
        }

        private void PersonsListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPerson = (Person?) PersonsListBox.SelectedItem; //kids, don't do that
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedPerson)));
        }

        private void EditButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Data[PersonsListBox.SelectedIndex] = CreatePersonBasedOnForms();
            Data.Refresh();
        }

        private Person CreatePersonBasedOnForms()
        {
            var isDetailsEnabled = DetailsCheckBox.IsChecked ?? false;
            return new Person
            {
                AccessLevel = isDetailsEnabled ? AccessLevelSlider.Value : 0,
                Name = NameBox.Text,
                Surname = SurnameBox.Text,
                Email = isDetailsEnabled ? EmailBox.Text : null,
                Deposit = TryParseDouble(DepositBox.Text),
                Region = TryParseRegionEnum(RegionBox.Text)
            };
        }

        private void ClearForms()
        {
            SelectedPerson = null;
            DetailsCheckBox.IsChecked = false;
            EmailBox.Text = NameBox.Text = SurnameBox.Text = DepositBox.Text = RegionBox.Text = null;
        }
    }
}
