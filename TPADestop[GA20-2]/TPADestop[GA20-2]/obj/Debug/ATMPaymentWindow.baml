   M S B A M L   `   `   `  ����L  HTPADestop[GA20-2], Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TPADestop_GA20_2_TPADestop_GA20_2_  5   	   (    "TPADestop_GA20_2_.ATMPaymentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TPADestop_GA20_2_     5   	     � Title$  ATMPaymentWindow��5   	   $	��450��6"   $	��800��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridBills��5      $��94,64,79.6,245q�6(      AutoGenerateColumns .  $��1��6\      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ billID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *billID+ �� Mode$ TwoWay=�" �� ValidatesOnNotifyDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�	 �� ValidatesOnExceptions	 . 
 �� NotifyOnValidationError
 . 6�     5      $ billName��6%    67   �� *
billName+$ TwoWay=� . $ PropertyChanged=�	 . 
 . 6�     5      $ 
billAmount��6%    69   �� *
billAmount+$ TwoWay=� . $ PropertyChanged=�	 . 
 . 6�   5      �� 5   
   $��Bills ID��6   
���   �$��25(�66   $��Berlin Sans FB)�6D   $
��Left=�6`   $��39��6{   $��359,180,0,0q�6�   $	��Top=�6�   $��99��6�   $��1��6�   �� 5   
   -   5        $��
txtBillsID��5      $��2��6%   $
��Left=�69   $��40��6T   $��281,219,0,0q�6`    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��248��6�   �� 5   
   $��2��6   $��Money Amount��6$   
���   �$��25(�6N   $��Berlin Sans FB)�6\   $
��Left=�6x   $��321,264,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $��txtAmountMoney��5      $��2��6(   $
��Left=�6<   $��40��6W   $��281,301,0,0q�6c   $
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��248��6�   �� 5   
   -   5         ��Name$ 
PaymentBtn��5      $	��Pay��6%   $
��Left=�63   $��342,362,0,0q�6N   $	��Top=�6c   $	��116��6{   $��48��6�   $��24(�6�   $��Berlin Sans FB)�6�   ���	#FF4BE8FF � Cursor$
 Hand��6�   $��2��6�   6�   5      5      