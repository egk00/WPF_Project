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

namespace _10_WPF_Show_ShowDialog
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Show_Button_Click(object sender, RoutedEventArgs e)
        {
            // 새로운 창 생성
            Window_Show window_Show = new Window_Show();
            window_Show.Show();
        }

        private void Btn_ShowDialog_Button_Click(object sender, RoutedEventArgs e)
        {
            // showdialog 버튼
            Window_ShowDialog window_ShowDialog = new Window_ShowDialog();
            window_ShowDialog.ShowDialog();
        }
    }
}
