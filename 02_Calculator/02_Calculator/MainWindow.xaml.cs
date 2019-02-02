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

namespace _02_Calculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();

            // result_label의 Content 값을 변경합니다.
            result_label.Content = "3537";
            // 0으로 초기화 버튼
            ac_button.Click += Ac_button_Click;
            // + / - 변경 버튼
            negative_button.Click += Negative_button_Click;
            // 100분율로 나눕니다.
            percentage_button.Click += Percentage_button_Click;
            // Equals button
            equaals_button.Click += Equals_button_Click;
        }

        private void Equals_button_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(result_label.Content.ToString(), out newNumber))
            {
                switch(selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Sustraction:
                        result = SimpleMath.Sub(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Division(lastNumber, newNumber);
                        break;
                }

                result_label.Content = result.ToString();
            }
        }

        private void Percentage_button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(result_label.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                result_label.Content = lastNumber.ToString();
            }
        }

        private void Negative_button_Click(object sender, RoutedEventArgs e)
        {
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
            if (double.TryParse(result_label.Content.ToString(), out lastNumber))
            {
                result_label.Content = 0;
            }

            if(sender == multiply_button)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == division_button)
                selectedOperator = SelectedOperator.Division;
            if (sender == plus_button)
                selectedOperator = SelectedOperator.Addition;
            if (sender == minus_button)
                selectedOperator = SelectedOperator.Sustraction;
        }

        private void Number_button_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if(sender == zero_button)
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
            {
                result_label.Content = $"{selectedValue}";
            }
            else
            {
                result_label.Content = $"{result_label.Content}{selectedValue}";
            }
        }

        public enum SelectedOperator
        {
            Addition,
            Sustraction,
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

            public static double Multiply(double n1, double n2)
            {
                return n1 * n2;
            }

            public static double Division(double n1, double n2)
            {
                return n1 / n2;
            }
        }
    }
}
