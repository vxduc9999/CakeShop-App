   M S B A M L   `   `   `  ����H  DMenuAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MenuAnimationMenuAnimation  5      *    $MenuAnimation.UserControlDetailCakes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MenuAnimation     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � 	Resources  5
      9   3MenuAnimation.ImagePatchRelativeToAbsoluteConverter   imagePathConverter��%   &	          5   
   66   5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5   *   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6M   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *
ExpandIn+   Duration$ 0:0:0X�.��5   
   ]� -   5        $��_frame��5      ��. .+�5      �  � ColumnDefinitions 5      �� 5      $	��600 �6'   �� 5      .+�5      � $��0��6    � RowDefinitions 5      �� 5      $��3* �6(   �� 5      .+�5      � $��0��6   $��10q�6(   .+�5      ��  �� BitmapScalingMode$ HighQuality=�6l   $��UniformToFill=�6�   ��6    �� *	ImagePath+ �� 	Converter# [  6�   5      � 5      $��1��6   $��5q�6(   .+�5      �� -   5        $��PreviewPhoto��5   9   $��5,0,0,0q�6'   ��5      �� 5   "    �� 
TargetType" ��62   .R�5    &   �� $
��Auto=�63   $��Disabled=�6X   .��5!   *   �� 5"   '   5#   #   ��5%      �� 5&   "   .R�5'   &   � 	 � Orientation$	 Vertical=�60   6I   5(   #   ��5*      �� 5+   "   .R�5,   &   �� 
 � Cursor$

 Hand��63   ��6A   �� *
listImages+��5-   *   �� 5.   .   .R�5/   2   � $	 
Horizontal=�6<   6W   50   /   ��52   *   �� 53   .   .R�54   2   � .+�55   6   �� $	��140��6=   $	��140��6I   $��0,0,5,0q�6V   ��56   :   �� 57   >    j� Stretch$ UniformToFill=�6I   $ HighQuality=�6y    �� ImageSource 6a   �� 6y   59   7   5:   3   5;   /   5=   '   5>   #   5@      5A      5B      � 5C      $��1��6    5D      �� 5E      $��45 �6(   �� 5F      $��4* �6(   .+�5H      � $��0��6   $��5q�6(   .+�5I      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�6>   $	��Top=�6Y   .+�5J      �� $��TRANG CHỦ /��6$   $��Center=�6:   $��Center=�6\   ���#555$��18(�6�   $��Center=�6�   $
��Left=�6�   �� 5K      $��Center=�6D   $��Center=�6f   ���#555$��18(�6�   $��Center=�6�   $
��Left=�6�   ��6$   �� *ProductType+6�   5L      �� 5M      -   5        $��_editProduct��5M   3   $

 Hand��6%   $ 
Horizontal=�6z   $��Right=�6�   $	��Top=�6�   .+�5N      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Settings=�66   $��Center=�6F   $��Center=�6c   $��Center=�6~   ���#555$��Center=�6�   $��51��6�   $��0.4,0,-0.6,0q�6�   $��17��6�   �� 5O      $��CHỈNH SỬA THÔNG TIN��6$   $��Center=�6B   $��Center=�6d   ���#555$��18(�6�   $��Center=�6�   $
��Left=�6�   5P      5Q      �� 5R      $��Hidden=�6#   $��1��6H   $��5,5,10,5q�6U   .��5S      �� $
��Left=�6%   $	��Top=�6@   .+�5T      �� $��Center=�6=   $��Center=�6_   ���#555$��32(�6�   $��Center=�6�   $
��Left=�6�   $��2,20,0,0q�6�   $
��Bold"�6�   ��6$   �� *Name+6�   � 5U      $��6,6,0,0q�6(   .+�5V   "   �� $��27(�6C   
���   �$
��Wrap=�6d   $��Center=�6�    �� TextAlignment$ Justify=�6�   $
��Bold"�6�   ��6,   �� *Price+��6x   Z� 6�   �� 5W   "   $�� VNĐ��6,   $��22(�68   
���   �$
��Wrap=�6Y   $��Center=�6�   $ Justify=�6�   $
��Bold"�6�   ��6m   Z� 6�   5X      �� 5Y      ���	#FF004400$��5��6<   $��52��6G   $
��Left=�6R   $��6,10,0,0q�6m   6�   �� 5Z      $��	10,26,6,0q�6)   .+�5[   "   �� $��MÔ TẢ��6,   $��27(�69   
���   �$
��Wrap=�6Z   $��Center=�6�   $ Justify=�6�   ��6n   Z� 6�   �� 5\   "   $
��Wrap=�6,   $��22(�6]   ���#555$��Center=�6}   $ Justify=�6�   ��6@   �� *Description+6�   5]      �� 5^      $ 
Horizontal=�6)   $��	6,16,0,50q�6B   .+�5_   "   �� -   5        $��Minus��5_   5   $��50��6)   $

 Hand��6Z   $��20��6h   $��0,0,5,0q�6s   $��Center=�6�   $��Center=�6�   
�������._�5`   &     $ Minus=�6>   ���#555$��Center=�6]   $��Center=�6z   $��Center=�6�   
�������$��Center=�6�   $��51��6�   $��0.4,0,-0.6,0q�6�   $��17��6  5a   #   �� 5b   "   $��50��6)   ���#555$��2q�6H   $��0,0,5,0q�6\   
�������._�5c   &   �� -   5        $��_number��5d   -   $��1��5e   -   $��20(�5f   -   $��50��5g   -   $��50��5h   -   $��Center=�5i   )   $��Center=�6K    �� TextAlignment$ Center=�6o   $��0q�6�   5j   #   �� 5k   "   -   5        $
��Plus��5k   5   $��50��6)   $

 Hand��6X   $��20��6f   $��0,0,20,0q�6q   
�������._�5l   &     ���#555
�������$
 Plus=�6c   $��Bottom=�6o   $��Center=�6�   $��Center=�6�   $��Center=�6�   $��0.4,0,-0.6,0q�6�   $��17��6  $��51��6  5m   #   �� 5n   "   -	   5        $

 Hand��5n   J   $��2q�6X   ���#d26e4b���#d26e4b$
��Left=�6�   ._�5o   &   �� $��8q�6,   $��20(�68   
�������$��Center=�6Y   $
��Bold"�6�   ��6{   Z� ��5p   *   �� 5q   .   $��	MUA HÀNG��69   6K   5s   '   5t   #   5u      5v      5w      5x      5y      5z      5{      5|      