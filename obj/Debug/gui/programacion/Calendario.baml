   M S B A M L   `   `   `  ����K  GRadioProgramador, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:RadioProgramador.gui.programacion!RadioProgramador.gui.programacion  5      2    ,RadioProgramador.gui.programacion.Calendario   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:RadioProgramador.gui.programacion     5        N� Title$  
Calendario��5	      .��5      ��    Page.Background#���   6
   $��0q�69    �� CornerRadius$ 5��6M   $��Stretch=�6^   $��Stretch=�6|   ._�5      �  � RowDefinitions 5      �� 5      $��12 �6   �� 5      $��32 �6   �� 5      �� 5      $	��180 �6   �� 5      �� 5      $��24 �6    � ColumnDefinitions 5      �� 5      $��5* �6   $��24��6"   �� 5      $	��90* �6   $	��460��6#   �� 5      $��5* �6   .+�5      �� -   5         ��Name$ label_fechaHora��5      $��Fecha y hora��6$   $��Center=�6;   $��0q�6X   $��1��6c   $	��Top=�6p   $��22(�6�   $��0q�6�   
�������$��3��6�   �� 5      $��1��6   $
��Left=�6   $��Stretch=�67   $��Stretch=�6\   $��0q�6   $��3��6�   $	��Top=�6�   $	��130��6�     ButtonGeneric#���  6�   $��32��6�   $��0,0,12,0q�6�   $��2��6  $��2��6  .��5      � $��Stretch=�6   $��Stretch=�6)    5      �� 5      $
��Auto �6   �� 5      $��* �6   .+�5!      �� $��0��6   $	����6   $��20(�60   $��Segoe MDL2 Assets)�6>   ���#FFFFFF$��Center=�6r   $��Center=�6�   $��0q�6�   $��32��6�   �� 5"      $��1��6   $��	Programar��6   $��14(�61   ���#FFFFFF$��0q�6T   $��Center=�6`   5#      5$      �� 5%      $��1��6   $
��Left=�6   $��Stretch=�67   $��Stretch=�6\   $��0,44,0,0q�6   $��3��6�   $	��Top=�6�   $	��130��6�   #���  6�   $��32��6�   $��0,0,12,0q�6�   $��2��6	  .��5&      � $��Stretch=�6   $��Stretch=�6)    5'      �� 5(      $
��Auto �6   �� 5)      $��* �6   .+�5+      �� $��0��6   $	����6   $��20(�60   $��Segoe MDL2 Assets)�6>   ���#FFFFFF$��Center=�6r   $��Center=�6�   $��0q�6�   $��32��6�   �� 5,      $��1��6   $��Editar día��6   $��14(�62   ���#FFFFFF$��0q�6U   $��Center=�6a   5-      5.      �� 5/      $��Días ya programados:��6   $��1��6*   $
��Left=�6:   $��
0,0,0,72.4q�6U   $��3��6i   $��Bottom=�6v   
�������$��0q�6�   $��14(�6�   $��2��6�   	� 50      -   5         	�Name$ rb_preguntar��50      $��Preguntar antes��6'   $��1��6A   $
��Left=�6Q   $��
0,0,0,24.4q�6l   $��3��6�   $��Bottom=�6�   
�������
�������$��14(�6�     RadioButtonGeneric#���  6�   $��2��6   ��6�   Z� 6   	� 51      -   5        $ rb_noProgramar��51      $��No volver a programar��6)   $��1��6I   $
��Left=�6Y   $��	0,0,0,0.4q�6t   $��3��6�   $��Bottom=�6�   
�������
�������$��14(�6�   #���  6�   $��2��6'   d� 	IsChecked$
 TrueY�6;  ��6�   Z� 6;  	� 52      -   5        $ rb_sobreescribir��52      $��Sobrescribir��6+   $��1��6B   $
��Left=�6R   $��
0,0,0,48.4q�6m   $��3��6�   $��Bottom=�6�   
�������
�������$��14(�6�   #���  6�   $��2��6!  ��6�   Z� 6!  &   System.Windows.Controls.Calendar  53      $��1��6   $��Right=�6   $��0q�6:   $��2��6E   $��Center=�6R     CalendarGeneric#���  6m   $��3��6�   54      55      57      