   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      8    2Portafolio_Escritorio.Views.UserControlAsignarPass   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��674��6C   
�������.��5
      � .+�5   
   �� .+�5      �� $	��104��6   $��
85,42,94,0q�6%   ���	#FF00A0EC69   �� 5      $��Asignar Contraseña��6   $��Center=�61   $��36(�6N   ���	#FFFBF5F5$��	0,-83,0,0q�6s   5      �� 5   
   $��83,166,93,38q�6   .+�5      �� -   5          ��Name$  txt_buscar_pass��5      $��37��6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ingrese un nombre o ID��6;   $��
45,8,281,0q�6s   �� 5      -   5         ��Name$ btn_buscar_pass��5      $��Buscar��6.   $��512,-38,38,0q�6?   $��37��6U   ���	#FFFDFDFD���	#FF007BFF$��20(�6�   $
��Bold"�6�   ��6x   Z� 6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgv_pass��5         AutoGenerateColumns .  $	��331��6E   $��
45,12,38,0q�6R    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property	 �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � ��	 �	#FF0071CA67   �� 5       � ��
	 �����67   5      5      
   Columns
 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
ID_PERSONA+  5      $	 RUT��68    6E   �� *RUT+  5      $ NOMBRE��68    6H   �� *NOMBRE+  5      $ CORREO��68    6H   �� *MAIL+  5      $ CONTRASEÑA��68    6L   �� *
PASSWORD+5!      �� 5"      -   5        $  txt_id_pass��5"      $��36��6+   $ ID��67   $��45,16,623,0q�6[   �� 5#      -   5        $  txt_nueva_pass��5#      $��36��6.   $ Ingrese la contraseña��6:   $��173,-36,370,0q�6q   �� 5%      -   5        $ btn_guardar_pass��5%      $��428,-34,256,0q�60   $��36��6G   
�������$��20(�6}   $
��Bold"�6�   ���	#FF28A745��6S   Z� .��5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ContentSave=�6*   5'      �� 5(      -   5        $ btn_edit_pass��5(      $��36��6,   $��544,-36,139,0q�68   
����������	#FFFFC107��6O   Z� .��5)        $
 Edit=�6*   5*      �� 5+      -   5        $ btn_actualizar��5+      $��36��6-   $��657,-38,38,0q�69   
����������	#FF17A2B8��6O   Z� .��5,        $ Refresh=�6*   5-      5.      5/      50      