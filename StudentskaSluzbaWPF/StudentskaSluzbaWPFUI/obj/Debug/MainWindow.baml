   M S B A M L   `   `   `  ����P  LStudentskaSluzbaWPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:StudentskaSluzbaWPFUIStudentskaSluzbaWPFUI  5   	   &     StudentskaSluzbaWPFUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:StudentskaSluzbaWPFUI     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ 
MainWindow��5	      $	��450��6   $	��700��6(    � WindowStyle$
 None=�64    � 
ResizeMode$ NoResize=�6G   $��Century Gothic)�5
   	   
�������.��5      � .+�5   
   � $	��Top=�6   $��90��6'    � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $	��500 �6#   �� 5      $��* �6#   .+�5      �� $��1��6   $��0,0,10,0q�6)   .+�5      �� $��Center=�6   $��90��65   $-��'C:\Users\Pc\Desktop\Slike\pi-banner.png��6A   $
��22,0q�6r   5      5      � 5   
   $
��Left=�6   $	��200��6*   ���	#FF345E87 � RowDefinitions 5      �� 5       $	��100 �6    �� 5!      $��59 �6    �� 5$      $	��200 �6    �� 5%      $��50 �6    �� 5&      $��50 �6    .+�5,      ��  �� Orientation$ Vertical=�6   $��2��60   .+�5.      �� -   5        $��40��5.      ���	#FF7A98AA
�������$��0q�6Q   
�������$��0,0,0,5q�6~   .��6�   
Studenti6�   �� 5/      -   5        $��40��5/      ���	#FF7A98AA
�������$��0q�6Q   
�������$��0,0,0,5q�6~   .��6�   
Predmeti6�   �� 50      $��40��6   ���	#FF7A98AA
�������$��0q�6Q   
�������$��0,0,0,5q�6~   .��6�   	Nastava6�   �� 51      $��40��6   ���	#FF7A98AA
�������$��0q�6Q   
�������.��6   Ispiti6�   52      54      �� 55   
   -   5         ��Name$ MainTab��55   y   $��center=�6   $
��Left=�60   $��0q�6K   
������ $��
220,95,0,0q�6�   $	��310��6�   .@�56      &   System.Windows.Controls.DataGrid  -   5        $��DG��56   .      CanUserAddRows .  	   AutoGenerateColumns	 .  $	��288��6T   $	��305��6a   $
��Left=�6m   
   	RowHeight$
 30Q�6�   $��Center=�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 150 6�      Columns 57      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Width$
 auto 6)      Header$ Ime i Prezime��66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   ��  �� Path$ FullName�  5:      $
 auto 6)   $ Username��66    6H   �� $ UserName�4  .System.Windows.Controls.DataGridTemplateColumn  5;      $
 auto 6-   $ Polozeni Predmeti��6:      CellTemplate 5<      �� 5=      .R�5>   "   �� -   5        .��5>   A   	Prikazi6J   5?      5B      5E      5G      �� 5H   
   -   5        $��15(�5H      $��Dodaj Studenta��6   $
��Left=�68   $��550,199,0,0q�6S   $	��Top=�6h   $	��128��6�    J� RenderTransformOrigin$ 2.82,-0.553&�6�   $��36��6�   6�   �� 5I   
   -   5        $��15(�5I      $��Osvijezi��6   $
��Left=�62   $��550,311,0,0q�6M   $	��Top=�6b   $	��128��6z   $��34��6�   6�   �� 5J   
   $
��Bold"�6   $��16(�6&   $
��Left=�64   $��220,104,0,0q�6O   $
��Wrap=�6d   $��Studenti��6x   $	��Top=�6�   5L      5N      