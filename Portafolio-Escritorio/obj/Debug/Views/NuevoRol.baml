   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5   	   *    $Portafolio_Escritorio.Views.NuevoRol   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5local)clr-namespace:Portafolio_Escritorio.Views  5   	     � Title$  NuevoRol��5	   	   $	��385��6   $	��475��6'    � WindowStyle$
 None=�63    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\   ���	#FF190F0F���	#FFCEEFFF.��5
      � .+�5   
   �� $��23,10,22,313q�6   .+�5      �� $��61��6   ���	#FF009EEA6$   �� 5      $��Agregar nuevo Rol��6   $��Center=�60   $��122,-51,121,0q�6M   
�������$��20(�6w   $
��Bold"�6�   $��42��6�   5      �� 5   
   $��23,78,22,10q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dg_nuevo_rol��5      $	��146��6-   $��	48,0,51,0q�6:    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property	 �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � ��	 �	#FF0071CA67   �� 5       � ��
	 �����67   5      5      
   Columns
 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *ID_ROL+  5      $ NOMBRE��68    6H   �� *RUT+5      �� 5      -   5         ��Name$ txt_nuevo_rol��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ingrese un rol��6-   $��
48,13,51,0q�6]   $��24��6q   �� 5      -   5        $ txt_id_nuevo_rol��5      $ ID rol��60   {�.  $��48,10,297,0q�6j   $��24��6   �� 5      -   5         ��Name$ btn_registrar_rol��5      $��24��60   $��	Registrar��6<   $��150,-24,169,0q�6P   
����������	#FF28A745$��14(�6�   $
��Bold"�6�   ��6z   Z� 6�   �� 5       -   5        $ btn_editar_rol��5       $��25��6-   $��Editar��69   $��
48,9,220,0q�6J   
����������	#FFFFC107$��14(�6�   $
��Bold"�6�   ��6q   Z� 6�   �� 5!      -   5        $ btn_eliminar_rol��5!      $��Eliminar��6/   $��24��6B   $��214,-24,51,0q�6N   
����������	#FFDC3545$��14(�6�   $
��Bold"�6�   ��6d   Z� 6�   �� 5"      -   5        $ btn_volver_rol��5"      $��30��6-   $��	48,6,51,0q�69   
����������	#FF007BFF��6L   Z� .��5#      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ExitToApp=�6*   5$      �� 5%      -   5        $ btn_actualizar_rol��5%      $��
Actualizar��61   $��24��6F   $��278,-165,51,0q�6R   
����������	#FF17A2B8$��14(�6�   $
��Bold"�6�   ��6i   Z� 6�   5&      5'      5(      