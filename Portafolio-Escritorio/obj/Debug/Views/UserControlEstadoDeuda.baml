   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      8    2Portafolio_Escritorio.Views.UserControlEstadoDeuda   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��672��6C   
�������.��5
      � .+�5   
   �� $��79,33,55,543q�6   .+�5      �� $	��100��6   ���	#FF01D3F66%   �� 5      $��Deudas��6   $��48(�6%   $��Center=�63   $��	0,-93,0,0q�6P   
�������6c   5      �� 5   
   $��79,134,55,41q�6   .+�5      �� $	��470��6   $��0q�6%   ���	#FF01D3F660   �� 5      $��Buscar Deudor��6   $��Center=�6,   $��24(�6I   $
��Bold"�6W   $��331,-880,266,0q�6i   $��45��6�   $	��219��6�   �� 5      -   5          ��Name$  txt_buscar_deuda��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Rut��60   $��34,-800,516,0q�6U   $��30��6l   �� 5      -   5         ��Name$ btn_buscar_deuda��5      $��Buscar��6/   $��305,-800,38,0q�6@   $��30��6W   
�������$
��Bold"�6v   $��16(�6�   ���	#FF007BFF$	��160��6�   $
��Left=�6�   ��6�   Z� 6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgv_buscar_deuda��5         AutoGenerateColumns .  $	��363��6M   $��34,-392,351,0q�6Z    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property	 �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � ��	 �	#FF0071CA67   �� 5       � ��
	 �����67   5      5      
   Columns
 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
ID_PERSONA+  5      $	 RUT��68    6E   �� *RUT+  5      $ NOMBRE��68    6H   �� *NOMBRE+  5      $ CORREO��68    6H   �� *MAIL+  5       $ FECHA DEUDA��68    6M   �� *FECHA_DEUDA+ �� StringFormat$ 
dd-MM-yyyy��  5!      $ MONTO��68    6G   �� *MONTO_DEUDA+5#      5$      �� 5%   
   $��555,192,0,0q�6   $	��330��6*   $
��Left=�66   $	��Top=�6Q   $	��398��6i   .+�5&      �� $��Notificar Deuda��6   $
��Left=�6.   $��18,6,0,5q�6I   $	��Top=�6[   $��18(�6s   $	��180��6�   �� 5'      -   5        $  	txt_email��5'      $ Email��6)   $
��Left=�6P   $��23��6k   $��	15,-2,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��247��6�   �� 5(      -   5        $  
txt_asunto��5(      $ Asunto��6*   $
��Left=�6R   $��23��6m   $��
15,11,0,20q�6y   $
 Wrap=�6�   $	��Top=�6�   $	��247��6�   $��Deuda Almacen Yuyitos��6�   �� 5)      -   5        $  
txtMensaje��5)      $	��231��6*   $
 Wrap=�67   $����Estimado cliente, de acuerdo a nuestros registros usted registras deudas. Favor de acercase a nuestro local para regulaizar situación. Saludos cordiales, Almacen Yuyitos��6K   $��Center=�6�   $	��296��6  �� 5*      -   5        $ btn_enviar_email��5*      $��Enviar��6/   $��74,8,97,-39q�6@   $��73��6U   $��32��6`   ���	#FF007BFF���	#FFF9F9F9$��14(�6�   $
��Bold"�6�   $��Bottom=�6�   $��Center=�6  ��6�   Z� 6  �� 5+      $	��395��6   $��0,-350,2,-1q�6%   ���	#FF00BEF2$	��325��6M   5-      5/      50      