   M S B A M L   `   `   `  ����G  CShoppingCart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ShoppingCartShoppingCart  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_Aclr-namespace:System.Windows.Automation;assembly=PresentationCoreSystem.Windows.Automation 5   	       ShoppingCart.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ShoppingCart     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   PautoPropAclr-namespace:System.Windows.Automation;assembly=PresentationCore  5   	   $	��600��5
      $
��1080��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5      �� .+�5   
   � $��50��6   $	��Top=�6   
���   �.+�5      �� $
��Left=�6C   $
��10 0q�6^   ��6   Z� ��6,   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�6*   $��25��67   $��25��6B   5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10 0q�6N   .+�5      �� ��6   Z� ��6/   Z� .��5        $ Account=�6.   5      �� 5      ��6   Z� ��6/   Z� .��5        $ Power=�6.   5      5      �� 5      $��Created by Bohdan Tsiunyk��6   $��Center=�6:   $��Center=�6W   
�������$��18(�6�   5      � 5   
   $��90��6   $	��Top=�6   ���#343a40.+�5      �� $��EZShoes��6   $��Center=�6'   $
��Left=�6B   $��20q�6]   $��30(�6i   
�������$��Stencil)�6�   �� 5      $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ SEARCH��6   
�������$	��600��6U   $��20(�6a     5      $ Magnify=�6*   
�������$��25��6L   $��25��6W   $��Center=�6c   $��5q�6~   5       �� 5!      $ 
Horizontal=�6   $��Right=�62   $
��50 0q�6N   $��Center=�6\   .+�5"        $
 Cart=�6*   
�������$��25��6I   $��25��6T   $��Center=�6`   $��5q�6{   �� 5#      
�������$��18(�6/   $��5��6=   $��Center=�6F   5$      5%      � 5&   
   $��20q�6   $	��Top=�6   
�������$	��420��6F    J� Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         
BlurRadius$ 20Q�6#      ShadowDepth$ 1Q�63   .+�5*      �� $��Assets/92886_179403_1.jpg��6   $
��Left=�67   $��150 0q�6R   �� 5+      $��80��6   $
��Left=�6"   $��80 50q�6=   .@�5,      �� $��60��6   $��60��6*   .��5-      �� $��Assets/92886_179403_1.jpg��6   $��UniformToFill=�6?   5.      �� 5/      $��60��6   $��60��6*   .��50      �� $��Assets/92886_179403_2.jpg��6   $��UniformToFill=�6?   51      �� 52      $��60��6   $��60��6*   .��53      �� $��Assets/92886_179403_3.jpg��6   $��UniformToFill=�6?   54      �� 55      $��60��6   $��60��6*   .��56      �� $��Assets/92886_179403_4.jpg��6   $��UniformToFill=�6?   57      �� 58      $��60��6   $��60��6*   .��59      �� $��Assets/92886_179403_5.jpg��6   $��UniformToFill=�6?   5:      5;      �� 5<      $��750 70 70 70q�6   $
��Left=�6/   .+�5=      �� $��BOYS' NIKE TEAM HUSTLE��6   $��18(�6:   $	��0 5q�6H   ���	#FF6A6A6A6U   �� 5>      $ ��D8 10.5-3 BASKETBALL SHOES��6   $��22(�6>   $
��Wrap=�6L   ���	#FF6A6A6A6`   �� 5?      $��item #75684��6   $��8(�6/   $	��0 5q�6<   ���	#FFC7C7C76I   �� 5@      $��$ 95.99��6   $��20(�6+   $
��0 15q�69   ���	#FFC7C7C76G   � 5A      $	��200��6   .+�5B      �� $
 SIZE��6   $��7q�6E   ���#343a40
�������$
��0 15q�6y   $
��Left=�6�   $��80��6�   .@�5C      �� $��11��6'   �� 5D      $
��11.5��6'   �� 5E      $��12��6'   �� 5F      $
��12.5��6'   5G      �� 5H      $	 QTY��6   	 �� 
IsEditable	 . $��7q�6V   $
��0 15q�6b   $��Right=�6p   $��80��6�   .@�5I      �� $��1��6'   �� 5J      $��2��6'   �� 5K      $��3��6'   �� 5L      $��4��6'   5M      5N      �� 5O      ���#343a40���#343a40$��SHOP NOW��6D   $
��0 20q�6W   5P      5Q      5R      5S      