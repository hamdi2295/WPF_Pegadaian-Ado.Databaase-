   M S B A M L   `   `   `  ����H  DWpf_Pegadaian, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Wpf_Pegadaian.FormsWpf_Pegadaian.Forms  5   	   %    Wpf_Pegadaian.Forms.list_barang   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Wpf_Pegadaian.Forms     5   	     � Title$  list_barang��5   	   $��439.382��6   $��1108.456��6.    � WindowStartupLocation$ CenterScreen=�6?   .��5	      � $��0,0,2,0q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF086C08��6    � Offset$ 0Q�61   � 5      $ 	#FF64FF2A��6   $ 1Q�61   5      .+�5   
   �� $��	0,0,500,0q�6   .@�5      �� $��Data Handphone��6   .��5      � .+�5      ]� $��-3,0,0,0q�6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridHandphone��5   ?      AutoGenerateColumns .  $	��603��6Z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   "   ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��65   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *ID+  5   "   $	 BRAND��65   
 6D   �� *BRAND+  5   "   $
	 TYPE��65   
 6C   �� *TYPE+  5   "   $	 YEARS OF BUY��65   
 6K   �� *YEARS OF BUY+  5   "   $	 SELLING PRICE��65   
 6L   �� *SELLING_PRICE+  5   "   $	 	CONDITION��65   
 6H   �� *	CONDITION+  5   "   $	 PICTURE��65   
 6F   �� *	PICTURE+  5   "   $	 TRANSACTION ID��65   
 6M   �� *TRANSACTION_ID+4  .System.Windows.Controls.DataGridTemplateColumn  5   "      HeaderTemplate 5   &   �� 5    *   .R�5!   .   �� $��Action��68   5"   +      CellTemplate 5$   &   �� 5%   *   .R�5&   .   ��  �� Orientation$ 
Horizontal=�69   .+�5'   2   ��  ��Name$ deletehpBtn��69   $��Delete��6N   5(   /   5)   +   5+   #   5-      5.      ]� 50      52      53      54      57      �� 58   
   -   5         ��Name$ label��58      $��BRAND��6   $
��Left=�6/   $��
631,39,0,0q�6J   $	��Top=�6^   $	��178��6v   $��31��6�   $��Modern No. 20)�6�   $��14.667(�6�   �� 59   
   -   5        $ 
label_Copy��59      $��TRANSACTION ID��6$   $
��Left=�6=   $��631,292,0,0q�6X   $	��Top=�6m   $��34��6�   $	��171��6�   $��Modern No. 20)�6�   $��14.667(�6�   �� 5:   
   -   5        $ label_Copy1��5:      $��PICTURE��6%   $
��Left=�67   $��631,250,0,0q�6R   $	��Top=�6g   $��34��6   $	��176��6�   $��Modern No. 20)�6�   $��14.667(�6�   �� 5;   
   -   5        $ label_Copy2��5;      $��	CONDITION��6%   $
��Left=�69   $��631,206,0,0q�6T   $	��Top=�6i   $��34��6�   $	��171��6�   $��Modern No. 20)�6�   $��14.667(�6�   �� 5<   
   -   5        $ label_Copy3��5<      $��SELLING PRICE��6%   $
��Left=�6=   $��631,164,0,0q�6X   $	��Top=�6m   $��34��6�   $	��173��6�   $��Modern No. 20)�6�   $��14.667(�6�   �� 5=   
   -   5        $ label_Copy4��5=      $��YEARS OF BUY��6%   $
��Left=�6<   $��631,121,0,0q�6W   $	��Top=�6l   $��34��6�   $	��173��6�   $��Modern No. 20)�6�   $��14.667(�6�   �� 5>   
   -   5        $ label_Copy5��5>      $
��TYPE��6%   $
��Left=�64   $��
631,80,0,0q�6O   $	��Top=�6c   $��34��6{   $	��178��6�   $��Modern No. 20)�6�   $��14.667(�6�   �� 5?   
   -	   5         ��Name$ textBox��5?      $
��Left=�6#   $��34��6>   $��807,292,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $	��172��6�   �� 5@   
   -
   5        $ textBox_Copy��5@      $
��Left=�6(   $��34��6C   $��807,250,0,0q�6O   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��172��6�   �� 5A   
   -   5        $ textBox_Copy1��5A      $
��Left=�6)   $��34��6D   $��807,206,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��172��6�   �� 5B   
   -   5        $ textBox_Copy2��5B      $
��Left=�6)   $��34��6D   $��807,164,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��172��6�   �� 5C   
   -   5        $ textBox_Copy3��5C      $
��Left=�6)   $��34��6D   $��808,121,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��172��6�   �� 5D   
   -   5        $ textBox_Copy4��5D      $
��Left=�6)   $��34��6D   $��
809,80,0,0q�6P   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��172��6�   �� 5E   
   -   5        $ textBox_Copy5��5E      $
��Left=�6)   $��34��6D   $��
809,36,0,0q�6P   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��172��6�   �� 5F   
   -   5        $ HPSAVE��5F      $
��SAVE��6!   $
��Left=�60   $��800,354,0,0q�6K   $	��Top=�6`   $��84��6x   $��33��6�   
����������	#FF5B3838���	#FF134B83$��16(�6�   $
��Bold"�6�   �� 5G   
   -   5        $ HPEDIT��5G      $
��EDIT��6!   $
��Left=�60   $��913,353,0,0q�6K   $	��Top=�6`   $��84��6x   $��33��6�   
����������	#FF5B3838���	#FFDE510F$��16(�6�   $
��Bold"�6�   5J      5K      