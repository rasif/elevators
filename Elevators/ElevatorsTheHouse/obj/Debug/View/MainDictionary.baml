   M S B A M L   `   `   `  ����L  HElevatorsTheHouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ElevatorsTheHouse.ModelElevatorsTheHouse.Model  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   FloorTemplate  �� DataType(    "ElevatorsTheHouse.Model.FloorModel �� RelativeSource �� AncestorType d� 	IsChecked �� 
TargetType �� Property �� Value �� Triggers �� Binding	 �� Value  LiftTemplate'   !ElevatorsTheHouse.Model.LiftModel
 �� Left
 �� Top N� EnterActions g� FillBehavior �� TargetProperty W� From	 W� To g� Duration  BlockTemplate(   "ElevatorsTheHouse.Model.BlockModel  HouseTempate(   "ElevatorsTheHouse.Model.HouseModel�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      /model%clr-namespace:ElevatorsTheHouse.Model  5      %�  &	        &	 �    &	 V    7   7  &	 z    7  �� 5      "    6)   .R�5   
   � .+�5      �� $	��120��5	      $	��140��5
      $��	0,10,0,10q�5      ���#D7D4D4
�������$��1,0,1,0q�5      	� 5      $��15,0,0,0q�5      $��Center=�5      
����·�
�������$��1q�5      ��5      �� *!DataContext.CallElevatorCommand+ �� $ WindowL���5      ��  5      �� *	IsPressed+��5      �� 5      " 	�6   �5      �� 5       � {� . 6:    5      �� 5       6*   �� *	IsPressed+	 True6H   .a�5   "   ��  � {� .  6>   5       �� 5!       6*   �� *	IsPressed+		 False6H   .a�5"   "   ��  � {� . 6>   5#      5%      5'      5(      5)      �� 5+      "   6(   .R�5,   
   �� .+�5-      �� $	��120��50      
�������
 5.      �� *X+ 5/      �� *Y+��51      �� *Weight+52      �� 53      $	��140��56      ���#E9E9E9
 54      �� *X+ 55      �� *Y+��58      �� 59      " ��6   �5:      �� 5;       � ��$	 120��66    5=      �� 5>       6*   �� *
IsOpened+	 True6G    5?   "   �� 5@   &   .��5A   *   �� .��5B   .   W� $
 Stop=�5C   1   $ Width�5D   1   $	 120X�5E   1   $ 0X�5F   1   $ 0:0:2D�5G   1   5H   +   5I   '   5K      �� 5L       6*   �� *
IsOpened+		 False6G    5M   "   �� 5N   &   .��5O   *   �� .��5P   .   W� $
 Stop=�5Q   1   $ Width�5R   1   $ 0X�5S   1   $	 120X�5T   1   $ 0:0:2D�5U   1   5V   +   5W   '   5Y      5[      5]      5^      5_      �� 5a      "   6)   .R�5b   
   �� .+�5c      �� 8��  
 5d      �� *X+��5f      �� *Floors+��5g      �� 5h      .R�5i      �� 
������ 6%   5j      5l      �� 5m      $��	0,10,30,0q�5n      8�� ��5o      �� *Lift+5p      5q      5r      �� 5t      "   6(   .R�5u   
   �� 8��  ��6E   �� *Blocks+��5v      �� 5w      .R�5x      �� 
������ ��5y      �� *Width+��5z      �� *Height+5{      5|      5~      5      5�      