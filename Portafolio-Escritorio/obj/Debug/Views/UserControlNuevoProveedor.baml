   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      ;    5Portafolio_Escritorio.Views.UserControlNuevoProveedor   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      -   5          >�Name$  uc_proveedor��5      $	��950��5	   T   $	��671��6`   .��5
      � 
�������$��0,0,-114,-47q�6   .+�5   
   �� $��86,32,162,582q�6   .+�5      �� $	��104��6   ���	#FF00BEF26%   �� 5      $��Nuevo Proveedor��6   $
��Left=�6.   $��256,-80,0,0q�6I   $	��Top=�6^   $��36(�6v   $	��299��6�   ���	#FFFDFDFD6�   5      �� 5   
   $��86,166,698,363q�6   .+�5      �� $��Agregar nuevo Proveedor��6   $
��Left=�66   $��	28,10,0,0q�6Q   $	��Top=�6d   $��18(�6|   �� 5      -   5         ��Name$ txt_nombre_prov��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre��6/   $
��Left=�6W   $��23��6r   $��	15,18,0,0q�6~    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��247��6�   �� 5      -   5        $ txt_prov_razon��5      $ Razon Social��6.   $
��Left=�6\   $��23��6w   $��	15,15,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��247��6�   �� 5      -   5         ��Name$ btn_nuevo_prov��5      $��Guardar��6-   $
��Left=�6?   $��	14,13,0,0q�6Z   $	��Top=�6m   $	��247��6�   $��36��6�   ���	#FF007BFF���	#FFF9F9F9$��20(�6�   $
��Bold"�6  ��6�   Z� 6  �� 5      $	��185��6   $��
0,-170,0,0q�6%   ���	#FF00BEF269   5      �� 5   
   $��393,166,162,78q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dg_prov��5         AutoGenerateColumns .  $
��Left=�6D   $	��422��6_   $��	10,50,0,0q�6l   $	��Top=�6   $	��489��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn	 �� 
TargetType
 �� Property �� Value��%�   '        7 �� 5      8   "	  6U   .�5      �� 
 � �� �	#FF0071CA67   �� 5      
 � ��
 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	ID_PROV+  5!      $ NOMBRE��68    6H   �� *NOMBRE+  5"      $ RAZÓN SOCIAL��68    6N   �� *RAZON_SOCIAL+5$      �� 5&      -   5        $ txt_buscar_prov��5&      $ Ingrese un nombre��6/   $
��Left=�6b   $��34��6}   $��10,-473,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��338��6�   �� 5'      -   5        $ btn_buscar_prov��5'      $��Buscar��6.   $
��Left=�6?   $��368,-476,0,0q�6Z   $	��Top=�6p   $	��131��6�   ���	#FF007BFF$��20(�6�   ���	#FFFFFDFD$��37��6�   $
��Bold"�6�   ��6�   Z� 6  5)      �� 5*   
   $��86,375,698,78q�6   .+�5+      �� $	��261��6   ���	#FF00BEF26%   �� 5,      $��Editar-Elimiar-Actualizar��6   $��40,-479,38,0q�68   $��Center=�6N   $��34��6k   $��18(�6w   $	��202��6�   �� 5-      -   5        $ txt_id_prov��5-      $ Ingrese un ID��6,   $
��Left=�6[   $��34��6v   $��19,-202,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��247��6�   �� 5.      -	   5        $ btn_editar_prov��5.      $��Editar��6.   $
��Left=�6?   $��19,-103,0,0q�6Z   $	��Top=�6o   $	��247��6�   ���	#FFFFC107$��20(�6�   
�������$��36��6�   $
��Bold"�6�   ��6�   Z� 6   �� 5/      -
   5        $ btn_eliminar_prov��5/      $��Eliminar��60   $
��Left=�6C   $��
19,-54,0,0q�6^   $	��Top=�6r   $	��247��6�   ���	#FFDC3545$��20(�6�   
�������$��36��6�   $
��Bold"�6�   ��6�   Z� 6  �� 50      -   5        $ btn_refresh_prov��50      $��	Refrescar��60   $
��Left=�6D   $��19,-151,0,0q�6_   $	��Top=�6t   $	��247��6�   ���	#FF17A2B8$��20(�6�   
�������$��36��6�   $
��Bold"�6�   ��6�   Z� 6  51      52      53      