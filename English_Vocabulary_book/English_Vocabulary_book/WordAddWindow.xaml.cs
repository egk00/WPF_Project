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
using System.Windows.Shapes;

namespace English_Vocabulary_book
{
    /// <summary>
    /// WordAddWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WordAddWindow : Window
    {
        public WordAddWindow()
        {
            InitializeComponent();
        }

        private void Word_add_button_Click(object sender, RoutedEventArgs e)
        {
            // 단어 추가 버튼
            // 단어, 품사 종류, 의미 텍스트 박스 가져와 Vocabulary객체 생성
            Vocabulary vocabulary = new Vocabulary
            {
                Word = word_textbox.Text,
                PartsOfSpeech = partsofspeech_textbox.Text,
                Mean = mean_textbox.Text
            };

            //SQLlite에 insert
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Vocabulary>();
                connection.Insert(vocabulary);
            }
            
            this.Close();
        }

        private void Cancel_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
