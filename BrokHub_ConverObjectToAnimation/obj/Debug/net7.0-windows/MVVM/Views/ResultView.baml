   M S B A M L   `   `   `  ����Z  VBrokHub_ConverObjectToAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null{Bclr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.Buttons4BrokHub_ConverObjectToAnimation.BaseControls.Buttons  5      g8clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.Views*BrokHub_ConverObjectToAnimation.MVVM.Views  5      }Cclr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.TextBoxs5BrokHub_ConverObjectToAnimation.BaseControls.TextBoxs  5	      q=clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.ViewModels/BrokHub_ConverObjectToAnimation.MVVM.ViewModels  5
      ;    5BrokHub_ConverObjectToAnimation.MVVM.Views.ResultView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      VbuttonsBclr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.Buttons     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      XtextboxsCclr-namespace:BrokHub_ConverObjectToAnimation.BaseControls.TextBoxs     5	      Nview=clr-namespace:BrokHub_ConverObjectToAnimation.MVVM.ViewModels     5
      $	��650��5      $	��550��5        � AllowsTransparency$
  True��5      
������  � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � DataContext 5      E   ?BrokHub_ConverObjectToAnimation.MVVM.ViewModels.ResultViewModel  5   
   .��5      �� $��3q�6    �� CornerRadius$ 20��6!   ��5   
   �� 5       �� 
StartPoint$	 1 0&�6"    �� EndPoint$	 0 1&�63   .��5      �  � Offset$	 0.1Q�6    � Color 6,   ��    bgMain7	 �� Source#	 [  
 �� Path$
 Color�� 5      $	 0.8Q�6    6,   ��   bgMain4#	 [ $
 Color�5      ��5   
   �� 5      $	 1 0&�6"   $	 0 1&�63   .��5      � $	 0.5Q�6    6,   ��   bgMain2#	 [ $
 Color�� 5      $
 0.02Q�6    6-   ��   bgMain3#	 [ $
 Color�5        � Triggers 5"   
   :� 5#       :� RoutedEvent$ Loaded��6   .[�5$      ��   BorderAnimationResultView#��[ 6"   5%      ._�5)   
   �� .+�5+      H   BBrokHub_ConverObjectToAnimation.BaseControls.TextBoxs.ccTextBoxCOA  -   5          Name$ lblReult��5,      $	��600��5-      $	��400��5.      $��10q�5/      $��5q�50      $	��Top=�51      #��[ 52       �� 
IsReadOnly$
 True��53       J� Opacity$	 0.7Q�54       �� TextWrapping$
 Wrap=�56      ��55      �� *	Animation+56      G   ABrokHub_ConverObjectToAnimation.BaseControls.Buttons.ccButtonMenu  59      $
��Copy��5<      ��5:      �� *Copy+��5;      ��  �� ElementName$ lblReult�� J� Effect 5=      3  -System.Windows.Media.Effects.DropShadowEffect  5>         
BlurRadius$ 10Q�5?         	Direction$	 123Q�5@         Opacity$	 0.8Q�5A         ShadowDepth$ 5Q�5B         Color 5C      ��   bgMain5#	 [ $
 Color�5E      �� 5G      $��Center=�5H      $��Center=�5I       	 Font1#��[ 5J      
���������5L      �� *IsCopy+ �� StringFormat$ Tag is Copy : {0}�� �� UpdateSourceTrigger$ 	LostFocus=�5N      5Q      5R      