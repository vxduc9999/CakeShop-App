   M S B A M L   `   `   `  ����H  DMenuAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MenuAnimationMenuAnimation  5          MenuAnimation.UserProduct   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MenuAnimation     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � 	Resources  5      9   3MenuAnimation.ImagePatchRelativeToAbsoluteConverter   imagePathConverter 
 Color1��%H   &	        &	        5   
   66   ��5   
   	#FF334862��6*   5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$  TrainsitionigContentSlide1��5   *   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6N   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromTop+   Duration$ 0:0:0.8X�.��5   
     -   5        $ TrainsitionigContentSlide��5   .    6Q     *
ExpandIn+$ 0:0:0X�.��5      ]� -   5        $��_frame��5      .+�5      �  � RowDefinitions 5      �� 5      $��60 �6(   66   �� 5      6*   .+�5      � $��0��6   $
��Left=�6(   .+�5      �� $��Center=�6%   $
��Left=�6@   .+�5      �� -   5        $��_nameComboBox��5   '   $��Center=�6<   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ TẤT CẢ LOẠI BÁNH��6^   $
��Left=�6�   ���#555$��DemiBold"�6�   $��18(�6  $��Center=�6  $
��Left=�60  $��20 0 0 0q�6K  $��4,4,4,4q�6]  .@�5   "   �� $��TẤT CẢ LOẠI BÁNH��6/   $��15(�6J   6Z   �� 5   "   $��BÁNH NGỌT��6/   $��15(�6C   6S   �� 5   "   $��	BÁNH MÌ��6/   $��15(�6A   6Q   �� 5   "   $��BÁNH THEO MÙA��6/   $��15(�6G   6W   �� 5   "   $��	BÁNH KEM��6/   $��15(�6B   6R   �� 5    "   $��BÁNH ĐÓNG GÓI��6/   $��15(�6G   6W   �� 5!   "   $��BÁNH KEM NHỎ��6/   $��15(�6F   6V   5"      5#      5$      � 5%      $��0��6   $��Right=�6(   .+�5&      �� -   5        $��_pagination��5&   %    �� Orientation$ 
Horizontal=�68   $��Center=�6Q   $��Center=�6l   .+�5'      �� -   5         � Cursor$
 Hand��5'   9   $"��Assets/icons8-back-to-50.png��6G    �� BitmapScalingMode$ HighQuality=�6m   $��40��6�   $��Center=�6�   $��Center=�6�   6�   �� 5(      -   5        $
 Hand��5(   :   $$��Assets/icons8-next-page-50.png��6H   $ HighQuality=�6p   $��40��6�   $��Center=�6�   $��Center=�6�   $��	10,0,20,0q�6�   6�   5)      5*      � 5+      $��1��6   .+�5,      �� -	   5        $��dataListview��5,   #   $��Hidden=�6h   
�������$��Disabled=�6�   $��Stretch=�6�   $��Stretch=�6  ��5-      �� 5.   "   .R�5/   &   A� 	 A� Columns$	 4��62   
 A� Rows$
 3��6>   $��5 0 5 0q�6G   6Z   50   #   ��52      �� 53   "   .R�54   &   ]� ��. .+�55   *   � $	��250��6/   $	��Top=�6<   .+�56   .   �� ��57   2   �� 58   6   $ HighQuality=�6�    j� Stretch$ UniformToFill=�6�    �� ImageSource 6A   �� *	ImagePath+ �� 	Converter# [  6�   5:   /   5;   +   �� 5<   *   $��Bottom=�65   .+�5=   .   �� $	��0,5q�64   $��20(�6B   ���#555$��Center=�6b   $
��Bold"�6�   ��6�   Z� ��5>   2   �� 5?   6    �� TextWrapping$
 Wrap=�6A   ��6U   �� *Name+6m   5A   /   �� 5B   .   $��20(�6O   
���   �$
��Wrap=�6p   $��Center=�6�    �� TextAlignment$ Justify=�6�   $��DemiBold"�6�   ��68   �� *Price+��6�   Z� VNĐ6�   �� 5D   .   $��_order��65   $��40��6C   $	��120��6O   $
 Hand��6[   $��2q�6i   ���#555$
��Left=�6�   $��0,20,0,0q�6�   ��6�   �� *
Background+._�5E   2   �� -
   5        $��	MUA HÀNG��5E   N   $
��Bold"�6a   $��16(�6s   ��5F   6   �� 5G   :    �� 
TargetType" ��6@   .�5H   >   ��  �� Property � �� �� Value
 �����6[   �� 5I   >    � �� 5J   B   �� 5K   F    �� Color$ #815D37��6V   5M   ?   �� 5N   >    � �� 5O   B   �� 5P   F    �� 
TargetType" ��6V   .R�5Q   J   �� #��z��6Q   $��1q�6{   ._�5R   N   �� $��Center=�6_   $��Center=�6|   5S   K   5T   G   5V   ?    �� Triggers 5W   >   P� 5X   B    P� Property �@J�IsMouseOver P� Value . . �5Y   F   ��  � �� 5Z   J   �� 5[   N   $
 #555��6^   5]   G   �� 5^   F    � �� 5_   J   �� 5`   N   $ White��6^   5b   G   5c   C   5e   ;   5g   3   5h   /   5i   +   5j   '   5k   #   5m      5n      5o      5p      5q      5r      5s      