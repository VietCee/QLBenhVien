   M S B A M L   `   `   `  ����E  AProject_CK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project_CK.LogInProject_CK.LogIn  5   	       Project_CK.LogIn.SignIn   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Project_CK.LogIn     5   	   
������   � Title$  SignIn��5	   	   $	��500��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61    � WindowStyle$
 None=�6V    � AllowsTransparency . .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #7163ba��6#   	 � Offset$	 0Q�63   � 5      $ #3AADA1��6#   $	 1Q�63   5      ._�5      �� ._�5      � .+�5      �� .+�5      � 
 � Points
 �    -1��� ;X�����#4EB1B66>   � 5      '
 �    �� �� ���� ��
��4���#4EB1B66C   5      �� 5      $��Center=�6!   .+�5       �� $��Sign Up��6$      	titleText#��[  63   �� 5!      $D��>Enter your personal infor and create new account to connect us��6$   $��16(�5"       �� 
LineHeight$ 28��5#      $
��Wrap=�5$       �� TextAlignment$ Center=�5%      ���#fff J� Opacity$	 0.8Q�5'      $��20 30q�5(      �� 5)      -   5        $��Sign up��5)   !     SignUpButton#���  63   6Z   5*      5+      5,      50      �� 52   
   ���#ffffff$��1��6&   $ 	0 10 10 0��66   ._�53      �� $��Center=�6   .+�54      �� $��Sign in to App��6   $��0 0 0 50q�55   
   #��[  56   
   ���#7163ba6-   �� 58      $��1q�6   ���#acb0af$
��70 7q�6C   $ 5��6Q   ._�59      � $	��7 9q�6    5:      �� 5;      $
��auto �6/   �� 5<      $��* �6/   .+�5>      �� $��20��6!   $��/LogIn/email.png��6-   �� 5?      -   5         ��Name$ textUser��5?   $   $��Email��6U     	titleHint#��[ 6b   �� 5@      -   5         ��Name$ txtUser��5@   "   $��14(�5A      $��1��5B      $��10 0 0 0q�5C      ���#878787
������ $��0q�5F      5G      5I      5J      �� 5L      $��1q�6   ���#acb0af$
��70 7q�6C   $ 5��6Q   ._�5M      � $	��7 9q�6    5N      �� 5O      $
��auto �6/   �� 5P      $��* �6/   .+�5R      �� $��20��6!   $��/LogIn/key.png��6-   �� 5S      -   5        $ textPassword��5S   $   $��Password��6]   #��[ 6m   G� 5T      -   5         G�Name$ txtPassword��5T   &   $��14(�5U      $��1��5V      $��10 0 0 0q�5W      ���#878787
������ $��0q�5Z      5[      5]      5^      �� 5`      -   5         ��Name$ 	btnSignIn��5`      $��Sign In��6,     SignInButton#��[ 5a      6-   5c      5d      5e      5f      