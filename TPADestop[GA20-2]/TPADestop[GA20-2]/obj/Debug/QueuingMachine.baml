   M S B A M L   `   `   `  ����L  HTPADestop[GA20-2], Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TPADestop_GA20_2_TPADestop_GA20_2_  5   	   &     TPADestop_GA20_2_.QueuingMachine   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TPADestop_GA20_2_     5   	     � Title$  QueuingMachine��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridQueue��5
      $��94,77,79.6,232q�6(      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ queueID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	queueID+ �� Mode$ TwoWay=�" �� ValidatesOnNotifyDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnExceptions . 	 �� NotifyOnValidationError	 . 6�     5      $ customerName��6%    6;   �� *customerName+$ TwoWay=� . $ PropertyChanged=� . 	 . 6�   5      �� 5   
   -   5        $��Get Queue Number��5      $
��Left=�6,   $��487,317,0,0q�6G   $	��Top=�6\   $	��137��6t   $��42��6�   6�   �� 5   
   -   5        
 ��Name$
 cusName��5      $
��Left=�6#   $��49��6>   $��381,263,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��333��6�   �� 5   
   $��Customer Name��6   $��25(�6(   $
��Left=�66   $��465,215,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5         ��Name$ qrCode��5      $
��Left=�6    $	��132��6;   $��134,227,0,0q�6H   $	��Top=�6]   $	��132��6u   �� 5   
   -   5        $��backBtn��5      $
��Left=�6#   $��
669,24,0,0q�6>   $	��Top=�6R   $��84��6j   $��35��6u   6�   5      5      