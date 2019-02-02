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
    /// WordDetailsWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WordDetailsWindow : Window
    {
        Vocabulary vocabulary;
        public WordDetailsWindow(Vocabulary vocabulary_window)
        {
            InitializeComponent();
            // 전달 받은 매개 변수로 단어 품사 의미 설정
            this.vocabulary = vocabulary_window;
            word_textbox.Text = vocabulary.Word;
            partsofspeech_textbox.Text = vocabulary.PartsOfSpeech;
            mean_textbox.Text = vocabulary.Mean;
        }

        private void Voca_delete_button_Click(object sender, RoutedEventArgs e)
        {
            // 단어 삭제
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Vocabulary>();
                connection.Delete(vocabulary);
            }

            this.Close();
        }

        private void Voca_set_button_Click(object sender, RoutedEventArgs e)
        {
            //단어 변경
            vocabulary.Word = word_textbox.Text;
            vocabulary.PartsOfSpeech = partsofspeech_textbox.Text;
            vocabulary.Mean = mean_textbox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Vocabulary>();
                // 단어 업데이트
                connection.Update(vocabulary);
            }

            this.Close();
        }
    }
}
