   M S B A M L   `   `   `  ����Q  MOperationManagement_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:OperationManagement_UI.ViewsOperationManagement_UI.Views  5      3    -OperationManagement_UI.Views.SalesDetailsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:OperationManagement_UI.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      �   � RowDefinitions  5   
   �� 5      $��2* �6   �� 5      $	��10* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��0��5      $��0q�5      $��Center=�5      $��Center=�5      $��Sales Details��5      $��14(�5      $��Medium"�5      �� 5      $��1��5      $��25��5       $��25��5!      $��0q�5"      $��0q�5#      $
��Left=�5$      ���#f3f6fd��5&      �� *OpenSaleDetailsPopupCommand+.��5'      �� $%��../../Icons/Images/add_icon.png��6   $��Uniform=�6A   5(      5)      �� 5*   
   $��1��6   .��5,      � .+�5-      �� ��6   �� *SaleDetailsCollection+��5.      �� 5/      .R�50      �� $��0,0,0,2q�51   !   ���#f3f6fd���#503e9d$��2q�54   !    �� CornerRadius$ 5��55   !   ._�56   "   �  57   &   �� 58   *   $��3* �6;   �� 59   *   $��* �6;   �� 5:   *   $��* �6;   �� 5;   *   $��2* �6;   �� 5<   *   $��2* �6;   �� 5=   *   $��* �6;   .+�5@   &   �� $��0��5A   )   ���#503e9d$��0,0,1,0q�5C   )   $ 5��5D   )   ._�5E   *   �� $��Center=�65    �� Orientation$ Vertical=�6R   .+�5F   .   �� $��
Particular��5G   1   $��12(�5H   1   $��Medium"�5I   1    J� Opacity$	 0.8Q�5J   1   �� 5K   .   $��Center=�5L   1   $��Center=�5M   1   
������ 
������ $��0q�5P   1   $��14(�5Q   1   $��Medium"�5R   1   
���   � �� 
IsReadOnly$
 True��5T   1   ��5U   1   �� *
Particular+5V   +   5W   '   �� 5Z   &   $��1��5[   )   ���#503e9d$��0,0,1,0q�5]   )   $ 5��5^   )   ._�5_   *   �� $��Center=�65   $ Vertical=�6R   .+�5`   .   �� $	��Qty��5a   1   $��12(�5b   1   $��Medium"�5c   1   $	 0.8Q�5d   1   �� 5e   .   $��Center=�5f   1   $��Center=�5g   1   
������ 
������ $��0q�5j   1   $��14(�5k   1   $��Medium"�5l   1   $
 True��5m   1   ��5n   1   �� *
Quantity+5o   +   5p   '   �� 5r   &   $��2��5s   )   ���#503e9d$��0,0,1,0q�5u   )   $ 5��5v   )   ._�5w   *   �� $��Center=�65   $ Vertical=�6R   .+�5x   .   �� $
��Unit��5y   1   $��12(�5z   1   $��Medium"�5{   1   $	 0.8Q�5|   1   �� 5}   .   $��Center=�5~   1   $��Center=�5   1   
������ 
������ $��0q�5�   1   $��14(�5�   1   $��Medium"�5�   1   $
 True��5�   1   ��5�   1   �� *Unit+5�   +   5�   '   �� 5�   &   $��3��5�   )   ���#503e9d$��0,0,1,0q�5�   )   $ 5��5�   )   ._�5�   *   �� $��Center=�65   $ Vertical=�6R   .+�5�   .   �� $��Amount��5�   1   $��12(�5�   1   $��Medium"�5�   1   $	 0.8Q�5�   1   �� 5�   .   $��Center=�5�   1   $��Center=�5�   1   
������ 
������ $��0q�5�   1   $��14(�5�   1   $��Medium"�5�   1   $
 True��5�   1   ��5�   1   �� *Amount+5�   +   5�   '   �� 5�   &   $��4��5�   )   ���#503e9d$��0,0,1,0q�5�   )   $ 5��5�   )   ._�5�   *   �� $��Center=�65   $ Vertical=�6R   .+�5�   .   �� $��Total��5�   1   $��12(�5�   1   $��Medium"�5�   1   $	 0.8Q�5�   1   �� 5�   .   $��Center=�5�   1   $��Center=�5�   1   
������ 
������ $��0q�5�   1   $��14(�5�   1   $��Medium"�5�   1   $
 True��5�   1   ��5�   1   �� *Total+5�   +   5�   '   �� 5�   &   $��5��6-   ._�5�   *   �� $��Center=�65   $ 
Horizontal=�6R   .+�5�   .   �� $��20��5�   1   $��5q�5�   1   $��Center=�5�   1   $��Center=�5�   1   
������ 
������ $��0q�5�   1   ��5�   1   �� *$"DataContext.EditSaleDetailsCommand+ �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=���5�   1   �� ��5�   2   �� 5�   6   $��../Icons/Images/edit.png��6<   5�   /   �� 5�   .   $��20��5�   1   $��5q�5�   1   $��Center=�5�   1   $��Center=�5�   1   
������ 
������ $��0q�5�   1   ��5�   1   �� *&$DataContext.DeleteSaleDetailsCommand+ �� " >�$ FindAncestor=���5�   1   �� ��5�   2   �� 5�   6   $ ��../Icons/Images/delete.png��6<   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      