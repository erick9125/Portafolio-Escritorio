   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      :    4Portafolio_Escritorio.Views.UserControlAsignarPrecio   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��674��6C   
�������.��5
      � .+�5   
   �� $��80,48,83,531q�6   .+�5      �� $��95��6   ���	#FF00A0EC6$   �� 5      $��Asignar Precio��6   ���	#FFFBF9F9$��275,-98,275,0q�6D   $��Center=�6[   $��36(�6x   $��57��6�   5      �� 5   
   $��80,161,83,44q�6   .+�5      �� $	��467��6   ���	#FF00A0EC6%   &   System.Windows.Controls.DataGrid  5      -   5           Name$  dg_asignar_prec��5         AutoGenerateColumns .  $��31,-692,34,0q�6L   $	��204��6b    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � �� �	#FF0071CA67   �� 5       � ��
 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6D   �� *
ID_PRODU+  5      $ DESCRIPCIÓN��68   	 6M   �� *DESCRIPCION+  5      $ PRECIO��68   	 6H   �� *PRECIO+  5      $ FECHA INICIO��68   	 6O   �� *FECHA_INICIO+
 �� StringFormat$
 
dd-MM-yyyy��  5      $ FECHA TERMINO��68   	 6O   �� *FECHA_TERMINO+$
 
dd-MM-yyyy��5      �� 5       $��31,-253,393,0q�6   $	��202��6/   ���	#FF00A0EC6<   �� 5!      $��Precio��6   $��43,-419,411,0q�6%   $��27��6<   �� 5"      -   5         ��Name$ 
txt_precio��5"      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ingrese un precio��6*   $��43,-358,411,0q�6]   $��32��6t   �� 5#      $��Fecha Inicio��6   $��43,-295,411,0q�6+   $��29��6B   (  "System.Windows.Controls.DatePicker  5$      -   5          Name$ 
dp_fec_ini��5$      $��43,-230,411,0q�6-   $��32��6D   �� 5%      $��Fecha Termino��6   $��43,-170,411,0q�6,   $��27��6C     5&      -   5        $ dp_fec_term��5&      $��43,-109,411,0q�6.   $��32��6E   5'      �� 5(   
   $��480,402,118,68q�6    J� RenderTransformOrigin$ 0.5,0.5&�6-   .+�5)      �� $	��200��6   ���	#FF00A0EC6%   �� 5*      -   5        $ txt_id_prod_asig��5*      $ ID Producto��60   $��10,-302,181,0q�6]   $��32��6t   �� 5+      -   5         ��Name$ btn_registrar_prec��5+      $��	Registrar��61   $��10,-211,10,0q�6E   $��32��6[   ���	#FF28A745
�������$��18(�6�   $
��Bold"�6�   ��6~   Z� 6�   �� 5,      -   5        $ btn_editar_prec��5,      $��Editar��6.   $��10,-127,181,0q�6?   $��32��6V   ���	#FFFFC107
�������$��18(�6�   $
��Bold"�6�   ��6y   Z� 6�   �� 5-      -   5        $ btn_eliminar_prec��5-      $��Eliminar��61   $��184,-128,10,0q�6D   $��32��6[   ���	#FFFBFBFB���	#FFDC3545$��18(�6�   $
��Bold"�6�   ��6~   Z� 6�   �� 5.      -	   5        $ btn_refrescar��5.      $��32��6,   $��184,-300,14,0q�68   ���	#FF17A2B8
���������6O   Z� .��5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Update=�6*   50      �� 51      -
   5        $ btn_nuevo_medio_p��51      $��32��60   $��Nuevo Medio de pago��6<   $��10,-46,10,0q�6Z   
�������$��18(�6�   $
��Bold"�6�   ���	#FF007BFF��6o   Z� 6�   52      54      55      