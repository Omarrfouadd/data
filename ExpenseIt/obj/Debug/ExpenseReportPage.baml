   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5      !    ExpenseIt.ExpenseReportPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ExpenseIt     5        N� Title$  ExpenseReportPage��5	       N� 
Background
 �����.��5      �  � ShowGridLines .  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � $��1��6   $��1��6    .  5      �� 5      �� 5       5      �� 5      $��50 �6    �� 5      $��50 �6    �� 5      .+�5      �� $��0��6   $��0��6&   $��2��66    �� Orientation$ 
Horizontal=�6J   .+�5       ��    
LabelStyle#��[  6   .��6<   Name :6D   �� 5!      -   5        $��NameData��5!   <   #��[  6   6O   5"      �� 5#      $��1��6   $��0��6&   $��2��66   $ 
Horizontal=�6J   .+�5$      �� #��[  6   .��6<   Department :6J   �� 5%      -   5        $��DepartmentData��5%   <   #��[  6   6T   5&      � 5'      $��2��6   $��0��6    .+�5(      &   System.Windows.Controls.DataGrid  -   5        $��ExpenseDataGrid��5(         AutoGenerateColumns .    RowHeaderWidth$ 0Q�6N   $��	0,0,0,164q�6a   
�������   ColumnHeaderStyle 5)      �� 5*      	 �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"	  6    .�5+      �� 
 �� Property
 � �� �� Value$ 35��67   �� 5,      
 � ��$ 5q�68   �� 5-      
 � ��$ 10(�69   �� 5.      
 � ��$
 Bold"�6;   �� 5/      
 � �� �	#FF458AF76;   �� 50      
 � ��
 �����6;   53      57      58      5:      �� 5;   
   $��1��6   $��Expense Report For :��6    $��Center=�6?   $��0,7,0,0q�6\   $	��Top=�6m   $
��Bold"�6�   $��17(�6�   ���	#FFF3F3F36�   ��5<   
   �� 5=       �� ImageSource$ 
madrid.jpg��6   5?      5@      