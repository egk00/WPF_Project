using _13_Cloning_Evernote.Model;
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

namespace _13_Cloning_Evernote.View.UserControls
{
    /// <summary>
    /// NoteControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NoteControl : UserControl
    {
        //propdp
        public Note Note
        {
            get { return (Note)GetValue(NoteProperty); }
            set { SetValue(NoteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Note.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NoteProperty =
            DependencyProperty.Register("Note", typeof(Note), typeof(NoteControl), new PropertyMetadata(null, setValue));

        private static void setValue(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NoteControl note = d as NoteControl;

            if (note != null)
            {
                note.titleTextBlock.Text = (e.NewValue as Note).Title;
                note.titleTextBlock.Text = (e.NewValue as Note).UpdatedTime.ToShortDateString();
                note.contentTextBlock.Text = (e.NewValue as Note).Title;
            }
        }

        public NoteControl()
        {
            InitializeComponent();
        }
    }
}
