   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:UI.ComponentsUI.Components  5      -clr-namespace:UI.ViewModelsUI.ViewModels  5      "    UI.Components.LoggedDataView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:UI.Components     5      2
viewModelsclr-namespace:UI.ViewModels     5        � DataContext  5      '   !UI.ViewModels.LoggedDataViewModel  5   
   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $
��logs��5         AutoGenerateColumns$ False��67   $��0,20,0,0q�6S   ��6   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      
IsReadOnly$
 True��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *	Timestamp+   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�5       ;� Handler 6C   *DoubleClickComand+5      5      5      �� 5   
   $
��Back��6   $
��Left=�6?   $��-8,0,0,0q�6Z   $	��Top=�6l   $��53��6�   ��6    �� *
BackComand+6�   �� 5   
   -   5        $��	userNames��5   P   $
��Left=�6   	 �� Text$
	 user��6a   $��50,0,0,0q�6m   $	��Top=�6   $	��264��6�   $��20��6�   
 �� SelectionChanged
 6.   �� *Logs+6�   5      5      