   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5      ?    9Portafolio_Escritorio.Views.UserControlReporteProveedores   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5local)clr-namespace:Portafolio_Escritorio.Views  5      $	��950��5	   7   $	��671��6C   .��5
      � 
�������.+�5   
   �� $��111,68,55,463q�6   .+�5      �� $	��132��6     J� RenderTransformOrigin$  0.5,0.5&�6%   ���	#FF97CBDC6E   �� 5      $��Reporte Proveedores��6   $��212,-135,202,0q�62   $��61��6J   $��Center=�6V   $��36(�6s   $
��Bold"�6�   $	��370��6�   
�������6�   5      �� 5   
   $��111,213,55,134q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgv_reporte_prov��5         AutoGenerateColumns .  $	��323��6M    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   '        7 �� 5      8   "  6U   .�5      ��  � �� �	#FF0071CA67   �� 5       � ��
 �����67   5      5         Columns 5      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��68   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   �� *	ID_PROV+  5      $	 NOMBRE��68   
 6H   �� *NOMBRE+  5      $	 RAZÓN SOCIAL��68   
 6N   �� *RAZON_SOCIAL+5      5      �� 5   
   $��111,542,55,33q�6   .+�5       �� $��88��6   ���	#FF97CBDC6$   �� 5!      $��EXPORTAR A :��6   $��10,-97,503,0q�6+   $��36��6A   $��20(�6M   �� 5"      -   5         ��Name$ btn_word_prov��5"      $��283,-97,357,0q�6-   $��54��6D   $��16(�6P   $
��Bold"�6^   
����������	#FF007BFF��6p   Z� .��5#      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ FileWord=�6*   $��Center=�6:   
�������$��30��6h   $��30��6s   5$      �� 5%      -   5        $ btn_excel_prov��5%      $��446,-97,195,0q�6.   $��50��6E   
����������	#FF28A745$��16(�6�   $
��Bold"�6�   ��6Q   Z� .��5&        $ 	FileExcel=�6*   $��Center=�6;   
�������$��30��6i   $��30��6t   5'      �� 5(      -   5        $ btn_pdf_prov��5(      $��606,-97,36,0q�6,   $��50��6B   
����������	#FFDC3545$��16(�6�   $
��Bold"�6�   ��6N   Z� .��5)        $ FilePdf=�6*   $��Center=�69   
�������$��30��6g   $��30��6r   5*      5,      5-      5.      