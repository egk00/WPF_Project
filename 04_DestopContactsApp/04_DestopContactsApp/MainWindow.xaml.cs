﻿using System;
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
using _04_DestopContactsApp.Class;

namespace _04_DestopContactsApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();

            contacts = new List<Contact>();

            ReadDatabase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new NewContactWindow();

            // 새 윈도우가 닫힐 때가지 기다림
            newContactWindow.ShowDialog();

            ReadDatabase();
        }

        void ReadDatabase()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().ToList().OrderBy(c => c.Name).ToList();

                var variable = from c2 in contacts
                               orderby c2.Name
                               select c2;
            }

            if(contacts != null)
            {
                contacstListView.ItemsSource = contacts;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = sender as TextBox;

            var filteredList = contacts.Where(c => c.Name.Contains(searchTextBox.Text)).ToList();

            var filteredList2 = (from c2 in contacts
                                where c2.Name.ToLower().Contains(searchTextBox.Text.ToLower())
                                orderby c2.Email
                                select c2.Id).ToList();

            contacstListView.ItemsSource = filteredList;

        }

        // 리스트 뷰의 클릭이 변화할 때 마다 이벤트 호출
        private void ContacstListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedContact = (Contact)contacstListView.SelectedItem;

            if(selectedContact != null)
            {
                ContactDetailsWindow contactDetailswindow = new ContactDetailsWindow(selectedContact);

                // 새 윈도우가 닫힐 때가지 기다림
                contactDetailswindow.ShowDialog();
            }
        }
    }
}
