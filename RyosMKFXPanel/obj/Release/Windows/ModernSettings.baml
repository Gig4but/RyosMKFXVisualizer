   M S B A M L   `   `   `  ���� H  DRyosMKFXPanel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RyosMKFXPanel.WindowsRyosMKFXPanel.Windows  *    $RyosMKFXPanel.Windows.ModernSettings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:RyosMKFXPanel.Windows       � WindowStyle$
  None=� � AllowsTransparency .  � Title$ Settings��$��94��$	��300��$��94��$	��300�����	#FF222222���	#FF444444$��2q� � 	Resources    ButtonClose �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 F�Name
 J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName  ButtonReset �� Padding��%�  &	        &	     �� " ��.���  � �� �� " ��.R�� $��0,0,-1,0q�.+��� $ ButtonCloseBackground�����	#00FFFFFF$��42��$��29��$��Center=�$��Center=�$��
-32,-2,2,0q�F� $	 ButtonCloseSymbol��$��12��$��12��
 .  ���	#DDFFFFFF$��2��+����        � �  � �     � � �     	$��	-32,0,0,0q�$��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� $ ButtonCloseBackground�� � �� �	#AAFF0000P�  � �� . . ��� $ ButtonCloseBackground�� � �� �	#66FF0000�� " ��.���  � �� �	#FF333333��  � �� �	#FF444444��  � ��$ 2q���  � �� �� " ��.R�� $��0q�.+��� $	 Top�����	#FF555555$��	-2,-2,0,0q��� $	 Bot�����	#FF111111$��	0,0,-2,-2q��� $
 Top2�����	#FF555555$��
-2,-2,0,-2q�$
��Left=�$ 0,0,2,0q��� $
 Bot2�����	#FF111111$��
0,-2,-2,-2q�$��Right=�$ 2,0,0,0q��� #��z��._��� $��Center=�$��Center=�$��0,0,0,2q� P�  � �� . . ��� $	 Top�� � �� �	#FF111111�� $
 Top2�� � �� �	#FF111111�� $	 Bot�� � �� �	#FF555555�� $
 Bot2�� � �� �	#FF555555.��� .+�]� $	��Top=�$
��auto��.+�]� -    ]�Name$ TitleBar��$	��Top=����	#FF444444$��30��.+�� $��Center=� � ColumnDefinitions �� $��1* ��� $��1* �.+��� -    ��Name$ X��$��Main Settings��$��18(�$
��Bold"����	#AA222222$��0,15,0,0q��� -   $ Y��$��Main Settings��$��18(�$
��Bold"����	#AA222222$��	0,-10,0,0q��� $��Main Settings��$��16(�$
��Bold"�  ActualColorBrushFF#���  $��8,4,0,0q�� $��1��$��Right=�.+��� -   $��ButtonClose��$��Center=�$��1q�#��[  � $��4,8,4,0q� �� $	��100 ��� $��2* � � RowDefinitions �� $��* ��� .+��� $��Listen device:��$��16(����	#88FFFFFF$��0,0,0,8q��� -    ��Name$ comboBoxDevices��$��1��$��Center=� �� SelectedIndex$ 0�����	#FF333333���	#FF444444$��16(�$��0,-3,0,5q�.@��� $
��Auto�����	#FF444444�� -   $��reset settings��$
��Left=�#��[ $��1��$	��Top=�$	��100��$��2��$��14(�#���  