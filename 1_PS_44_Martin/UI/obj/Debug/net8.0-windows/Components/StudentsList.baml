   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:UI.ComponentsUI.Components  5           UI.Components.StudentsList   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:UI.Components     5        � 	Resources  5	      )   #UI.Components.PasswordMaskConverter   PasswordMaskConverter��%   &	          5
   
   6&   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��students��5         AutoGenerateColumns$ False��6<   $��0,20,0,0q�6X   ��6$   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6%      
IsReadOnly$
 True��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Id+  5      $ Names��6%   $
 True��64    6F   �� *Name+  5      $ Password��6%   $
 True��67    6I   �� *
Password+ �� 	Converter# [    5      $
 Role��6%   $
 True��64    6F   �� *Role+  5      $ Facultity number��6%   $
 True��6@    6R   �� *FacNum+  5      $ Email��6%   $
 True��65    6G   �� *Email+  5      $ 
Expires in��6%   $
 True��6:    6L   �� *expiresDate+5      �� 5   
   -   5        $��Show Logged Data��5      $
��Left=�6I   $	��Top=�6d   �� 5   
   -   5        $��Add User��5      $
��Left=�6:   $��	104,0,0,0q�6U   $	��Top=�6h   $	��237��6�   5      5      