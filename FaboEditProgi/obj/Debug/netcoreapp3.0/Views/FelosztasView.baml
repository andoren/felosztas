   M S B A M L   `   `   `  ����H  DFaboEditProgi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FaboEditProgi.ViewsFaboEditProgi.Views  5      '    !FaboEditProgi.Views.FelosztasView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:FaboEditProgi.Views     5      
�������.��5      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   � $��0��6   $��5q�6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5       $
��auto �6    .+�5#      �� $�� 5 5 0 5q�6   $��Számlaszáma:��6*   6@   �� 5$      -   5         ��Name$ 
Szamlaszam��5$      $��25��6*   $��5q�66   $��1��6A   6R   �� 5&      $�� 5 5 0 5q�6   $��2��6*   $��Számlatípus:��67   6M   �� 5'      -   5         ��Name$ SzamlaTipusok��5'       �� DisplayMemberPath$ 
Megnevezes��6.   $��25��6   $��5q�6�   $��3��6�    �� SelectedItem 6M   ��  �� Path$ SelectedSzamlaTipus�6�   �� 5)      $�� 5 5 0 5q�6   $��4��6*   $��Összeg:��67   6H   �� 5*      -   5        $ Osszeg��5*      $��25��6t   $��5q�6�   $��5��6�   ��6&   �� $ Osszeg� �� StringFormat$ {0:C0}�� �� ConverterCulture$ hu-HU��6�   �� 5,      -   5        	 ��Name$	 IsAfaMentes��5,      $�� 5 5 0 5q�6.   $��6��6@   .��6M   Áfa mentes6Y   �� 5-      $�� 5 5 0 5q�6   $��7��6*   Áfa mentes összeg:6K   �� 5.      $��25��6�   $��5q�6�   $��8��6�   ��6   �� $ AfaMentesOsszeg�$ {0:C0}��$ hu-HU��{�6m   �� 
 �� ElementName$
 IsAfaMentes��$ 	IsChecked�6�   �� 50      -   5         ��Name$ 	Calculate��50      $��10q�6(   $��5q�65   $��9��6@   .��6M   Kalkuláció6Z   51      � 56   
   $��5q�6   $��1��6    57      �� 58      $
��auto �6    �� 59      $��* �6    .+�5<      &   System.Windows.Controls.DataGrid  -   5          Name$ Felosztasok��5<   K   $��1��6      AlternatingRowBackground
 �����   AutoGenerateColumns$ False��6`      CanUserAddRows$ False��6|      
IsReadOnly$
 True��6�      Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6S      Header$ Megnevezés��6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6*   �� $ Xkod.Megnevezes�6`     5@      $ * 6M   $ Ukód��6W    6*   �� $ Ukod.Kod�6W     5A      $ * 6M   $ Xkód��6W    6*   �� $ Xkod.Kod�6W     5B      $
 0.5* 6O   $ %��6\    6*   �� $ 
Percentage�6\     5C      $ * 6�   $ Nettó��6�    6*   �� $ NettoOsszeg�$ {0:C0}��$ hu-HU��6�     5D      $ * 6�   $
 Áfa��6�    6*   �� $ 	AfaOsszeg�$ {0:C0}��$ hu-HU��6�     5E      $ * 6   $ Bruttó��6�    6*   �� $ Osszesen�$ {0:C0}��$ hu-HU��6�   5G      �� 5H      
�������$��1��6)   $��50��66   $��50��6A      PrintButton#��[  6N   $��Bottom=�6s   $��Right=�6�   $��	0 0 10 10q�6�   .��5I      �� $��/Icons/printericon.png��6   $��UniformToFill=�6:    �� StretchDirection$ DownOnly=�6R   5J      5K      5L      5M      