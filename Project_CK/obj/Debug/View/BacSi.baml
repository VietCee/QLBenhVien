   M S B A M L   `   `   `  ����E  AProject_CK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Project_CK.ViewProject_CK.View  5          Project_CK.View.BacSi   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      +localclr-namespace:Project_CK.View   5      
������    
Page_Style#���   5
      .��5      � .+�5   
   �   � RowDefinitions  5      �� 5      $	��100 �6    �� 5      $	��300 �6    �� 5      $��* �6    .+�5      ��  �� CornerRadius$ 0,20,0,0��6   ���#fff._�5      � $��0��6   .+�5      �� $��QUẢN LÝ BÁC SĨ��6    $��25(�5      $��SemiBold"�5      $��Center=�5      $��Center=�5      5      5      � 5      $��1��6   .+�5      � -   5        ���#fff  5       �� 5!      $	��300 �6(   �� 5"      $
��300* �6(   .+�5$      �� $��Thông tin bác sĩ��6   $��10,28,230,22q�69   $��SemiBold"�6O   5%      �� 5&      $��SemiBold"�6    $
��Left=�66   $��	40,73,0,0q�6Q   $
��Wrap=�6d   $��Mã Bác Sĩ :��6x   $	��Top=�6�   �� 5'      $��SemiBold"�6    $
��Left=�66   $��
40,106,0,0q�6Q   $
��Wrap=�6e   $��Tên Bác Sĩ :��6y   $	��Top=�6�   �� 5(      $��SemiBold"�6    $
��Left=�66   $��
40,245,0,0q�6Q   $
��Wrap=�6e   $��Kinh Nghiệm :��6y   $	��Top=�6�   �� 5)      $��SemiBold"�6    $
��Left=�66   $��
40,209,0,0q�6Q   $
��Wrap=�6e   $��Chuyên Khoa :��6y   $	��Top=�6�   �� 5*      $��SemiBold"�6    $
��Left=�66   $��
40,138,0,0q�6Q   $
��Wrap=�6e   $��Giới Tính :��6y   $	��Top=�6�   �� 5+      $��SemiBold"�6    $
��Left=�66   $��
40,172,0,0q�6Q   $
��Wrap=�6e   $��Số Điện Thoại :��6y   $	��Top=�6�   �� 5,      -   5         ��Name$ txtMaBS��5,      $
��Left=�6/   $��
151,68,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��130��6�   �� 5-      -   5        $ txtKinhNghiem��5-      $
��Left=�65   $��151,240,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��130��6�   �� 5.      -   5        $ txtTenBS��5.      $
��Left=�60   $��151,101,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��130��6�   �� 5/      -   5        $ txtSDTBS��5/      $
��Left=�60   $��151,167,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��130��6�   �� 50      -   5         ��Name$ cbbKhoa��50   5   $��SemiBold"�6   $
��Left=�6F   $��151,205,0,0q�6a   $	��Top=�6v   $	��130��6�   �� 51      -   5        $ 
cbbGTinhBS��51   5   $��SemiBold"�6   $
��Left=�6I   $��151,135,0,0q�6d   $	��Top=�6y   $	��130��6�   �� 52      -   5         ��Name$ btnThem��52      $��Thêm��6.   $
��Left=�6=   $��
483,73,0,0q�6X   $	��Top=�6l     	button_CK#��[ 6�   �� 53      -	   5        $ btnSua��53      $��Sửa��6-   $
��Left=�6;   $��483,126,0,0q�6V   $	��Top=�6k   #��[ 6�   6�   �� 54      -
   5        $ btnXoa��54      $
��Xóa��6-   $
��Left=�6;   $��483,194,0,0q�6V   $	��Top=�6k   #��[ 6�   6�   �� 55      -   5         ��Name$ imgBS��55      $��UniformToFill=�6+   $
��Left=�6C   $	��140��6^   $��
326,77,0,0q�6k   $	��Top=�6   $	��120��6�   �� 56      -   5        $ btnTaiAnhBS��56      $��Tải Ảnh Lên��62   $
��Left=�6H   $��338,237,0,0q�6c   $	��Top=�6x   #��[ 6�   $��96��6�   $��28��6�   6�   �� 59      $��SemiBold"�6   $��Tìm thông tin��65   $��628,28,10,22q�6L   �� 5:      $
��Left=�6    $	��140��6;   $��
326,78,0,0q�6H   
���   �$	��Top=�6k   $	��120��6�   �� 5;      $��SemiBold"�6    $
��Left=�66   $��
642,74,0,0q�6Q   $
��Wrap=�6e   $��Tìm kiếm theo : ��6y   $	��Top=�6�   �� 5<      $��SemiBold"�6!   $
��Left=�67   $��642,141,0,0q�6R   $
��Wrap=�6g   $��Nhập từ khóa : ��6{   $	��Top=�6�   �� 5=      -   5        $ 
txtTimKiem��5=      $
��Left=�62   $��642,167,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��150��6�   �� 5>      -   5        $ cbbTimKiemBS��5>   5   $��SemiBold"�6   $
��Left=�6K   $��642,102,0,0q�6f   $	��Top=�6{   $	��150��6�   �� 5?      -   5        $ 
btnTimKiem��5?      $��Tìm kiếm��61   $
��Left=�6D   $��639,227,0,0q�6_   $	��Top=�6t   #��[ 6�   $��75��6�   �� 5@      -   5        $ 	btnReLoad��5@      $��Tải Lại��60   $
��Left=�6B   $��732,227,0,0q�6]   $	��Top=�6r   #��[ 6�   $��75��6�   6�   5B      5D      � 5F      $��2��6   ���#eff2f7.+�5G      &   System.Windows.Controls.DataGrid  -   5          Name$ dtgBacSi��5G        DataGridStyle1#���  5H   
     DataGridCellStyle1   	CellStyle# �  63     DataGridColumnHeaderStyle1	   ColumnHeaderStyle#	 �  6d     DataGridRowStyle1
   RowStyle#
 �  5I         Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã BS��6-      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6X   �� *MaBS+  5M      $ Tên BS��6-    . $ * 6O    6Y   �� *TenBS+  5N      $ Giới Tính��6-    . $ * 6R    6\   �� *
GioiTinh+  5O      $ Số Điện Thoại��6-    . $ * 6V    6`   �� *SDT+  5P      $ Chuyên Khoa��6-    . $ * 6T    6^   �� *
ChuyenKhoa+  5Q      $ Kinh Nghiệm��6-    . $ * 6T    6^   �� *
KinhNghiem+5W      5X      5Z      5[      5\      