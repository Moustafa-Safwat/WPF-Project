   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5          WpfApp1.View.TeachersView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp1.View     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��0.75* �6   �� 5      $��0.25* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $
��auto��6>   $
��auto��6K   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dg��5   j   $��13(�6      HeadersVisibility$ Column=�6'      AlternatingRowBackground �#12B76A   AutoGenerateColumns .   �� SelectedItem 6B   �� *Selected_Item+��6�   �� *Teacherlist+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6)   	   Header$	 
First Name��64   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6H   �� *FName+  5      $ 80 6)   $	 	Last Name��64   
 6G   �� *LName+  5      $ 50 6)   $	 ID��64   
 6@   �� *Id+  5      $ 50 6)   $		 Age��64   
 6A   �� *Age+  5      $
 auto 6)   $	 Subject��66   
 6G   �� *	subject+  5      $ 70 6)   $	 Salary��64   
 6D   �� *Salary+4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Image��6-   $ SizeToCells 6=      CellTemplate 5      �� 5      .R�5   "   �� $��/Images/download.png��6(   $��50��6F   $��50��6Q   5      5      5       5!      �� 5"   
   ���#12B76A$��1��6&   $��17q�66    �� CornerRadius$ 30��6D   ._�5#   
   �� $��Center=�6   .+�5&      �� $��8q�6   $��
First Name��6$   
�������$
��Bold"�6I   $��15(�6[   $��Center=�6i   �� 5'      -   5         ��Name$ F_Name��5'   ,   $��3q�6   $��0 0 0 0q�6T   $��30��6f   $	��170��6r   ���#12B76A���#12B76A$��15(�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   ��6<   �� *F_Name+6�   �� 5(      $��8q�6   $��	Last Name��6'   
�������$
��Bold"�6K   $��15(�6]   $��Center=�6k   �� 5)      -   5        $ L_Name��5)      $��0 0 0 10q�6>   $��30��6Q   $	��170��6]   ���#12B76A���#12B76A$��15(�6�   $
��Bold"�6�   $ Center=�6�   ��6&   �� *L_Name+6�   �� 5*      $��8q�6   $��ID��6'   $��15(�61   
�������$
��Bold"�6R   $��Center=�6d   �� 5+      -   5        $ ID��5+      $��0 0 0 10q�66   $��30��6I   $	��170��6U   ���#12B76A���#12B76A$��15(�6�   $
��Bold"�6�   $ Center=�6�   ��6"   �� *Id+6�   �� 5,      $��8q�6   $	��Age��6'   $��15(�62   
�������$
��Bold"�6S   $��Center=�6e   �� 5-      -   5        $	 agr��5-      $��0 0 0 10q�68   $��30��6K   $	��170��6W   ���#12B76A���#12B76A$��15(�6�   $
��Bold"�6�   $ Center=�6�   ��6#   �� *age+6�   �� 5.      $��8q�6   $��Subject��6'   $��15(�66   
�������$
��Bold"�6W   $��Center=�6i   �� 5/      -   5         ��Name$ subject��5/      $��Center=�6B   $��Center=�6d   $��0 0 0 0q�6�   $��30��6�   $	��170��6�   ���#12B76A���#12B76A$��15(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6   �� Text 6(   �� *	subject+.@�51      �� .��6   Math53      �� 54      .��6   Arabic56      �� 57      .��6   	English59      �� 5:      .��6   	History5<      �� 5=      .��6   Music5?      �� 5@      .��6   French5B      �� 5C      .��6   	Chemistry5E      �� 5F      .��6   	Biology5H      �� 5I      .��6   	Physics5K      �� 5L      .��6   Art5N      5O      �� 5P      $��8q�6   $��Salary��6'   
�������$
��Bold"�6H   $��15(�6Z   $��Center=�6h   �� 5Q      -   5        $ salary��5Q      $��0 0 0 10q�6?   $��30��6R   $	��170��6^   ���#12B76A���#12B76A$��15(�6�   $
��Bold"�6�   $ Center=�6�   ��6'   �� *salary+6�   �� 5T      $��20q�6   $��Add Teacher��6%   
����������#12B76A$��15(�6�   $��40��6�   $	��150��6�   $��Center=�6�      
MenuButton#��[  6�   ��6;   �� *
AddTeacher+6�   �� 5U      $��0q�6   $��Remove Teacher��6$   
����������#12B76A$��15(�6�   $��40��6�   $	��150��6�   $��Center=�6�   #��[  6
  ��6=   �� *RemoveTeacher+��6_   ��  �� ElementName$ dg�� �� Path$ SelectedItem�6
  5W      5X      5\      5]      