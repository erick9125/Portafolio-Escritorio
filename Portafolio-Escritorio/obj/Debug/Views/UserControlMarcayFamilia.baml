   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      :    4Portafolio_Escritorio.Views.UserControlMarcayFamilia   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	      $	��670��6   
�������.��5
      � .+�5   
   �� $��77,27,92,540q�6   .+�5      �� $	��102��6   
���   ����	#FF0071CA64   �� 5      $/��)Registrar Marca - Familia - Tipo Producto��6   
�������$��	0,-83,0,0q�6[   $��Center=�6n   $��36(�6�   5      �� 5   
   $��77,135,642,60q�6   .+�5      �� $	��471��6   ���	#FF0071CA6%   &   System.Windows.Controls.DataGrid  5      -   5           Name$  dg_marca��5         AutoGenerateColumns .  $	��184��6E   $��10,-695,10,0q�6R    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � �� �	#FF0071CA67   �� 5       � ��
 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6D   �� *
ID_MARCA+  5      $ DESCRIPCIÓN��68   	 6M   �� *DESCRIPCION+5      �� 5      -   5        
 ��Name$
 	txt_marca��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Descripción��6)   $��10,-459,10,0q�6V   $��29��6l   �� 5      -   5        $
 txt_id_marca��5      $ ID Marca��6,   $��29��6V   $��10,-369,10,0q�6b   {�.  6x   �� 5       -   5         ��Name$ btn_regis_marca��5       $��	Registrar��6.   $��30��6B   $��10,-274,106,0q�6N   
����������	#FF28A745$��18(�6�   $
��Bold"�6�   ��6e   Z� 6�   �� 5!      -   5        $ btn_edit_marca��5!      $��Editar��6-   $��29��6>   $��10,-186,10,0q�6J   
����������	#FFFFC107$��18(�6�   $
��Bold"�6�   ��6`   Z� 6�   �� 5"      -   5        $ btn_elim_marca��5"      $��Eliminar��6-   $��29��6@   $��10,-95,10,0q�6L   
����������	#FFDC3545$��18(�6�   $
��Bold"�6�   ��6a   Z� 6�   �� 5#      $��Marca��6   $��10,-908,0,0q�6$   $
��Left=�69   $��18(�6T   $��34��6b   $��62��6n   �� 5$      -   5        $ btn_actualizar_marca��5$      $��28��63   $��148,-275,10,0q�6?   
����������	#FF17A2B8��6V   Z� .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Update=�6*   5&      5'      �� 5(   
   $��330,135,92,60q�6   .+�5)      �� $	��473��6   ���	#FF0071CA6%   �� 5*      -   5        $ btn_actualizar_familia��5*      $��29��65   $��134,-263,318,0q�6A   ���	#FF17A2B8
���������6p   Z� .��5+        $ Update=�6*   5,      �� 5-      -	   5        $
 txt_id_fami_prod��5-      $ ID Familia Producto��60   $��28��6e   $��10,-369,320,0q�6q   {�.  6�   �� 5.      $��Familia de producto��6   $
��Left=�62   $��10,-915,0,0q�6M   $��32��6b   $��18(�6n   $	��177��6|     5/      -
   5        $  dg_familia_prod��5/       .  $	��185��6L   $��10,-693,318,0q�6Y    J� RenderTransformOrigin$ 0.5,0.5&�6p    50      ��%�   '        7 �� 51      8   "  6U   .�52      ��  � �� �	#FF0071CA67   �� 53       � ��
 �����67   54      55       56        57      $ ID��68   	 6D   �� *
ID_FAMILIA+  58      $ DESCRIPCIÓN��68   	 6M   �� *DESCRIPCION+5<      �� 5=      -   5        $
 txt_fami_prod��5=      $ Descripción��6-   $��10,-454,320,0q�6Z   $��29��6q   �� 5>      -   5        $ btn_regis_fami_prod��5>      $��	Registrar��62   $��30��6F   $��10,-266,418,0q�6R   
����������	#FF28A745$��18(�6�   $
��Bold"�6�   ��6i   Z� 6�   �� 5?      -   5        $ btn_edit_fami_prod��5?      $��Editar��61   $��29��6B   $��10,-183,320,0q�6N   
����������	#FFFFC107$��18(�6�   $
��Bold"�6�   ��6e   Z� 6�   �� 5@      -   5        $ btn_elim_fami_prod��5@      $��Elimar��61   $��29��6B   $��10,-94,320,0q�6N   
����������	#FFDC3545$��18(�6�   $
��Bold"�6�   ��6d   Z� 6�   �� 5A      $��0,-475,83,2q�6   $��20��6-   $ 0.5,0.5&�69   z�5B      V� 5C      .~�5D      ��  �� ScaleY$ -1Q�6)   �� 5E      �� 5F       �� Angle$ -90.182Q�6*   T� 5G      5H      5J      �� 5K      $��Tipo Producto��6   $��34��6,   $��235,-912,137,0q�68   $��18(�6P     5L      -   5        $  dg_tipo_prod��5L       .  $	��187��6I   $��235,-692,10,0q�6V    5M      ��%�   '        7 �� 5N      8   "  6U   .�5O      ��  � �� �	#FF0071CA67   �� 5P       � ��
 �����67   5Q      5R       5S        5T      $ ID��68   	 6D   �� *	ID_TIPO+  5U      $ NOMBRE��68   	 6H   �� *NOMBRE+  5V      $ DESCRIPCIÓN��68   	 6M   �� *DESCRIPCION+  5W      $ 
ID FAMILIA��68   	 6L   �� *FAMILIA_PRODUC_ID_FAMILIA+5Y      �� 5Z      -   5        $
 txt_nomb_tipo��5Z      $ Nombre Tipo Producto��6-   $��29��6c   $��235,-453,10,0q�6o   �� 5[      -   5        $
 txt_descrip_tipo��5[      $  Descripción Tipo Producto��60   $��29��6k   $��235,-367,10,0q�6w   �� 5\      -   5        $
 txt_id_tipo��5\      $ ID Tipo Producto��6+   $��29��6]   $��235,-267,172,0q�6i   {�.  6�   �� 5]      -   5        $
 txt_id_fami��5]      $ ID Familia Producto��6+   $��29��6a   $��381,-267,10,0q�6m   {�.  6�   �� 5^      -   5        $ btn_regis_tipo��5^      $��	Registrar��6-   $��29��6A   $��235,-181,172,0q�6M   
����������	#FF28A745$��18(�6�   $
��Bold"�6�   ��6e   Z� 6�   �� 5_      -   5        $ btn_actualizar_tipo��5_      $��
Actualizar��62   $��29��6G   $��381,-180,10,0q�6S   
����������	#FF17A2B8$��18(�6�   $
��Bold"�6�   ��6j   Z� 6�   �� 5`      -   5        $ btn_edit_tipo��5`      $��Editar��6,   $��29��6=   $��235,-94,172,0q�6I   
����������	#FFFFC107$��18(�6�   $
��Bold"�6�   ��6`   Z� 6�   �� 5a      -   5        $ btn_elim_tipo��5a      $��Eliminar��6,   $��29��6?   $��381,-95,10,0q�6K   
����������	#FFDC3545$��18(�6�   $
��Bold"�6�   ��6a   Z� 6�   5b      5d      5e      