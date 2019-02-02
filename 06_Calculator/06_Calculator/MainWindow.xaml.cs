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

namespace _06_Calculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator; // +, -, *, / 연산 저장

        public MainWindow()
        {
            InitializeComponent();

            nagative_button.Click += Negative_button_Click;
            
        }

        public enum SelectedOperator
        {
            Addition,
            Substraction,
            Multiplication,
            Division
        }

        public class SimpleMath
        {
            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }

            public static double Sub(double n1, double n2)
            {
                return n1 - n2;
            }
            public static double division(double n1, double n2)
            {
                if(n2 == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                }
                return n1 / n2;
            }

            public static double multiply(double n1, double n2)
            {
                return n1 * n2;
            }
        }

        private void Negative_button_Click(object sender, RoutedEventArgs e)
        {
            // 결과 라벨이 숫자인 경우 true 반환 후 lastNumber에 숫자 저장, 아닐 경우 false 
            if(double.TryParse(result_label.Content.ToString(), out lastNumber ))
            {
                lastNumber = lastNumber * -1;
                result_label.Content = lastNumber.ToString();
            }
        }

        private void Ac_button_Click(object sender, RoutedEventArgs e)
        {
            result_label.Content = "0";
        }

        private void Operation_Button_Click(object sender, RoutedEventArgs e)
        {
            // 연산 버튼 클릭 시 결과 라벨 0으로 설정 후 lastNumber에 저장
            if (double.TryParse(result_label.Content.ToString(), out lastNumber))
            {
                result_label.Content = 0;
            }
            // 연산 버튼 누를 시 각 버튼 selectedOperator에 저장
            if (sender == multiply_button)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == division_button)
                selectedOperator = SelectedOperator.Division;
            if (sender == plus_button)
                selectedOperator = SelectedOperator.Addition;
            if (sender == minus_button)
                selectedOperator = SelectedOperator.Substraction;
        }

        // = 버튼 누를 시
        private void Equals_button_Click(object sender, RoutedEventArgs e)
        {
            double temp;
            if(double.TryParse(result_label.Content.ToString(), out temp))
            {
                switch(selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, temp);
                        break;
                    case SelectedOperator.Substraction:
                        result = SimpleMath.Sub(lastNumber, temp);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.multiply(lastNumber, temp);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.division(lastNumber, temp);
                        break;
                }
                result_label.Content = result.ToString();
            }
           
        }
        // % 버튼을 누를 경우 넘버 / 100을 합니다.
        private void Percentage_button_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(result_label.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;

                result_label.Content = lastNumber.ToString();
            }
        }

        private void Dot_button_Click(object sender, RoutedEventArgs e)
        {
            double temp;
            if(double.TryParse(result_label.Content.ToString(), out temp))
            {
                result_label.Content = $"{temp}.";
            }
        }

        private void Number_Button_Click(Object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender == zero_button)
                selectedValue = 0;
            if (sender == one_button)
                selectedValue = 1;
            if (sender == two_button)
                selectedValue = 2;
            if (sender == three_button)
                selectedValue = 3;
            if (sender == four_button)
                selectedValue = 4;
            if (sender == five_button)
                selectedValue = 5;
            if (sender == six_button)
                selectedValue = 6;
            if (sender == seven_button)
                selectedValue = 7;
            if (sender == eight_button)
                selectedValue = 8;
            if (sender == nine_button)
                selectedValue = 9;

            if (result_label.Content.ToString() == "0")
                result_label.Content = $"{selectedValue}";

            else
                result_label.Content = $"{result_label.Content}{selectedValue}";
        }
    }
}
