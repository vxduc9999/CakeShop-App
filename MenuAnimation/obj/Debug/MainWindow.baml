   M S B A M L   `   `   `  ����H  DMenuAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MenuAnimado1MenuAnimado1  5   	   -clr-namespace:MenuAnimationMenuAnimation  5   R       MenuAnimado1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MenuAnimado1     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (local1clr-namespace:MenuAnimation  6R   $	��780��6}   $
��1370��6�     � WindowState$  	Maximized=�6�    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	      9   3MenuAnimation.ImagePatchRelativeToAbsoluteConverter   imagePathConverter��%   &	          5
   
   67   5      .��5      ]� -   5        $��_mainWindow��5      ��. .+�5   
   � ���#efefef$	��100��6$   $	��Top=�61   .+�5      �� -   5        $��topBar��5   ?    �� Orientation$ 
Horizontal=�6   $	��100��62   $��Right=�6M   $��	0 0 250 0q�6i   .+�5      �� -   5        $��	labelHome��5       � Cursor$
 Hand��6E   $��15q�6S   $��TRANG CHỦ��6`   $��Center=�6t   $��Center=�6�   ���#555$��18(�6�   $��Center=�6�   �� 5      -   5        $��
labelAbout��5      $
 Hand��6G   $��15q�6U   $��GIỚI THIỆU��6b   $��Center=�6w   $��Center=�6�   ���#555$��18(�6�   $��Center=�6�   6�   �� 5      -   5        $��labelProduct��5      $
 Hand��6K   $��15q�6Y   $��SẢN PHẨM��6f   $��Center=�6y   $��Center=�6�   ���#555$��18(�6�   $��Center=�6�   6�   �� 5      -   5        $��labelContact��5      $
 Hand��6K   $��15q�6Y   $��THÊM SẢN PHẨM��6f   $��Center=�6~   $��Center=�6�   ���#555$��18(�6�   $��Center=�6�   6  �� 5      -   5        $��
labelChart��5      $
 Hand��6G   $��15q�6U   $��THỐNG KÊ��6b   $��Center=�6u   $��Center=�6�   ���#555$��18(�6�   $��Center=�6�   6�   5      �� 5      $	��200��6   $��50��6!   $��0,0,25,0q�6-   $	��1.2q�6?   ���#555 �� CornerRadius$ 15��6h   $��Right=�6z   ._�5      �� -   5        $ 
Horizontal=�5   7   $��Center=�6P   $��0,0,0,0q�6k   .+�5      �� $
 Hand��6   $��Giỏ hàng/0 VNĐ��6*   $��Center=�6C   $��Center=�6e   ���#555$��18(�6�   $��7 0 0 0q�6�   $��Center=�6�   �� 5      $��40��6   $��0,0,25,0q�6(   ._�5      � .+�5      �� $(��"Assets/icons8-favorite-cart-80.png��6$    �� BitmapScalingMode$ HighQuality=�6P   $��45��6~   $��Center=�6�   $��Center=�6�   6�   �� 5      -	   5        $��Total��5   $   $
 Hand��61   $��0��6?   $��Center=�6K   $��Center=�6m   ���#815D37$��12(�6�   $��Center=�6�   $��Center=�6�   $��10,2,0,0q�6�   5      5      5      5      �� 5       $ Vertical=�6   $
��Left=�60   $��Center=�6K   .+�5!      �� -
   5         ��Name$ imgLogo��5!      $
 Hand��6E   $��Assets/Untitled-1.png��6S   $ HighQuality=�6r   $	��210��6�   $��Center=�6�   $��Center=�6�   $��	0 -10 0 0q�6�   $	��130��6�   5$      5%      � 5&   
   -   5        $��_frame��5&      5(      5)      5*      