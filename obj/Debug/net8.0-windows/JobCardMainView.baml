   M S B A M L   `   `   `  ����Q  MOperationManagement_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:OperationManagement_UI.ViewsOperationManagement_UI.Views  5      S.clr-namespace:OperationManagement_UI.ViewModel OperationManagement_UI.ViewModel  5      ,    &OperationManagement_UI.JobCardMainView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      9uc*clr-namespace:OperationManagement_UI.Views     5      D	viewmodel.clr-namespace:OperationManagement_UI.ViewModel     5        � Title$  JobCardMainView��5	      $
��1080��5
      $	��780��5      $��Segoe UI)�5       � 
ResizeMode$ CanMinimize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$ 
ToolWindow=�5       � 	Resources 5      3   -OperationManagement_UI.Views.TruckDetailsView   TruckDetailsEntry��%   &	          5   
   6   5      .��5      � $
��1250��6    � ColumnDefinitions 5   
   �� 5      $	��15* �6    � RowDefinitions 5   
   �� 5      $	��13* �6   .+�5   
   �� $��0��5      $��0��5      ���#d1cef0 �� CornerRadius$ 10��5       ._�5!      �� .��5"      �  5#      �� 5$      $��* �6+   �� 5%      $��* �6+    5'      �� 5(      $
��2.5* �6(   �� 5)      $��2* �6(   �� 5*      $��2* �6(   �� 5+      $��3* �6(   �� 5,      $��3* �6(   �� 5-      $��3* �6(   �� 5.      $
��Auto �6(   .+�52      �� $��0��53      $��0��54      $��2��55      $
��Auto��56      $
��Auto��57      $��5q�58      ���#f3f6fd$��0q�5:      $ 10��5;      ._�5<      ��  �� Orientation$ Vertical=�6%   .+�5=      �� $��Center=�5>   !   $��Job Card��5?   !   $��14(�5@   !   $��Medium"�5A   !   
���   �5B   !   .   (OperationManagement_UI.Views.JobCardView  5C      $��5q�6-   	 � DataContext	 68   �� 
 �� Path$
 JobCardViewModel�5D      5E      �� 5I      $��1��5J      $��0��5K      $��2��5L      $
��Auto��5M      $
��Auto��5N      $��5q�5O      ���#f3f6fd$��0q�5Q      $ 10��5R      ._�5S      �� $ Vertical=�6%   .+�5T      �� $��Center=�5U   !   $��Consignment Details��5V   !   $��14(�5W   !   $��Medium"�5X   !   
���   �5Y   !   9   3OperationManagement_UI.Views.ConsignmentDetailsView  5Z      $��5q�68   	 6C   �� $!
 ConsignmentDetailsViewModel�5[      5\      �� 5`      $��2��5a      $��0��5b      $
��Auto��5c      $
��Auto��5d      $��5q�5e      ���#f3f6fd$��0q�5g      $ 10��5h      ._�5i      �� $ Vertical=�6%   .+�5j      �� $��Center=�5k   !   $��Shipper Details��5l   !   $��14(�5m   !   $��Medium"�5n   !   
���   �5o   !   5   /OperationManagement_UI.Views.ShipperDetailsView  5p      $��5q�64   	 6?   �� $
 ShipperDetailsViewModel�5q      5r      �� 5v      $��2��5w      $��1��5x      $
��Auto��5y      $
��Auto��5z      $��5q�5{      ���#f3f6fd$��0q�5}      $ 10��5~      ._�5      �� $ Vertical=�6%   .+�5�      �� $��Center=�5�   !   $��Consignee Details��5�   !   $��14(�5�   !   $��Medium"�5�   !   
���   �5�   !   7   1OperationManagement_UI.Views.ConsigneeDetailsView  5�      $��5q�5�   !   
������ 	 5�   !   �� $
 ConsigneeDetailsViewModel�5�      5�      �� 5�      $��3��5�      $��0��5�      $��2��5�      $
��Auto��5�      $	��175��5�      $��5q�5�      ���#f3f6fd$��0q�5�      $ 10��5�      ._�5�        $��5q�5�      
������ 	 5�      �� $
 TruckDetailsViewModel�5�      �� 5�      $��4��5�      $��0��5�      $��2��5�      $
��Auto��5�      $	��175��5�      $��5q�5�      ���#f3f6fd$��0q�5�      $ 10��5�      ._�5�      3   -OperationManagement_UI.Views.SalesDetailsView  $��5q�5�      
������ 	 5�      �� $
 SaleDetailsViewModel�5�      �� 5�      $��5��5�      $��0��5�      $��2��5�      $
��Auto��5�      $	��175��5�      $��5q�5�      ���#f3f6fd$��0q�5�      $ 10��5�      ._�5�      2   ,OperationManagement_UI.Views.CostDetailsView  $��5q�5�      
������ 	 5�      �� $
 CostDetailsViewModel�5�      �� 5�      $��6��5�      $��1��5�      $
��Auto��5�      $
��Auto��5�      $��5q�5�      $��Right=�5�      
������ $��1q�5�      $ 5��5�      ._�5�      �� $��Right=�6%   $ 
Horizontal=�6A   .+�5�      �� $��5q�5�   !   ���#3c2b87$ 5��5�   !   ._�5�   "   �� $��80��5�   %   $��30��5�   %   $��5q�5�   %   
������ 
������ $��0q�5�   %   ��5�   %   �� *SaveJobCard+.��5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $��Center=�5�   -   $
��Save��5�   -   $
��Bold"�5�   -   ���#ffffff5�   -   �� 5�   *   $(��"../Icons/Images/save_main_icon.png��60   $��Uniform=�6\   5�   '   5�   #   5�      �� 5�      $��5q�5�   !   ���#3c2b87$ 5��5�   !   ._�5�   "   �� $��80��5�   %   $��30��5�   %   $��5q�5�   %   
������ 
������ $��0q�5�   %    �� IsCancel$
 True��5�   %   .��5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $��Center=�5�   -   $��Close��5�   -   $
��Bold"�5�   -   ���#ffffff5�   -   �� 5�   *   $+��%../Icons/Images/close_button_icon.png��60   $��Uniform=�6_   5�   '   5�   #   5�      5�      5�      5�      5      5     5     5     