   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ Scrlwvr��5      $��0��6(   $��3��65   $��0��6F   $��4��6V   $��15q�6j   .��5      �� -   5         ��Name$ textBox��5      {�. $
��Auto=�69   5      �� 5   
   -   5         ��Name$ 
installBtn��5      $'��!Установить службу��6%   $��3��6A   $��0��6N   $��2��6^   $��10q�6r   6�   �� 5   
   -   5        $ startServiceBtn��5      $%��Запустить службу��6*   $��4��6E   $��0��6S   $��2��6c   $��10q�6w   6�   �� 5   
   -   5        $ uninstallBtn��5      $!��Удалить службу��6'   $��3��6@   $��2��6M   $��2��6]   $��10q�6q   6�   �� 5   
   -   5        $ stopServiceBtn��5      $'��!Остановить службу��6)   $��4��6E   $��2��6S   $��2��6c   $��10q�6w   6�   5      5      