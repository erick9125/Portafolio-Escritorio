   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Portafolio_Escritorio.ViewsPortafolio_Escritorio.Views  5   	   '    !Portafolio_Escritorio.Views.menu3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5local)clr-namespace:Portafolio_Escritorio.Views  5   	     � Title$  menu3��5	   	   $	��700��6   $
��1200��6$    � WindowStyle$
 None=�61    � 
ResizeMode$ NoResize=�6D    � WindowStartupLocation$ CenterScreen=�6Z   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��Stretch=�65   $��2��6S   .��5      � .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5      '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6.   	   	StaysOpen	 .  $��10q�6i   
   PopupContent.
 5      �� $	��150��6%   .+�5      �� -   5         ��Name$ btn_manuales��5   %   $��Manuales��6;   6N   �� 5      -   5        $ 	btn_ayuda��5   %   $��Ayuda��68   6H   �� 5      -   5        $ btn_minimizar��5   %   $��	Minimizar��6<   6P   �� 5      �� 5      -   5        $ 
btn_logout��5   %   $��Cerrar Sesión��69   6Q   5      5      5       �� 5!      $��Center=�6   $��Center=�69   $��22(�6T   
�������Sistema de gestión Yuyitos6�   5"      5#      � 5$   
   $��Stretch=�6   $��1��6-   #��� ��6:    5%      �� 5&      $
��119* �6#   �� 5'      $��6* �6#    5)      �� 5*      $��70 �6    �� 5+      $
��326* �6    .+�5-      � $��0��6   
�������$��2��68   .+�5.      �� $��/Assets/logo.PNG��6   $
��Fill=�62   5/      �� 50      $��Stretch=�6   $��Disabled=�69   $
��Auto=�6b   $��1��6�   $��2��6�   .��51      �� -   5         ��Name$ Menu3��51      $��10q�6,   52      53      �� 54   
   -   5        $ StackPanelMain��54      $��1��6-   $��1��6:   $��Stretch=�6J   .+�55      �� $��/Assets/logo.PNG��6   $	��309��6.   $��268,202,282,0q�6;   56      58      59      