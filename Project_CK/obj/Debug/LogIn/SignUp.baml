   M S B A M L   `   `   `  ����E  AProject_CK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project_CK.LogInProject_CK.LogIn  5   	       Project_CK.LogIn.SignUp   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Project_CK.LogIn     5   	   
������   � WindowStyle$
  None=�5   3    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � Title$ SignUp��5	   	   $	��500��6   $	��800��6%   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   �� ���#7163ba �� Padding$ 30q�6&    �� CornerRadius$ 	10 0 0 10��63   ._�5      �� $��Center=�6   .+�5      �� $	��160��6   $	��160��6%   $��0 0 0 60q�62   $��/LogIn/teamwork.png��6D   �� 5      $��Let's get you set up��6    �� TextAlignment$ Center=�5      $��SemiBold"�5      $��25(�5      ���#3636365      5      5      �� 5   
   $��1��6   $ 20q�6!   ���#fff$ 	0 10 10 0��6@   ._�5      � .+�5      � $��Center=�6   $��Center=�64   $��0 5 0 0q�6O    5       �� 5!      $	��150 �6+   �� 5"      $	��250 �6+    � RowDefinitions 5%      �� 5&      $
��auto �6(   �� 5'      $
��auto �6(   �� 5(      $
��auto �6(   �� 5)      $
��auto �6(   �� 5*      $
��auto �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   .+�5/      �� $��0��6    $��	Họ Tên��6-      text_signup#��[  6;   �� 50      $��3��6    $��Email��6-   #��[  6:   �� 51      $��4��6    $��Mật Khẩu��6-   #��[  6=   �� 52      $��5��6    $��Nhập Lại Mật Khẩu��6-   #��[  6F   �� 55      -   5        	 ��Name$	 txtName��55      $��1��6/   $��0��6?     textbox_signup#��[ 6L   �� 56      -   5        $	 txtEmail��56      $��1��60   $��3��6@   #��[ 6M   G� 57      -   5        
 G�Name$
 
txtMatKhau��57   "   $��1��66   $��4��6F     passwword_box#��[ 6S   G� 58      -   5        $
 txtXacNhanMK��58   "   $��1��68   $��5��6H   #��[ 6U   � 5;      $��1��6   $��6��6+   $��0 40 0 0q�68    5<      �� 5=      $��* �6/   �� 5>      $��* �6/   .+�5A      �� -   5        $��Cancel��5A   !   $��0,0,10,0q�62     button_Cancel#��[ 6D   $��35��6k   $	��Top=�6w   6�   �� 5B      -   5         ��Name$ btnSave��5B   !   $
��Save��62   $��10 0 0 0q�6A   $��1��6S     button_Save#��[ 6c   6�   5D      5F      5I      5K      5M      5N      