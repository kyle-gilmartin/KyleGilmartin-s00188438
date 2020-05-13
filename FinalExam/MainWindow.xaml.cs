using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
     
    public partial class MainWindow : Window
    {
        
        PhoneData db = new PhoneData();
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Phones
                        select p;
                        
               
            LboxPhone.ItemsSource = query.ToList();
        }

        private void LboxPhone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = LboxPhone.SelectedItem as Phone;

            if (selectedPhone != null)
            {
                string price = $"Phone Price: €{selectedPhone.Price}";
                TBL_Price.Text = price;
            }

            if (selectedPhone != null)
            {
                string image = $"{selectedPhone.Phone_Image}";
                Img_Phone.Source = new BitmapImage(new Uri(selectedPhone.Phone_Image,UriKind.Relative));
            }


        }
    }
}
