   M S B A M L   `   `   `  ����H  DWpf_Pegadaian, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Wpf_Pegadaian.FormsWpf_Pegadaian.Forms  5   	       Wpf_Pegadaian.Forms.Home   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Wpf_Pegadaian.Forms     5   	     � Title$
  Home��5   	   $	��321��6   $	��873��6#   .��5	      � .+�5
   
   �� -   5        $��	-1,-1,1,1q�5
      .@�5      �� $
��User��6   .��5      � 5      5      �� 5      $��Golds��6   $��23��6%   $��Bottom=�61   .��5      ]� .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $	��256��61   $	��Top=�6>      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *id+  5      $
 Type��61    6?   �� *type+  5      $
 Unit��61    6?   �� *unit+  5      $ Selling Price��61    6H   �� *selling_price+  5      $ Purchase Price��61    6I   �� *purchase_price+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5   "   �� 5   &   .R�5   *   �� $��Action��64   5   '      CellTemplate 5   "   �� 5    &   .R�5!   *   ��  �� Orientation$ 
Horizontal=�65   .+�5"   .   ��  ��Name$ 	insertBtn��65   -   5        $��Insert��5"   H   6Y   �� 5#   .   $ 	updateBtn��65   $��Update��6H   �� 5$   .   $ 	deleteBtn��65   $��Delete��6H   5%   +   5&   '   5(      5*      5+      5,      �� 5-      $��Outlets��6   .��5.      � .+�5/      �� -   5        	 ��Name$	 label5��5/      $��IT��6,   $
��Left=�69   $��	37,26,0,0q�6T   $	��Top=�6g   �� 50      -   5        $	 label6��50      $��ADDRESS��6,   $
��Left=�6>   $��
37,176,0,0q�6Y   $	��Top=�6m   �� 51      -   5        $	 label7��51      $��SUB DISTRICT��6,   $
��Left=�6C   $��
37,146,0,0q�6^   $	��Top=�6r   �� 52      -   5        $	 label8��52      $��REGENCY��6,   $
��Left=�6>   $��
37,116,0,0q�6Y   $	��Top=�6m   �� 53      -   5        $	 label9��53      $��PROVINCE��6,   $
��Left=�6?   $��	37,86,0,0q�6Z   $	��Top=�6m   �� 54      -	   5        $	 labe20��54      $
��NAME��6,   $
��Left=�6;   $��	37,56,0,0q�6V   $	��Top=�6i   56      57      �� 58      $��Instal Type��6   .��59      � 5:      5;      5<      5=      5>      