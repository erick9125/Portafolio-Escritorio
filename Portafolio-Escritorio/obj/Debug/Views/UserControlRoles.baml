   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      2    ,Portafolio_Escritorio.Views.UserControlRoles   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��671��6C   .��5
      � 
�������.+�5   
   �� $��119,10,85,547q�6   .+�5      �� $	��112��6   ���	#FF024CAD6%   �� 5      $��Roles de usuario��6   $
��Left=�6/   $��233,-88,0,0q�6J   $	��Top=�6_   $��36(�6w   ���	#FFFBFBFB$	��293��6�   $
��Bold"�6�   5      �� 5   
   $��	0,124,0,0q�6   .+�5      �� -   5          ��Name$  btn_buscar_cli_rol��5      $��Buscar��61   $
��Left=�6B   $��405,28,0,-7q�6]   $	��Top=�6r   $��95��6�   $��31��6�   ���	#FF007BFF
�������$��18(�6�   $
��Bold"�6�   ��6�   Z� 6  �� 5      -   5         ��Name$ txt_buscar_rol��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Buscar usuario��6.   $
��Left=�6^   $��29��6y   $��112,-21,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��275��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgvRoles��5         AutoGenerateColumns .  $
��Left=�6E   $	��345��6`   $��
112,30,0,0q�6m   $	��Top=�6�   $	��753��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType	 �� Property
 �� Value��%�   '        7 �� 5      8   "  6U   .�5      �� 	 � ��
 �	#FF0071CA67   �� 5      	 � ��

 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
ID_PERSONA+  5      $	 RUT��68    6E   �� *RUT+  5      $ NOMBRE��68    6H   �� *NOMBRE+  5      $ CORREO��68    6H   �� *MAIL+  5      $	 ROL��68    6E   �� *ID_ASIGNADO+5!      �� 5"      -   5         ��Name$ cb_roles��5"      $
��Left=�6)   $��549,-402,0,0q�6D   $	��Top=�6Z   $	��316��6r   $��29��6~   6�   �� 5#      -   5        $  btn_guardar_rol��5#      $��Guardar��6.   $
��Left=�6@   $��341,19,0,-7q�6[   $	��Top=�6p   $	��115��6�   $��38��6�   ���	#FF28A745
�������$��14(�6�   $
��Bold"�6�   ��6�   Z� 6  �� 5$      -   5        $ 
txt_id_rol��5$      $ Ingresa un ID de Rol��6*   $��34��6`   $��226,-29,634,0q�6l   �� 5%      -   5        $ txt_id_rol_user��5%      $ Ingresa un ID��6/   $��34��6^   $��112,-33,749,0q�6j   �� 5&      -   5        $  btn_editar_rol��5&      $��Editar��6-   $��38��6>   $��478,-37,354,0q�6J   
����������	#FFFFC107$��14(�6�   $
��Bold"�6�   ��6a   Z� 6�   �� 5'      -	   5        $  btn_nuevo_rol��5'      $��38��6,   $��	Nuevo Rol��68   
����������	#FF007BFF$��14(�6�   $
��Bold"�6�   $��758,-37,85,0q�6�   ��6L   Z� 6�   �� 5(      -
   5        $��
Actualizar��5(      $��38��6*   $��620,-40,220,0q�66   $��14(�6M   $
��Bold"�6[   
����������	#FF07A8B0��6m   Z� 6�   5)      5,      5-      