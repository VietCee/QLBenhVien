   M S B A M L   `   `   `  ����E  AProject_CK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Project_CK
Project_CK  5   	   ;"clr-namespace:Project_CK.ViewModelProject_CK.ViewModel  5   	   ;"clr-namespace:Project_CK.UtilitiesProject_CK.Utilities  5   	       Project_CK.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Project_CK     5   	   1vm"clr-namespace:Project_CK.ViewModel     5   	   3Menu"clr-namespace:Project_CK.Utilities     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5	   	     � AllowsTransparency  .  � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � Title$ 
MainWindow��5   	   $	��720��6   $
��1080��6)    � DataContext 5      '   !Project_CK.ViewModel.NavigationVM  5   
   .��5      � .+�5   
   �� 
������  �� CornerRadius$ 20��5      � 5   
    � ColumnDefinitions 5      �� 5      $	��230 �6#   �� 5      $��* �6#   .+�5       � $
��Left=�6   $	��230��5!      .+�5"      �� ���#7163ba$ 	20,0,0,20��5#      �� 5$      $	��500��6   $	��230��5%      $��
0,180,0,98q�6   .+�5(         Project_CK.Utilities.Btn     BtnStyle#��[  6   ��5)      �� *BenhNhanCommand+.��5*      ��  �� Orientation$ 
Horizontal=�6%   .+�5+      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ AccountMultipleOutline=�64     menuButtonIcon#��[ 6R   �� 5-      $��Bệnh Nhân��6(     Text_Menu_Style#��[ 5.      50      52        54      #��[  6   ��55      �� *BacSiCommand+.��56      �� $ 
Horizontal=�6%   .+�57        $ Doctor=�64   #��[ 6B   �� 59      $��Bác Sĩ��6(   #��[ 5:      5<      5>        5A      #��[  6   ��5B      �� *BenhAnCommand+.��5C      �� $ 
Horizontal=�6%   .+�5D        $ FileDocument=�64   #��[ 6H   �� 5F      $��Hồ Sơ��6(   #��[ 5G      5I      5K        5M      #��[  6   ��5N      �� *XuatVienCommand+.��5P      �� $ 
Horizontal=�6%   .+�5Q        $ ArrowRightBold=�64   #��[ 6J   �� 5S      $��Xuất Viện��6(   #��[ 5T      5V      5W        5\      -   5        	  Name$	 btnDangXuat��5\         Project_CK.Utilities.Btn
   Checked$
 Btn_Checked��6V      Click$ btnDangXuat_Click��6l   #��[  64   .��5^      �� $ 
Horizontal=�6%   .+�5_        $ Logout=�64   #��[ 6B   �� 5a      $��Đăng Xuất��6(   #��[ 5b      5d      5g      5k      5m      � 5p      $��1��6   
�������.+�5q      �� $ 	0,20,20,0��6   ._�5r      �� -   5         ��Name$ Pages��5r   %   ��5s      �� *CurrentView+5u      5w      5x      5y      5z      