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

namespace _04_AddCalculator
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

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            // first_textbox의 텍스트를 가져온다
            string first_txt = first_textbox.Text;
            // second_txtxbox의 텍스트를 가져온다.
            string second_txt = second_textbox.Text;

            // 두 수의 합을 구하기
            float sum = float.Parse(first_txt) + float.Parse(second_txt);

            // 두 수의 합 적용
            result_label.Content = sum.ToString();
        }
    }
}