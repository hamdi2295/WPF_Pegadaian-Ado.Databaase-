   M S B A M L   `   `   `  ����H  DWpf_Pegadaian, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Wpf_Pegadaian.FormsWpf_Pegadaian.Forms  5   	   )    #Wpf_Pegadaian.Forms.list_goldsaving   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Wpf_Pegadaian.Forms     5   	     � Title$  list_goldsaving��5   	   $��597.868��6!   $��512.647��62   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF54FF04��6   $ 1Q�61   � 5      $ 	#FF5CA03C��6   5      .+�5   
   �� $��0,362,0,-362q�6   .@�5      �� $��Data Gold Saving��6   .��5      � .+�5      ]� $��-3,0,0,0q�6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridGoldsaving��5   ?      AutoGenerateColumns .  $	��500��6[   $��	0,0,0,354q�6g      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   "   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��65   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *ID+  5   "   $ ACCOUNT NUMBER��65   	 6M   �� *ACCOUNT_NUMBER+  5   "   $ BALANCE��65   	 6F   �� *	BALANCE+  5   "   $ QUANTITY��65   	 6G   �� *
QUANTITY+  5   "   $ PRICE��65   	 6D   �� *PRICE+  5   "   $ TRANSACTION ID��65   	 6M   �� *TRANSACTION_ID+4  .System.Windows.Controls.DataGridTemplateColumn  5   "   
   HeaderTemplate
 5   &   �� 5   *   .R�5    .   �� $��Action��68   5!   +      CellTemplate 5#   &   �� 5$   *   .R�5%   .   ��  �� Orientation$ 
Horizontal=�69   .+�5&   2   ��  ��Name$ deletegoldsavingBtn��69   $��Delete��6V   5'   /   5(   +   5*   #   5,      5-      50      51      54      �� 55   
   -   5         ��Name$ label��55      $��ACCOUNT MEMBER��6   $
��Left=�68   $��	34,58,0,0q�6S   $	��Top=�6f   $	��140��6~   $��40��6�   $��Modern No. 20)�6�   $��13.333(�6�   �� 56   
   -   5        $ 
label_Copy��56      $��TRANSACTION ID��6$   $
��Left=�6=   $��
34,258,0,0q�6X   $	��Top=�6l   $	��140��6�   $��40��6�   $��Modern No. 20)�6�   $��13.333(�6�   �� 57   
   -   5        $ label_Copy1��57      $��PRICE��6%   $
��Left=�65   $��
34,207,0,0q�6P   $	��Top=�6d   $	��145��6|   $��40��6�   $��Modern No. 20)�6�   $��13.333(�6�   �� 58   
   -   5        $ label_Copy2��58      $��QUANTITY��6%   $
��Left=�68   $��
34,158,0,0q�6S   $	��Top=�6g   $	��140��6   $��40��6�   $��Modern No. 20)�6�   $��13.333(�6�   �� 59   
   -   5        $ label_Copy3��59      $��BALANCE��6%   $
��Left=�67   $��
34,108,0,0q�6R   $	��Top=�6f   $	��145��6~   $��40��6�   $��Modern No. 20)�6�   $��13.333(�6�   �� 5:   
   -   5         ��Name$ textBox��5:      $
��Left=�6#   $��40��6>   $��
179,58,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��178��6�   �� 5;   
   -   5        $ textBox_Copy��5;      $
��Left=�6(   $��40��6C   $��179,258,0,0q�6O   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��178��6�   �� 5<   
   -	   5        $ textBox_Copy1��5<      $
��Left=�6)   $��40��6D   $��179,207,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��178��6�   �� 5=   
   -
   5        $ textBox_Copy2��5=      $
��Left=�6)   $��40��6D   $��179,158,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��178��6�   �� 5>   
   -   5        $ textBox_Copy3��5>      $
��Left=�6)   $��40��6D   $��179,108,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��178��6�   �� 5?   
   -   5        $ button��5?      $
��SAVE��6!   $
��Left=�60   $��399,153,0,0q�6K   $	��Top=�6`   $��84��6x   $��33��6�   ���	#FFFFB1B1$��16(�6�   $
��Bold"�6�   
����������	#FF4263F56�   �� 5@   
   -   5        $ button_Copy��5@      $
��EDIT��6&   $
��Left=�65   $��399,207,0,0q�6P   $	��Top=�6e   $��84��6}   $��33��6�   ���	#FFFFB1B1$��16(�6�   $
��Bold"�6�   
����������	#FFF769066�   5B      5C      