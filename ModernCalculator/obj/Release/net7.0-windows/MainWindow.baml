   M S B A M L   `   `   `  ���� K  GModernCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ModernCalculatorModernCalculator  e7clr-namespace:ModernCalculator.MVVM.View.CustomControls)ModernCalculator.MVVM.View.CustomControls  !    ModernCalculator.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:ModernCalculator     Scustom_controls7clr-namespace:ModernCalculator.MVVM.View.CustomControls     -     � Title$  
MainWindow��$	��575��$	��375�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�
������  � AllowsTransparency$
 True��.����  �� CornerRadius$ 20�����#23276F$��5q�����  �� 
StartPoint$
 0, 0&� �� EndPoint$
 1, 1&�.���  � Color$ #BA5370��	 � Offset$	 0Q�� $ #d04ed6��$	 1Q�._�� .+�� -   $��grid_UserMenu��$��25q�
 J� Opacity$
 1Q� � RowDefinitions �� $	��54* ��� $
��461* �.+��� -   $��border_Display�����#000000���#505050$��0��$ 10��$��5q�._�� .+��� -    ��Name$ textblock_Display��$��/Fonts/#Cascadia Code)�$��30(�$��Center=�$��5 0 0 0q����#FFFFFF���� *PropertyValue_enter+ �� UpdateSourceTrigger$ PropertyChanged=��� -   $ textblock_Term��$��/Fonts/#Cascadia Code)�$
��12.5(�$��Right=�$
��10 5q����#B4B4B4���� *PropertyString_term+$ PropertyChanged=��� -   $��grid_ButtonsPanel��$��1��$��0 20 0 0q�.+�� -   $��grid_SettingsPanel��$��30��.+�@   :ModernCalculator.MVVM.View.CustomControls.Button_Interface  @   :ModernCalculator.MVVM.View.CustomControls.Button_Interface   
EventClick$ Click_AboutButton��   BackGroundColor �#F15F79   ForeGroundColor �#E4D7EA   	TextField$ About��   	ExitState$ 1��$��Right=�  $ Window_Exit�� �#594CD9 �#E4D7EA$
 Exit��$ 1��$
��Left=�� -   $��grid_ButtonPlaceHolder��$��0 30 0 0q�$	��350�� � ColumnDefinitions �� �� $��0.25* � �� �� $��0.25* �.+�� $��0��$��0�� �� �� ��  �� �� �� .+�?   9ModernCalculator.MVVM.View.CustomControls.Button_BasicNum  ?   9ModernCalculator.MVVM.View.CustomControls.Button_BasicNum   
EventClick$ Click_BasicNum��   Value$ 1��$��0��$��0��  $ Click_BasicNum��$ 2��$��1��$��0��  $ Click_BasicNum��$ 3��$��2��$��0��  $ Click_BasicNum��$ 4��$��0��$��1��  $ Click_BasicNum��$ 5��$��1��$��1��  $ Click_BasicNum��$ 6��$��2��$��1��  $ Click_BasicNum��$ 7��$��0��$��2��  $ Click_BasicNum��$ 8��$��1��$��2��  $ Click_BasicNum��$ 9��$��2��$��2��� $��1��$��0�� �� ��  �� �� .+�D   >ModernCalculator.MVVM.View.CustomControls.Button_OperationSign  D   >ModernCalculator.MVVM.View.CustomControls.Button_OperationSign   
EventClick$ Click_Operation��   	Operation$ +��$��0��$��0��  $ Click_Operation��$ -��$��0��$��1��  $ Click_Operation��$ *��$��1��$��0��  $ Click_Operation��$ /��$��1��$��1��� $��0��$��1�� �� �� �� .+�  $ Click_BasicNum��$ 0��$��1��B   <ModernCalculator.MVVM.View.CustomControls.Button_Termination  B   <ModernCalculator.MVVM.View.CustomControls.Button_Termination   
EventClick$ Click_TerminateAll��   	Operation$ C��$��0��  $ Click_TerminateLastNum��$ X��$��2��� $��1��$��1��.+�=	   7ModernCalculator.MVVM.View.CustomControls.Button_Result	  =
   7ModernCalculator.MVVM.View.CustomControls.Button_Result 
  
EventClick$ Click_GetResult���� $��FREENZY @2023 [Unlicense]��$
��0 10q�$��Center=����#8B8B8B�� -	    ��Name$ border_AboutMenu��$��25q�$
 0Q� K� ZIndex$ -1��${�False��$��5q����#EC9821$ 20��._��� .+��� $��Advanced Calculator��$��/Fonts/#Cascadia Code)�$��25(�$��Center=�$��Center=����#FFFFFF$
��12.5q��� $��Made by Frenzy��$
��Bold"�$��/Fonts/#Cascadia Code)�$��20(�$��Center=�$��Center=����#FFFFFF$��0q��� $#��Personal links | Social Media��$��/Fonts/#Cascadia Code)�$
��12.5(�$��Center=�$��Center=����#FFFFFF$��	0 50 0 20q�� -
    �Name$ grid_Images��$
��20 0q� �� �� .+��� -    ��Name$ icon_GitHub��$��Images/icon_GitHub.png��$��0��$��15q�� $��1�� �� �� .+��� -   $ 
icon_Steam��$��Images/icon_Steam.png��$
��Left=�$��0���� -   $ icon_Youtube��$��Images/icon_Youtube.png��$��Center=�$��Right=�$��1��  $ Click_AboutButton��$ Back To Calculator�� �#F15F79 �#E4D7EA$ -1��