   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      :    4Portafolio_Escritorio.Views.UserControlReporteDeudas   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��668��6C   .��5
      � 
�������.+�5   
   �� $��111,68,55,463q�6   .+�5      �� $	��132��6     J� RenderTransformOrigin$  0.5,0.5&�6%   
���   ����	#FF018ABD6T   �� 5      $��Reporte Deudas��6   $��250,-135,245,0q�6-   $��61��6E   $��Center=�6Q   $��36(�6n   $
��Bold"�6|   $	��289��6�   
�������6�   5      �� 5   
   $��111,224,55,124q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgv_reporte_deuda��5         AutoGenerateColumns .  $	��321��6N   $��0,-2,0,0q�6[    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � �� �	#FF0071CA67   �� 5       � ��
 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��68   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   �� *
ID_PERSONA+  5      $		 RUT��68   
 6E   �� *RUT+  5      $	 NOMBRE��68   
 6H   �� *NOMBRE+  5      $	 CORREO��68   
 6H   �� *MAIL+  5      $	 FECHA DEUDA��68   
 6M   �� *FECHA_DEUDA+ �� StringFormat$ 
dd-MM-yyyy��  5      $	 MONTO��68   
 6G   �� *MONTO_DEUDA+5       5!      �� 5"   
   $��	0,544,0,0q�6   .+�5#      �� $��88��6   $��
112,7,55,0q�6$   ���	#FF018ABD68   �� 5$      $��EXPORTAR A :��6   $��134,-93,622,0q�6+   $��37��6B   $��20(�6N   �� 5%      -   5         ��Name$ btn_word_deuda��5%      $��54��6.   $��357,-97,450,0q�6:   $��16(�6Q   $
��Bold"�6_   
����������	#FF007BFF��6�   Z� .��5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ FileWord=�6*   $��Center=�6:   
�������$��30��6h   $��30��6s   5'      �� 5(      -   5        $ btn_excel_deuda��5(      $��54��6/   $��539,-97,268,0q�6;   
�������$��16(�6e   $
��Bold"�6s   ���	#FF28A745��6�   Z� .��5)        $ 	FileExcel=�6*   $��Center=�6;   
�������$��30��6i   $��30��6t   5*      �� 5+      -   5        $ btn_pdf_deuda��5+      $��54��6-   $��708,-94,99,0q�69   
�������$��16(�6b   $
��Bold"�6p   ���	#FFDC3545��6�   Z� .��5,        $ FilePdf=�6*   $��Center=�69   
�������$��30��6g   $��30��6r   5-      5.      5/      50      