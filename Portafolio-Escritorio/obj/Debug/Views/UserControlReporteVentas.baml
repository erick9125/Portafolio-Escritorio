   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      :    4Portafolio_Escritorio.Views.UserControlReporteVentas   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��671��6C   .��5
      � 
�������.+�5   
   �� $��111,68,55,463q�6   .+�5      �� $	��132��6     J� RenderTransformOrigin$  0.5,0.5&�6%   
���   ����	#FF01A9C16T   �� 5      $��Reporte Ventas��6   $��266,-135,202,0q�6-   $��61��6E   $��Center=�6Q   $��36(�6n   $
��Bold"�6|   $	��316��6�   
�������6�   5      �� 5   
   $��111,213,55,145q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dg_ventas��5         AutoGenerateColumns .  $	��311��6F    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   '        7 �� 5      8   "  6Q   .�5      ��  � �� �	#FF0071CA63   �� 5       � ��
 �����63   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��68   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   �� *
ID_VENTA+  5      $	 
MONTO PAGO��68   
 6L   �� *
MONTO_PAGO+  5      $	 VUELTO��68   
 6H   �� *MONTO_VUELTO+  5      $	 TOTAL��68   
 6G   �� *MONTO_TOTAL+  5      $	 FECHA DE VENTA��68   
 6P   �� *FECHA_VENTA+ �� StringFormat$ 
dd-MM-yyyy��  5      $	 MEDIO DE PAGO��68   
 6O   �� *DESCRIPCION+5      5       �� 5!   
   $��111,531,55,29q�6   .+�5"      �� $��88��6   
���   �$��0,2,0,0q�63   �� 5#      $��EXPORTAR A :��6   $��10,-97,624,0q�6+   $��32��6A   $��20(�6M   �� 5$      -   5         ��Name$ btn_word_ventas��5$      
����������	#FF007BFF$��294,-97,347,0q�6Y   $��50��6p   $��16(�6|   $
��Bold"�6�   .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ FileWord=�6*   $��Center=�6:   
�������$��30��6h   $��30��6s   5&      �� 5'      -   5        $ btn_excel_ventas��5'      
����������	#FF28A745$��447,-97,193,0q�6q   $��50��6�   $��16(�6�   $
��Bold"�6�   ��6C   Z� .��5(        $ 	FileExcel=�6*   $��Center=�6;   
�������$��30��6i   $��30��6t   5)      �� 5*      -   5        $ btn_pdf_ventas��5*      
����������	#FFDC3545$��603,-97,38,0q�6o   $��52��6�   $��16(�6�   $
��Bold"�6�   ��6.   Z� .��5+        $ FilePdf=�6*   $��Center=�69   
�������$��30��6g   $��30��6r   5,      5-      5.      5/      