   M S B A M L   `   `   `  ����H  DWpf_Pegadaian, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Wpf_PegadaianWpf_Pegadaian  5   	   #    Wpf_Pegadaian.list_logammulia   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Wpf_Pegadaian     5   	     � Title$  list_logammulia��5   	   $��398.162��6!   $��893.382��62   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FF2C4E1F��6    � Offset$ 1Q�61   � 5      $ 	#FF40D105��6   5      .+�5   
   �� $��	505,0,0,0q�6   .@�5      �� $��Data Logam Mulia��6   .��5      � .+�5      ]� $��-3,0,0,0q�6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridMetal��5   ?      AutoGenerateColumns .  $	��374��6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   "   ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��65   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *ID+  5   "   $	 WEIGHT��65   
 6E   �� *WEIGHT+  5   "   $	 AMOUNT��65   
 6E   �� *AMOUNT+  5   "   $	 PICTURE��65   
 6F   �� *	PICTURE+  5   "   $	 TRANSACTION ID��65   
 6M   �� *TRANSACTION_ID+4  .System.Windows.Controls.DataGridTemplateColumn  5   "      HeaderTemplate 5   &   �� 5   *   .R�5   .   �� $��Action��68   5   +      CellTemplate 5!   &   �� 5"   *   .R�5#   .   ��  �� Orientation$ 
Horizontal=�69   .+�5$   2   ��  ��Name$ deletelogamBtn��69   $��Delete��6Q   5%   /   5&   +   5(   #   5*      5+      ]� 5-      $��0,0,39,0q�6    5/      50      51      54      �� 55   
   -   5         ��Name$ label��55      $��WEIGHT��6   $
��Left=�60   $��	90,81,0,0q�6K   $	��Top=�6^   $��13.333(�6v   $	��110��6�   $��36��6�   �� 56   
   -   5        $ 
label_Copy��56      $��AMOUNT��6$   $
��Left=�65   $��
90,129,0,0q�6P   $	��Top=�6d   $��13.333(�6|   $��36��6�   $	��110��6�   �� 57   
   -   5        $ label_Copy1��57      $��PICTURE��6%   $
��Left=�67   $��
90,177,0,0q�6R   $	��Top=�6f   $��13.333(�6~   $��36��6�   $	��110��6�   �� 58   
   -   5        $ label_Copy2��58      $��TRANSACTION ID��6%   $
��Left=�6>   $��
90,226,0,0q�6Y   $	��Top=�6m   $��13.333(�6�   $��36��6�   �� 59   
   -   5         ��Name$ textBox��59      $
��Left=�6#   $��36��6>   $��
216,81,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��201��6�   �� 5:   
   -   5        $ textBox_Copy��5:      $
��Left=�6(   $��36��6C   $��
216,81,0,0q�6O   $
 Wrap=�6c   $��TextBox��6w   $	��Top=�6�   $	��201��6�   �� 5;   
   -   5        $ textBox_Copy1��5;      $
��Left=�6)   $��36��6D   $��216,226,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��201��6�   �� 5<   
   -	   5        $ textBox_Copy2��5<      $
��Left=�6)   $��36��6D   $��216,177,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��201��6�   �� 5=   
   -
   5        $ textBox_Copy3��5=      $
��Left=�6)   $��36��6D   $��216,129,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��201��6�   �� 5>   
   -   5        $ button��5>      $
��SAVE��6!   $
��Left=�60   $��35��6K   $��144,309,0,0q�6W   $	��Top=�6l   $��89��6�   ���	#FFF3BABA$��16(�6�   $
��Bold"�6�   
����������	#FF0449AC6�   �� 5?   
   -   5        $ button_Copy��5?      $
��EDIT��6&   $
��Left=�65   $��35��6P   $��287,309,0,0q�6\   $	��Top=�6q   $��89��6�   ���	#FFF3BABA$��16(�6�   $
��Bold"�6�   
����������	#FFF57B006�   5A      5B      