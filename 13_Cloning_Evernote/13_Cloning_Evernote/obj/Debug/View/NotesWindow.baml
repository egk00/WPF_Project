   M S B A M L   `   `   `  ����N  J13_Cloning_Evernote, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:_13_Cloning_Evernote.View_13_Cloning_Evernote.View  5   	   O,clr-namespace:_13_Cloning_Evernote.ViewModel_13_Cloning_Evernote.ViewModel  5   	   _4clr-namespace:_13_Cloning_Evernote.View.UserControls&_13_Cloning_Evernote.View.UserControls  5   	   +    %_13_Cloning_Evernote.View.NotesWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:_13_Cloning_Evernote.View     5   	   ;vm,clr-namespace:_13_Cloning_Evernote.ViewModel     5   	   Cuc4clr-namespace:_13_Cloning_Evernote.View.UserControls     5   	     � Title$  NotesWindow��5
   	   $	��400��6   $	��600��6*    � 	Resources 5      ,   &_13_Cloning_Evernote.ViewModel.NotesVM   vm��%   &	          5   
   6   5      .��5      ]�  � DataContext# [  6   .+�5   
   �� $��Bottom=�6   .@�5      �� .��5      �� -   5         ��Name$ statusTextBlock��5      5      5      o� 5   
   $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $��New notebook��6    m� Command 5      �� *NewNotebookCommand+m� 5      $��New note��6    5      �� *NewNoteCommand+ m� CommandParameter 5      �� *SelectedNotebook+�� 5      m� 5      -   5        $
��Exit��5      5      5      5       �� 5!   
   $	��140��6   
���p�$
��Left=�5#       �� SelectedItem 5$      �� *SelectedNotebook+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5%      �� *	Notebooks+��5&      �� 5'      .R�5(      5   /_13_Cloning_Evernote.View.UserControls.Notebook  	   DisplayNotebook	 6"   �� 5)      5,      �� 5-   
   $	��140��6   $
��Left=�5.      ��5/      �� *Notes+��50      �� 51      .R�52      8   2_13_Cloning_Evernote.View.UserControls.NoteControl  
   Note
 6%   �� 53      55      `� 57   
   $	��Top=�6   .�58      c� .@�6   .@�59      > d� -   5         d�Name$ SpeechButton��59      $��Speech��5:      5;      d� 5<      -   5        $ 
boldButton��5<      .��5>      �� $��B��6    $
��Bold"�5?       5@      d� 5A      -   5        $ italicButton��5A      .��5C      �� $��I��6    $��Italic$�5D       5E      d� 5F      -   5        $ underlineButton��5F      .��5H      �� $��U��6    $��	Underline{�5I       5J      �� 5K      -   5         ��Name$ fontFamilyComboBox��5K      $	��100��5L      5M      �� 5N      -   5        $ fontSizeComboBox��5N      $��50��5O       �� 
IsEditable . 5Q      5R      5S      � 5T   
   .+�5U      �� -	   5         ��Name$ contentRichTextBox��5U      5W      5X      5Z      5[      