   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      9    3Portafolio_Escritorio.Views.UserControlReporteStock   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��671��6C   
�������.��5
      � .+�5   
   �� $��111,68,55,463q�6   .+�5      �� $	��132��6     J� RenderTransformOrigin$  0.5,0.5&�6%   
���   ����	#FF0045816T   �� 5      $��Reporte Stock��6   $��285,-135,245,0q�6,   $��61��6D   $��Center=�6P   $��36(�6m   $
��Bold"�6{   $	��254��6�   
�������6�   5      �� 5   
   $��111,213,55,149q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgv_reporte_stock��5         AutoGenerateColumns .  $	��309��6N    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � �� �	#FF0071CA67   �� 5       � ��
 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��68   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   �� *
ID_PRODU+  5      $	 PRODUCTO��68   
 6J   �� *DESCRIPCION+  5      $	 CANTIDAD DISPONIBLE��68   
 6U   �� *STOCK+  5      $	 FECHA VENCIMIENTO��68   
 6S   �� *FECHA_VENCIMIENTO+ �� StringFormat$ 
dd-MM-yyyy��5      5      �� 5   
   $��111,538,55,36q�6   .+�5       �� $��88��6   ���	#FF0045816$   �� 5!      $��EXPORTAR A :��6   $��10,-97,503,0q�6+   $��35��6A   $��20(�6M   �� 5"      -   5         ��Name$ btn_word_stock��5"      $��51��6.   $��305,-97,335,0q�6:   $��16(�6Q   $
��Bold"�6_   ���	#FF007BFF
���������6�   Z� .��5#      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ FileWord=�6*   $��Center=�6:   
�������$��30��6h   $��30��6s   5$      �� 5%      -   5        $ btn_stock_excel��5%      $��462,-96,179,0q�6/   $��50��6F   $��16(�6R   $
��Bold"�6`   ���	#FF28A745
���������6�   Z� .��5&        $ 	FileExcel=�6*   $��Center=�6;   
�������$��30��6i   $��30��6t   5'      �� 5(      -   5        $ btn_pdf_stock��5(      $��621,-97,24,0q�6-   $��50��6C   $��16(�6O   $
��Bold"�6]   
����������	#FFDC3545��6o   Z� .��5)        $ FilePdf=�6*   $��Center=�69   
�������$��30��6g   $��30��6r   5*      5+      5,      5-      