   M S B A M L   `   `   `  ����P  LStudentskaSluzbaWPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:StudentskaSluzbaWPFUIStudentskaSluzbaWPFUI  5   	   *    $StudentskaSluzbaWPFUI.PredmetiWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:StudentskaSluzbaWPFUI     5   	     � Title$  PredmetiWindow��5   	   $	��390��6    $	��420��6-   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ MainTab��5
   r   $
��left=�6   $��
10,65,7,25q�60   $��0q�6D   
������ $	��290��6�   $	��290��6�   .@�5      &   System.Windows.Controls.DataGrid  -   5        $��DG��5   t      CanUserAddRows .  $��Center=�6.   $��Center=�6R      AutoGenerateColumns .  $	��280��6�   $	��263��6�   $��Center=�6�      	RowHeight$ 30Q�6�   $	��Top=�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 150 6�   $��
10,-8,13,0q�6
     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width$
 auto 6)      Header$ Naziv Predmeta��66   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6N   �� 
 �� Path$
 NazivPredmeta�  5      $
 auto 6)   $ Ocjena��66   	 6F   �� $
 Ocjena�  5      $
 auto 6)   $ Datum Polaganja��66   	 6O   �� $
 Datum�5      5      �� 5   
   -   5        $��16(�5      $��Dodaj��6   $
��Left=�6/   $��305,129,0,0q�6J   $	��Top=�6_   $��86��6w    J� RenderTransformOrigin$ -0.14,0.724&�6�   $��33��6�   6�   �� 5   
   $��16(�6   $
��Left=�6"   $��	19,23,0,0q�6=   $
��Wrap=�6P   $!��Polozeni predmeti studenta:��6d   $	��Top=�6�   $��25��6�   $	��208��6�   �� 5   
   -   5        $��t1��5   )    �� TextAlignment$
 Left=�6   $��16(�63   $
��Left=�6A   $��
232,23,0,0q�6\   $
��Wrap=�6p   $�� ��6�   $	��Top=�6�   $��30��6�   $	��126��6�   6�   �� 5   
   -   5        $��16(�5      $��Refresh��6   $
��Left=�61   $��305,238,0,0q�6L   $	��Top=�6a   $��86��6y   $ -0.14,0.724&�6�   $��33��6�   6�   5      5      