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

namespace _15_WPF_ListView
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            //리스트 뷰 추가
            items.Add(new User()
            {
                Name = "Park",
                Age = 32,
                Mail = "Park@gmail.com"
            });

            items.Add(new User()
            {
                Name = "Kim",
                Age = 42,
                Mail = "Kim@gmail.com"
            });

            items.Add(new User()
            {
                Name = "Lee",
                Age = 22,
                Mail = "Leek@gmail.com"
            });
            // ItemSource에 추가
            MyListView.ItemsSource = items;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
    }
}
