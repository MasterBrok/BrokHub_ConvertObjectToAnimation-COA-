   M S B A M L   `   `   `  ����Z  VBrokHub_ConverObjectToAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null{Bclr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.Buttons4BrokHub_ConverObjectToAnimation.BaseControls.Buttons  5      g8clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.Views*BrokHub_ConverObjectToAnimation.MVVM.Views  5      q=clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.ViewModels/BrokHub_ConverObjectToAnimation.MVVM.ViewModels  5	      :    4BrokHub_ConverObjectToAnimation.MVVM.Views.ErrorView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      VbuttonsBclr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.Buttons     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Nview=clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.ViewModels     5	      -   5          �Name$  error��5
      $	��350��5      $	��150��5       � AllowsTransparency$
 True��5      
������  � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � DataContext 5      D   >BrokHub_ConverObjectToAnimation.MVVM.ViewModels.ErrorViewModel  5   
   .��5      �� $��2q�6    �� CornerRadius$ 25��6!   ��5   
   �� 5       �� 
StartPoint$	 1 0&�6"    �� EndPoint$	 0 1&�63   .��5      �  � Offset$	 0.1Q�6   	 � Color	 6,   ��    bgMain7
 �� Source#
 [   �� Path$ Color�� 5      $	 0.8Q�6   	 6,   ��   bgMain4#
 [ $ Color�5       � Triggers 5   
   :� 5       :� RoutedEvent$ Loaded��6   .[�5      ��   BorderAnimationResultView#��[ 6"   5       ��5#   
   
� 5$       �� RelativeTransform 5%      �� 5&       �� Angle$ 50Q�6&   .��5(      � $	 0.1Q�6   	 6,   ��   bgMain2#
 [ $ Color�� 5)      $	 1.2Q�6   	 6,   �� #
 [  $ Color�5*      ._�5,   
   � .+�5.      �� $��Center=�5/      $	��Top=�50      
���������52      �� *
ErrorTitle+ �� Mode$ TwoWay=��� 54      $��Center=�6   .+�56      �� $��10q�57      $��Center=�58      
���  ��$
��Wrap=�5;      ��5:      �� *	Message+$ TwoWay=�5;      5<      G   ABrokHub_ConverObjectToAnimation.BaseControls.Buttons.ccButtonMenu  5>      $��30��5?      $��5q�5@      $��Bottom=�5A      $��Ok��5D      ��5B      �� *OK+��5C      ��  �� ElementName$ error��5D      5G      5H      5I      