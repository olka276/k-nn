   M S B A M L   `   `   `  ����>  :knn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:knnknn  5   	       knn.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:knn     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��19* �6   �� 5      $��0* �6   �� 5      $
��150* �6   �� 5      $
��624* �6   .+�5   
   �� -   5        $��
Zatwierdź��5      $��3��6%   $
��Left=�65   $��305.5,261,0,0q�6P   $	��Top=�6g   $��76��6   $��20��6�   �� 5   
   $��Podaj liczbę k
��6   $��2��63   $
��Left=�6C   $��
63,145,0,0q�6^   $	��Top=�6r   $��90��6�   $��26��6�   $��2��6�   �� 5   
   -   5        $��kValue��5      $��3��6    $
��Left=�60   $��24��6K   $��8.5,147,0,0q�6W    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $��52��6�   6�   �� 5   
   $N��HPodaj właściwiości obiektu do
decyzji oddzielając wartości spacją��6   $��2��6e   $
��Left=�6u   $��
63,185,0,0q�6�   $	��Top=�6�   $��44��6�   $	��202��6�   $��2��6�   �� 5   
   -   5        $��	newValues��5      $��3��6#   $
��Left=�63   $��30��6N   $��120.5,199,0,0q�6Z   $
 Wrap=�6q   $	��Top=�6�   $	��261��6�   6�   �� 5   
   $&�� Obiekt zaklasyfikowany do klasy:��6   $��2��6;   $
��Left=�6K   $��
63,328,0,0q�6f   $	��Top=�6z   $��2��6�   �� 5   
   -   5        $��decision��5      $!��Kliknij przycisk zatwierdź��6    $��3��6E   $
��Left=�6U   $��120.5,328,0,0q�6p   $	��Top=�6�   �� 5   
   $��Wybierz metrykę��6   $��2��6*   $
��Left=�6:   $��	63,99,0,0q�6U   $	��Top=�6h   $��2��6�   �� 5   
   $"��Wczytaj plik txt z próbkami��6   $��2��66   $
��Left=�6F   $��	63,53,0,0q�6a   $	��Top=�6t   $	��164��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�   5      5      