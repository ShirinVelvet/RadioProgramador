   M S B A M L   `   `   `  ����K  GRadioProgramador, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RadioProgramador.guiRadioProgramador.gui  5      '    !RadioProgramador.gui.InicioSesion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      4local"clr-namespace:RadioProgramador.gui     5        � Title$  RadioProgramador��5       � WindowStyle$
 None=�5	       � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�5
         App.Background#���   6   $	��460��5      $	��360��6   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5      -   5        
chrome��   CaptionHeight$ 0Q�5   !      ResizeBorderThickness$ 0q�63   .��5      � .+�5      � -   5        $	��Top=�5   	   #���   6;   .+�5      �� -   5        $	����5      $��Right=�6   $��0q�6;   $	��Top=�6F   $��41��6^   $��28��6i   
�������$��Segoe MDL2 Assets)�6�     ButtonClose#���  6�   ��6u   Z� 6�   �� 5      -   5        $	����5      $��Right=�6   $��0,0,41,0q�6;   $	��Top=�6M   $��41��6e   $��28��6p   
�������$��Segoe MDL2 Assets)�6�     ButtonMaximize#���  6�   ��6|   Z� 6�   5      �� 5      
���   �$��1q�6   $��Center=�63   $��0,80,0,0q�6P   $	��Top=�6b   ._�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5      �� $��RadioProgramador��6   $��0q�6'   
�������$��20(�6E   $��Right=�6S   $��Bottom=�6o   $��1��6�   �� 5      $
��Left=�6   $��36��6'   $	��Top=�63   $��36��6K   5      5      �� 5      $��Iniciar Sesión��6
   $��Center=�6#   $��	0,140,0,0q�6@   $	��Top=�6S   
�������$��16(�6~   �� 5      $��Usuario��6
   $
��Left=�6   $��
90,199,0,0q�67   $	��Top=�6K   
�������$��0q�6v   �� 5       $��Contraseña��6
   $
��Left=�6   $��
90,269,0,0q�6:   $	��Top=�6N   
�������$��0q�6y   �� 5!      -   5         ��Name$ tb_user��5!      $��Center=�6   $��	0,220,0,0q�6:   	 �� TextWrapping$
	 Wrap=�6M   $	��Top=�6a     TextBoxGeneric#���  6y   $	��180��6�   G� 5"      -   5        
 G�Name$
 pb_password��5"      $��Center=�6%   $��	0,290,0,0q�6B   $	��Top=�6U   $	��180��6m     PasswordBoxGeneric#���  6y   �� 5#      $��Iniciar Sesión��6   $��Center=�6$   $��	0,360,0,0q�6A   $	��Top=�6T   $	��180��6l     ButtonGeneric#���  6x    �� 	IsDefault . 6�   5$      5%      