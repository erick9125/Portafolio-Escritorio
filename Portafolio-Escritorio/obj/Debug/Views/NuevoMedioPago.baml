   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5   	   0    *Portafolio_Escritorio.Views.NuevoMedioPago   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5local)clr-namespace:Portafolio_Escritorio.Views  5   	     � Title$  NuevoMedioPago��5	   	   $	��385��6    $	��475��6-    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ NoResize=�6^    � WindowStyle$
 None=�6t   ���	#FFCEEFFF.��5
      � .+�5   
   �� $��32,10,35,306q�6   .+�5      �� $��69��6   ���	#FF014DAD6$   �� 5      $#��Registrar nuevo medio de pago��6   
�������$��Center=�6O   $��67,-67,53,0q�6l   $��40��6�   $��20(�6�   $	��288��6�   5      �� 5   
   $��32,84,35,10q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dg_medio_pago��5         AutoGenerateColumns .  $	��134��6J   $��	32,0,35,0q�6W    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType	 �� Property
 �� Value��%�   '        7 �� 5      8   "  6U   .�5      �� 	 � ��
 �	#FF0071CA67   �� 5      	 � ��

 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	ID_PAGO+  5      $ NOMBRE��68    6H   �� *DESCRIPCION+5      �� 5      -   5         ��Name$ txt_nuevo_mediop��5      $��
32,11,35,0q�60   $��25��6D   �� 5      -   5        $ txt_id_mediop��5      $��32,10,275,0q�6-   $��25��6B   {�.  6N   �� 5      -   5         ��Name$ btn_registrar_pago��5      $��	Registrar��61   $��25��6E   $��151,-26,157,0q�6Q   $��14(�6h   $
��Bold"�6v   
����������	#FF2AA53D��6�   Z� 6�   �� 5       -   5        $ btn_actualizar_pago��5       $��
Actualizar��62   $��25��6G   $��273,-24,35,0q�6S   
�������$��14(�6�   $
��Bold"�6�   ���	#FF05A4A8��6|   Z� 6�   �� 5!      -   5        $ btn_edit_mediop��5!      $
��Edit��6.   $��25��6=   
�������$��32,9,0,0q�6s   ���	#FFFFBF04$��14(�6�   $
��Bold"�6�   $
��Left=�6�   $	��161��6�   ��6\   Z� 6�   �� 5"      -   5        $ btn_eliminar_mediop��5"      $��Eliminar��62   $��25��6E   
����������	#FFDC3644$��213,-23,35,0q�6�   $��14(�6�   $
��Bold"�6�   ��6d   Z� 6�   �� 5#      -   5        $ btn_volver_mediop��5#      $��25��60   
����������	#FF017AFD$��	32,9,35,0q�6}   ��6O   Z� .��5$      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ExitToApp=�6*   5%      5&      5'      5(      