using System;
using System.Windows;
using System.Windows.Threading;

namespace _18_Creating_A_Custom_Dependency
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), // 시간 간격
                                                        DispatcherPriority.Normal, // 우선 순위 기본
                                                        delegate
                                                        {
                                                            int newvalue = 0;
                                                            if (Counter == int.MaxValue)
                                                            {
                                                                newvalue = 0;
                                                            }
                                                            else
                                                            {
                                                                newvalue = Counter + 1;
                                                            }
                                                            SetValue(CounterProperty, newvalue);
                                                        }, Dispatcher);
        }


        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Counter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counter", //등록할 의존 속성 이름
                typeof(int), // 의존 속성 데이터 형
                typeof(MainWindow), // 소유하고 있는 클래스
                new PropertyMetadata(25)); // 초기 설정 값
    }
}
