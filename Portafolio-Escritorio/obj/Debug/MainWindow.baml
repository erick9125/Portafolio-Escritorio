   M S B A M L   `   `   `  ����P  LPortafolio-Escritorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Portafolio_EscritorioPortafolio_Escritorio  5   	   &     Portafolio_Escritorio.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /local#clr-namespace:Portafolio_Escritorio  5   	     � Title$  Login��5	   	   $	��450��6   $	��800��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F    � WindowStyle$
 None=�6k   .��5
      � .+�5   
   ��  �� RadiusY$ 8��6    �� RadiusX$ 8��6    
�������6,   �� 5   
   $��Assets/principal.jpg��6   $��UniformToFill=�6.   $��	0,0,316,0q�6F   �� 5   
   $��	0,0,316,0q�6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#CC129381��6#   	 � Offset$	 1Q�65   � 5      $ 	#CC464DEA��6#   � 5      $ 	#CC2870B8��6#   $	 0.576Q�65   5      5      �� 5   
   $��489,90,0,50q�6   .+�5      �� $��Login��6   $��Segoe UI Black)�6$   $��24(�6@   $��	8,10,0,10q�6N   $	��Top=�6a   $
��Left=�6y   �� 5      
 �� Orientation$
 
Horizontal=�6   .+�5      �� $
��Left=�6   $	��Top=�67   $
��Wrap=�6O   ���#707070$��14,0,0,0q�6x   $��36��6�   $	��287��6�   �� 6�   $g�aPorfavor ingrese sus credenciales, en caso de no contar con una, contactese con su administrador ��6�   6  5      �� 5      $
��0,15q�6   $
 
Horizontal=�6'   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   $��Center=�69   ���#707070$��9,0,0,0q�6i   �� 5      -   5         ��Name$ txt_user��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$" Usuario (usuario@dominio.cl)��6,   $	��250��6j   $��7,5,5,5q�6v   ��6�   �� *Email+5      �� 5      $
 
Horizontal=�6   .+�5         $	 Key=�6*   $��Center=�65   ���#707070$��10,0,0,0q�6e   G� 5!      -   5         G�Name$ txt_pass��5!      $ Contraseña��60   $	��250��6\   $��5q�6h   5"      � 5#      �� 5$      -   5         ��Name$ Btn_ingresar��5$      $��Center=�6+   $��LOGIN��6H   $��Impact)�6X   $��18(�6l   $	��100��6z   ���	#FF307CD6���	#FF307CD6$��
150,12,0,0q�6�   6�   �� 5%      $
 
Horizontal=�6   $��10,35q�62   5&      �� 5'   
   $��25,50,349,50q�6   .+�5(      �� $��
Bienvenido��6   
�������$��Center=�6=   $��48(�6Z   $��Champagne & Limousines)�6h   $
��Bold"�6�   $��0,46,0,0q�6�   �� 5)      $d��^Este es el sistema de gestión para su almacen que permitirá gestionar sus modulos de negocio��6   
�������$��Center=�6�   $	��359��6�   $��24(�6�   $��Champagne & Limousines)�6�   $
��Wrap=�6�    �� TextAlignment$ Center=�6  $��
35,11,32,0q�6  $	��125��6-  �� 5*      -   5        $ Btn_soporte��5*      $��Center=�6*   $��SOPORTE��6G   $��Impact)�6Y   $��18(�6m   $	��114��6{   ���	#FF4BB497$��226,12,86,0q�6�   $��54��6�   ��6�   Z� 6�   �� 5+      -   5        $ Btn_manuales��5+      $��Center=�6+   $��MANUALES��6H   $��Impact)�6[   $��18(�6o   $	��113��6}   ���	#FF4BB497$��86,-54,227,0q�6�   $��54��6�   ��6�   Z� 6�   5,      �� 5-   
   $��	725,0,0,0q�6   .+�5.      �� -   5        $ Btn_logout_prin��5.      $��Center=�6/   $��40,0,0,0q�6J   $��26��6�   $��Center=�6�   $��35��6�   ��6\   Z� ��6r   Z� ��6�   Z� .��5/        $ Logout=�6+   ���#707070$��19��6N   $��26��6Z   $��-10,0,-11,0q�6e   $��Center=�6z   $��0,0,1,0q�6�   50      52      56      57      