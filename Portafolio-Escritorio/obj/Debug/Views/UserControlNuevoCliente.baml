   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      9    3Portafolio_Escritorio.Views.UserControlNuevoCliente   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      -   5          >�Name$  
uc_cliente��5      $	��950��5   H   $	��671��6T   .��5	      � 
�������$��0,0,-114,-47q�6   .+�5
   
   �� $��39,42,153,365q�6   .+�5      �� $	��105��6   ���	#FF00BDF16%   �� 5      $��Usuarios��6   $
��Left=�6'   $��365,-87,0,0q�6B   $	��Top=�6W   $��36(�6o   ���	#FFFDF7F7$	��214��6�   5      �� 5   
   $��39,158,693,307q�6   .+�5      �� $��Datos de usuario��6   $
��Left=�6/   $��	79,-1,0,0q�6J   $	��Top=�6]   $��18(�6u   �� 5      -   5         ��Name$ txt_rut_cli��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Rut��6+   $
��Left=�6P   $��23��6k   $��	31,18,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��276��6�   �� 5      -   5        $ txt_nombre_cli��5      $ Nombre��6.   $
��Left=�6V   $��23��6q   $��	30,15,0,0q�6}   $
 Wrap=�6�   $	��Top=�6�   $	��276��6�   �� 5      -   5        $ txt_correo_cli��5      $ Correo��6.   $
��Left=�6V   $��23��6q   $��	30,10,0,0q�6}   $
 Wrap=�6�   $	��Top=�6�   $	��276��6�   �� 5      -   5        $ txt_estado_cli��5      $ Estado��6.   $
��Left=�6V   $��23��6q   $��	30,15,0,0q�6}   $
 Wrap=�6�   $	��Top=�6�   $	��276��6�   6�   �� 5      ���	#FF00BDF1$	��251��6+   $��
0,-182,0,0q�68   5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgNuevoCliente��5         AutoGenerateColumns .  $
��Left=�6M   $	��419��6h   $��389,205,0,0q�6u   $	��Top=�6�   $	��523��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType	 �� Property
 �� Value��%�   '        7 �� 5      8   "  6U   .�5      �� 	 � ��
 �	#FF0071CA67   �� 5      	 � ��

 �����67   5      5         Columns 5       1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
ID_PERSONA+  5"      $	 RUT��68    6E   �� *RUT+  5#      $ NOMBRE��68    6H   �� *NOMBRE+  5$      $ CORREO��68    6H   �� *MAIL+  5%      $ ESTADO��68    6H   �� *ESTADO+5(      �� 5+      -   5        $ 
txt_buscar��5+      $ Ingrese un nombre��6*   $
��Left=�6]   $��28��6x   $��389,-457,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��317��6�   �� 5,      -   5         ��Name$ btn_buscar_cli��5,      $��Buscar��6-   $
��Left=�6>   $��726,-462,0,0q�6Y   $	��Top=�6o   $	��186��6�   ���	#FF007BFF$��20(�6�   ���	#FFFFFDFD$��34��6�   $
��Bold"�6  ��6�   Z� 6  5.      �� 5/   
   $��39,416,693,87q�6   .+�50      �� ���	#FF00BDF1$	��211��6+   �� 51      $ ��Editar-Eliminar-Actualizar��6   $��60,-393,60,0q�69   $��32��6O   $��18(�6[   $��Center=�6i   �� 52      -	   5        $ btn_refrescar��52      $��	Refrescar��6-   $
��Left=�6A   $��34,-141,0,0q�6\   $	��Top=�6q   $	��262��6�   ���	#FF17A2B8$��20(�6�   
�������$��36��6�   $
��Bold"�6�   ��6�   Z� 6  �� 53      -
   5        $ txt_id��53      $ Ingrese un ID��6&   $
��Left=�6U   $��28��6p   $��34,-179,0,0q�6|   $
 Wrap=�6�   $	��Top=�6�   $	��262��6�   �� 54      -   5        $ btn_editar_cli��54      $��Editar��6-   $
��Left=�6>   $��
34,-96,0,0q�6Y   $	��Top=�6m   $	��262��6�   ���	#FFFFC107$��20(�6�   
�������$��36��6�   $
��Bold"�6	  ��6�   Z� 6	  �� 55      -   5        $ btn_eliminar_cli��55      $��Eliminar��6/   $
��Left=�6B   $��
34,-48,0,0q�6]   $	��Top=�6q   $	��262��6�   ���	#FFDC3545$��20(�6�   
�������$��36��6�   $
��Bold"�6  ��6�   Z� 6  56      59      5:      