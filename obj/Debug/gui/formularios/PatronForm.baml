   M S B A M L   `   `   `  ����K  GRadioProgramador, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:RadioProgramador.gui.formularios RadioProgramador.gui.formularios  5      1    +RadioProgramador.gui.formularios.PatronForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:RadioProgramador.gui.formularios     5        N� Title$  Patron��5	      .��5      ��    Page.Background#���   6
   $��0q�69    �� CornerRadius$ 5��6M   $��Stretch=�6^   $��Stretch=�6|   ._�5      �  � RowDefinitions 5      �� 5      $��12 �6   �� 5      $��60 �6   �� 5      $
��Auto �6   �� 5      �� 5      $��24 �6    � ColumnDefinitions 5      �� 5      $��24 �6   �� 5      �� 5      �� 5      $��24 �6   .+�5      �� $��Nuevo patrón��6   $��1��6"   $��Center=�62   $��0q�6O   $��1��6Z   $	��Top=�6g   $��18(�6   $��0q�6�   
�������$��2��6�   �� 5      $	����6   $��2��6   $��Right=�6/   $��0,0,72,0q�6K   $��1��6]   $��Bottom=�6j     
ButtonIcon#���  6�    J� RenderTransformOrigin$ -2.188,0.044&�6�   {�.  6�   �� 5      $	����6   $��2��6   $��Right=�6/   $��0,0,36,0q�6K   $��1��6]   $��Bottom=�6j   #���  6�   �� 5      $	����6   $��2��6   $��Right=�6/   $��0q�6K   $��1��6V   $��Bottom=�6c   #���  6~   �� 5      $��2��6   $��1��6   $��0q�6-   $	��Top=�68   .+�5      �� $��Nombre:��6   $
��Left=�6   $��0,0,0,2q�69   $	��Top=�6J   $��0q�6b   
�������6n   �� 5       -   5         ��Name$ 	tb_nombre��5       $��0,0,20,8q�6!    �� TextWrapping$
 Wrap=�63   $	��Top=�6G     TextBoxGeneric#���  6_   � 5!       5"      �� 5#      �� 5$      .+�5&      �� $��
Elementos:��6   $
��Left=�6"   $��0,0,0,2q�6=   $	��Top=�6N   $��0q�6f   
�������6r   5'      5(      �� 5)      $��2��6   $��0q�6    $��2��6+   $	��Top=�68   .+�5*      �� $��Estación de radio:��6   $
��Left=�6)   $��0,0,0,2q�6D   $	��Top=�6U   $��0q�6m   
�������6y   �� 5+      -   5         ��Name$ combo_estacion��5+      $	��Top=�6'     ComboBoxGeneric#���  6?   $��28��6i   $��
0,0,19.2,8q�6u   5,      &   System.Windows.Controls.DataGrid  5-      -   5          Name$ dg_elementos��5-      $��1��6$   $��0q�64   $��3��6?   $��2��6L   	   SelectionMode$	 Single=�6`     DataGridRow
   RowStyle#
 �  6w     DataGridGeneric#���  6�   $��14(�6�      
IsReadOnly .    Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   Z�    ClipboardContentBinding 6-   Z�    Header 50      �� 51   	   $��#��6   $��14(�6   ���#FFFFFF6)   53      4  .System.Windows.Controls.DataGridComboBoxColumn  54      -   5        combo_genero��$ * 54   4     ComboBoxDataGrid   ElementStyle# �  6>      EditingElementStyle# �  6p    55      �� 56   	   $��Género��6   $��14(�6    ���#FFFFFF6.   58        59      -   5        combo_categoria��$ * 59   7   # �  6A   # �  6s    5:      �� 5;   	   $��
Categoría��6   $��14(�6#   ���#FFFFFF61   5=      4  .System.Windows.Controls.DataGridTemplateColumn  5>         CellTemplate 5?      �� 5@   	   .R�5A   
   ��  ��Name$ button_verCanciones��6     ButtonDataGrid#���  6.   $	����6W   $y�Hidden=�6j    �� Triggers 5B   
   �� 5C       �� Value$
 True��6v    �� Binding 6   ��  �� Path$ IsMouseOver� �� RelativeSource ��  �� AncestorType$ DataGridRowL�.a�5D      ��  �� 
TargetName$ button_verCanciones��6)    �� Property � y� �� Value$ Visible=�6J   5E      5G   
   5I        5J       5K      �� 5L   	   .R�5M   
   �� $ button_subir��6   #���  6'   $	����6P   $y�Hidden=�6c    5N   
   �� 5O      $
 True��6v    6   �� $ IsMouseOver� �� $ DataGridRowL�.a�5P      �� $ button_subir��6)    � y�$ Visible=�6C   5Q      5S   
   5U        5V       5W      �� 5X   	   .R�5Y   
   �� $ button_bajar��6   #���  6'   $	����6P   $y�Hidden=�6c    5Z   
   �� 5[      $
 True��6v    6   �� $ IsMouseOver� �� $ DataGridRowL�.a�5\      �� $ button_bajar��6)    � y�$ Visible=�6C   5]      5_   
   5a        5b       5c      �� 5d   	   .R�5e   
   �� $ button_remover��6   #���  6)   $	����6R   $y�Hidden=�6e    5f   
   �� 5g      $
 True��6v    6   �� $ IsMouseOver� �� $ DataGridRowL�.a�5h      �� $ button_remover��6)    � y�$ Visible=�6E   5i      5k   
   5m      5o      5p      5q      5r      