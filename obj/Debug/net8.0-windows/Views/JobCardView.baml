   M S B A M L   `   `   `  ����Q  MOperationManagement_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:OperationManagement_UI.ViewsOperationManagement_UI.Views  5      .    (OperationManagement_UI.Views.JobCardView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:OperationManagement_UI.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      � $��Center=�6   
������   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��5      $��0��5      $
��Left=�5      $��Center=�5      $
��Date��5      $��14(�5       $��Normal"�5!      �� 5"   
   $��0��5#      $��1��5$      $��30��5%      $	��200��5&      
������ ���#503e9d$��1q�5)       �� CornerRadius$ 5��5*      ._�5+      (  "System.Windows.Controls.DatePicker  $��5q�5,      
������ 
������ $��0q�5/      $��14(�50      $��Medium"�51         Text 52      �� *JobCardCreatedDate+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�53      �� 56   
   $��1��57      $��0��58      $
��Left=�59      $��Center=�5:      $��Customer Name��5;      $��14(�5<      $��Normal"�5=      �� 5>   
   $��1��5?      $��1��5@      $��30��5A      $	��200��5B      
������ ���#503e9d$��1q�5E      $ 5��5F      ._�5G      �� $��5q�5H      
������ 
������ $��0q�5K      $��14(�5L      $��Medium"�5M      ��5N      �� *Customer.Name+5O      �� 5Q   
   $��0��5R      $��2��5S      $��20,0,0,0q�5T      $
��Left=�5U      $��Center=�5V      $��
Job Number��5W      $��14(�5X      $��Normal"�5Y      �� 5Z   
   $��0��5[      $��3��5\      $��30��5]      $	��200��5^      $��2q�5_      
������ ���#503e9d$��1q�5b      $ 5��5c      ._�5d      �� $��5q�5e      
������ 
������ $��0q�5h      $��14(�5i      $��Medium"�5j      ��5k      �� *JobCardNumber+$ TwoWay=�$ PropertyChanged=�5l      �� 5n   
   $��1��5o      $��2��5p      $��20,0,0,0q�5q      $
��Left=�5r      $��Center=�5s      $��	Attention��5t      $��14(�5u      $��Normal"�5v      �� 5w   
   $��1��5x      $��3��5y      $��30��5z      $	��200��5{      $��2q�5|      
������ ���#503e9d$��1q�5      $ 5��5�      ._�5�      �� $��30��5�      $	��200��5�      $��5q�5�      
������ 
������ $��0q�5�       �� DisplayMemberPath$
 Name��5�      $��14(�5�      $��Medium"�5�       �� SelectedIndex$ 0��5�      ��5�      �� *Customer.Attentions+$ TwoWay=� �� SelectedItem 5�      �� *SelectedAttention+5�      5�      5�      