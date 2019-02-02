using English_Vocabulary_book.Class;
using SQLite;
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

namespace English_Vocabulary_book
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Vocabulary> vocabularies;
        public MainWindow()
        {
            InitializeComponent();

            vocabularies = new List<Vocabulary>();

            ReadDatabase();
        }

        private void Word_add_Click(object sender, RoutedEventArgs e)
        {
            // 영어 단어 추가 화면
            WordAddWindow wordAddWindow = new WordAddWindow();
            // 윈도우가 닫힐 때까지 기다림
            wordAddWindow.ShowDialog();

            ReadDatabase();
        }

        private void ReadDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Vocabulary>();
                vocabularies = connection.Table<Vocabulary>().OrderBy(c => c.Word).ToList();
            }

            if(vocabularies != null)
            {
                vocabulary_ListView.ItemsSource = vocabularies;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = sender as TextBox;

            var filteredList = vocabularies.Where(v => v.Word.Contains(searchTextBox.Text)).ToList();

            vocabulary_ListView.ItemsSource = filteredList;
        }

        // 리스트 뷰 클릭이 변화할 때 마다 이벤트 호출
        private void Vocabulary_ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 선택된 아이템 Vocabulary로 형 변환 저장
            Vocabulary selectedvocabulary = vocabulary_ListView.SelectedItem as Vocabulary;

            if(selectedvocabulary != null)
            {
                // 선택된 vocabulary 아이템을 매개변수로 전달하고 상세 윈도우 띄움
                WordDetailsWindow wordDetailsWindow = new WordDetailsWindow(selectedvocabulary);

                wordDetailsWindow.ShowDialog();
            }

            //데이터 베이스 다시 설정
            ReadDatabase();
        }
    }
}
