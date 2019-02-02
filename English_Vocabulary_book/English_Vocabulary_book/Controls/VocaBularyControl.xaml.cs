using English_Vocabulary_book.Class;
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

namespace English_Vocabulary_book.Controls
{
    /// <summary>
    /// VocaBularyControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class VocaBularyControl : UserControl
    {

        // propdp 적용
        public Vocabulary Vocabulary
        {
            get { return (Vocabulary)GetValue(VocabularyProperty); }
            set { SetValue(VocabularyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Vocabulary.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VocabularyProperty =
            DependencyProperty.Register("Vocabulary", typeof(Vocabulary), typeof(VocaBularyControl), new PropertyMetadata(
                new Vocabulary()
                {
                    Word = "단어",
                    PartsOfSpeech = "품사",
                    Mean = "의미"
                }, SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            VocaBularyControl vocaBularyControl = d as VocaBularyControl;

            if(vocaBularyControl != null)
            {
                vocaBularyControl.word_textblock.Text = (e.NewValue as Vocabulary).Word;
                vocaBularyControl.partsOfSpech_textblock.Text = (e.NewValue as Vocabulary).PartsOfSpeech;
                vocaBularyControl.mean_textblock.Text = (e.NewValue as Vocabulary).Mean;
            }
        }

        public VocaBularyControl()
        {
            InitializeComponent();
        }
    }
}
