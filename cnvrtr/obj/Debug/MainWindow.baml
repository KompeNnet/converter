   M S B A M L   `   `   `  ����A  =cnvrtr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:cnvrtrcnvrtr  5   	       cnvrtr.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:cnvrtr     5   	     � Title$  My converter��5   	   $	��350��6   $	��525��6+    � 
ResizeMode$ CanMinimize=�5	   	   .��5
      � -   5         �Name$ Progress��5
      .+�5   
   �� -   5         ��Name$ fileList��5      $	��267��6%   $	��Top=�63   $��16,43,226,0q�6K   $
��Auto=�6`   $
��Auto=�6�    �� View 5      �� 5      .P�5      �� $
��Name��6%    �� DisplayMemberBinding 63   �� *Name+�� 5      $��	Extension��6%    68   �� *	Extension+�� 5      $
��Dest��6%    63   �� *Dest+�� 5      $
��Data��6%    �� Width$ 0��6Y    63   �� *Data+6Y   5      5      �� 5   
   -   5         ��Name$ cnvrtBtn��5      $��Convert!��6#   $
��Left=�66   $��28��6Q   $��308,252,0,0q�6]   $	��Top=�6r   $	��201��6�   6�   �� 5   
   -   5        $ btnAdd��5      $��
Load files��6!   $��28��66   $��
298,43,0,0q�6B   $	��Top=�6V   $	��200��6n   6z   �� 5   
   -   5         ��Name$ cbbFrm��5      $��22��6#   $��
298,76,0,0q�6/   $	��Top=�6C   $	��200��6[   	 �� SelectedIndex$	 0��6g   .@�5      �� $
��.bmp��6   �� 5      $
��.jpg��6   �� 5      $
��.png��6   �� 5      $��.tiff��6   �� 5      $
��.gif��6   �� 5      $
��.ico��6   �� 5      $
��.wmf��6   5      �� 5    
   -   5        
 ��Name$
 NDest��5       $��22��6!   $��
15,10,40,0q�6-    �� TextWrapping$
 Wrap=�6A   $��TextBox��6U   $	��Top=�6d    �� 
IsReadOnly . 6|   �� 5!   
   -   5        $ btnChDst��5!      $
��Dest��6#   $��22��62   $��
467,10,0,0q�6>   $	��Top=�6R   $��31��6j   6u   �� 5"   
   -   5        $ btnDel��5"      $��Delete��6!   $
��Left=�62   $��22��6M   $��308,103,0,0q�6Y   $	��Top=�6n   $��52��6�   6�   �� 5#   
   -	   5        $ btnClear��5#      $��Clear��6#   $
��Left=�63   $��22��6N   $��365,103,0,0q�6Z   $	��Top=�6o   $��52��6�   6�   � 5$   
   -
   5         �Name$ 
pbProgress��5$      $
��Left=�6*    � Value$ 0Q�6E    � Minimum$ 0Q�6O   $��25��6[   $��308,285,0,0q�6g   $	��Top=�6|   $	��200��6�   5%      5&      