   M S B A M L   `   `   `  ����H  DMenuAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MenuAnimationMenuAnimation  5      '    !MenuAnimation.UserControlShopping   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MenuAnimation     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 	Resources 5      9   3MenuAnimation.ImagePatchRelativeToAbsoluteConverter  imagePathConverter��%   &	         5   
   66   5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5   *   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6M   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *
ExpandIn+   Duration$ 0:0:0X�.��5   
   ]� -   5        $��_frame��5      ��. .+�5      � $	��100��6   $	��Top=�6    .+�5      �� -   5        $��topBar��5   C    �� Orientation$ 
Horizontal=�6   $	��100��66   $��Center=�6Q   .+�5      �� -   5        $��_shoppingcart��5       � Cursor$
 Hand��61   $��10q�6?   $��GIỎ HÀNG��6L   $��Center=�6_   $��Center=�6�   $��20(�6�   $��Center=�6�   $
��Bold"�6�   �� 5      $
 Hand��6   $��10q�6*   $��>��67   $��Center=�6C   $��Center=�6e   $��18(�6�   $��Center=�6�   6�   �� 5      -   5        $��	_checkout��5   L   $
 Hand��6]   $��10q�6k   $��KIỂM TRA CHI TIẾT��6x   $��Center=�6�   $��Center=�6�   $��20(�6�   $��Center=�6�   6  �� 5      $
 Hand��6   $��10q�6*   $��>��67   $��Center=�6C   $��Center=�6e   $��18(�6�   $��Center=�6�   6�   �� 5      -   5        $��	_complete��5      $
 Hand��6-   $��10q�6;   $��HOÀN THÀNH��6H   $��Center=�6]   $��Center=�6   $��20(�6�   $��Center=�6�   6�   5      5      � 5       � ColumnDefinitions 5       �� 5!      $��2* �6'   64   �� 5"      6)   .+�5$      �� ._�5%      ]� ��. $��0��65   $��10q�6E   .+�5&      �� $	��Top=�6!   $��0,0,0,3q�66   ���#777._�5'      � $��50��6#    5(   "   �� 5)   &   $��3* �67   6D   �� 5*   &   69   �� 5+   &   69   �� 5,   &   69   .+�5.   "   � $��0��6'   .+�5/   &   �� $
 Hand��6,   $��SẢN PHẨM��6:   $��Center=�6M   $��Center=�6o   $��20(�6�   $��Center=�6�   $
��Left=�6�   50   #   � 51   "   $��1��6'   .+�52   &   �� $
 Hand��6,   $
��GIÁ��6:   $��Center=�6H   $��Center=�6j   $��20(�6�   $��Center=�6�   $
��Left=�6�   53   #   � 54   "   $��2��6'   .+�55   &   �� $
 Hand��6,   $��SỐ LƯỢNG��6:   $��Center=�6M   $��Center=�6o   $��20(�6�   $��Center=�6�   $��Center=�6�   56   #   � 57   "   $��3��6'   .+�58   &   �� $
 Hand��6,   $��TỔNG��6:   $��Center=�6I   $��Center=�6k   $��20(�6�   $��Center=�6�   $��Right=�6�   59   #   5:      5;      �� 5<      -   5        $��dataListview��5<   #   $��Hidden=�67   
�������$��Disabled=�6|   $��Stretch=�6�   $��Stretch=�6�   ��5=      �� 5>   "   .R�5?   &   �� 63   5@   #   ��5B      �� 5C   "   .R�5D   &   �  5E   *   �� 5F   .   $��3* �6?   6L   �� 5G   .   6A   �� 5H   .   6A   �� 5I   .   6A   .+�5K   *   � $��0��6/   .+�5L   .   �� .+�5M   2   � .+�5N   6   �� $
 Hand��6=   $��	-10,0,5,0q�6K   ._�5O   :   �� 	 ��Name$	 buttonDeleteProduct��6A   -	   5        $��36��5O   �   $��36��6�    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF404040��6�   Z� ��6�   Z� .��5P   >   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]
   Kind$
 CloseCircleOutline=�6V   $��36��6p   $��36��6{   
���  ��$��Center=�6�   $��Center=�6�   5Q   ;   5R   7   �� 5S   6   $	��100��6=   $	��100��6J   $��0,0,10,0q�6V   ��5T   :   �� 5U   >    �� BitmapScalingMode$ HighQuality=�6�    j� Stretch$ UniformToFill=�6�    �� ImageSource 6I   �� *	ImagePath+ �� 	Converter# [ 6�   5W   7   �� 5X   6   $��20(�6V   
���   �$
��Wrap=�6w   $��Center=�6�    �� TextAlignment$ Justify=�6�   $
��Bold"�6�   ��6@   �� *Name+��6�   Z� 6�   5Y   3   5Z   /   5[   +   � 5\   *   $��1��6/   $��Center=�6?   $
��Left=�6Z   .+�5]   .   �� .+�5^   2   �� $��20(�6S   
���   �$
��Wrap=�6t   $��Center=�6�   $ Justify=�6�   $
��Bold"�6�   ��6<   �� *Price+��6�   Z� �� 6�   .�6�   VNĐ6�   6�   5_   /   5`   +   � 5a   *   $��2��6/   $��Center=�6?   $��Center=�6\   .+�5b   .   �� .+�5c   2   �� $��20(�6V   
���   �$
��Wrap=�6w   $��Center=�6�   $ Justify=�6�   $
��Bold"�6�   ��6<   �� *
Quantity+��6�   Z� 6�   5d   /   5e   +   � 5f   *   $��3��6/   $��Right=�6?   $��Center=�6[   .+�5g   .   �� .+�5h   2   �� $��20(�6S   
���   �$
��Wrap=�6t   $��Center=�6�   $ Justify=�6�   $
��Bold"�6�   ��6<   �� *Total+��6�   Z� �� 6�   .�6�   VNĐ6�   6�   5i   /   5j   +   5k   '   5l   #   5n      5o      5p      �� 5q      
�������$��1��6,   $	��490��6<   $	��Top=�6I    J� Effect 5r      3  -System.Windows.Media.Effects.DropShadowEffect  5s         	Direction$	 240Q�6+      ShadowDepth$ 20Q�6;      Opacity$	 0.2Q�6L   ._�5u      ]� ��. $��10q�65   .+�5v      �� $	��Top=�6   $��0,0,0,3q�62   ���#777._�5w      � $��50��6   .+�5x      �� $
 Hand��6$   $��TỔNG GIỎ HÀNG��62   $��Center=�6J   $��Center=�6l   $��20(�6�   $��Center=�6�   $
��Left=�6�   5y      5z      �� 5{      $��60��6   $	��Top=�6)   $��0,0,0,3q�6>   ���#777$	��Top=�6k   ._�5|      �  5}      �� 5~   "   65   �� 5   "   65   .+�5�      � $��0��6#   .+�5�   "   �� $
 Hand��6(   $��TỔNG TIỀN��66   $��Center=�6J   $��Center=�6l   $��20(�6�   $��Center=�6�   $
��Left=�6�   5�      � 5�      $��1��6#   .+�5�   "   �� -
   5        $��_total��5�   (   $
 Hand��66   $��Center=�6D   $��Center=�6f   $��20(�6�   $��Center=�6�   $��Right=�6�   $
��Bold"�6�   5�      5�      5�      �� 5�      -   5        $��40��5�      $
 Hand��6E   $��2q�6S   ���#d26e4b���#d26e4b$	��Top=�6�   $��0,30,0,0q�6�   ._�5�      �� $��8q�6    $��20(�6,   
�������$��Center=�6M   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   ��6o   Z� ��5�      �� 5�   "   $��THANH TOÁN��6-   6A   5�      5�      5�      5�      5�      5�      5�      5�      