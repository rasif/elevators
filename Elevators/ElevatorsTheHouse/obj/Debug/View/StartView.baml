   M S B A M L   `   `   `  ����  ElevatorsTheHouse&     ElevatorsTheHouse.View.StartView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5        $��StartWindow��5      $	��250��5      $	��180��5        � AllowsTransparency  . 
������ $��Segoe UI Light)�5
       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ MainDictionary.xaml?�6%   %    5      ��5      �� 5   
   
�������
������ $��0q�5       �� CornerRadius$ 5��5      ._�5      �  � RowDefinitions 5      �� 5      $��32 �6$   �� 5      $��* �6$   .+�5       �� $��0��5!      
����  �$ 5 5 0 0��5#      ._�5$      ]� .+�5%      �� $��13��5&      $��13��5'      $��0,2,15,0q�5(      $��Right=�5)       � Cursor$
 Hand��5*      $��Right=�5+      $��../Image/exit.png��5,      	 J� InputBindings	 5-      d� 5.   "   
 d� MouseAction$
 	LeftClicke�51   %    �� Command 5/   %   �� *CloseWindowCommand+ �� CommandParameter 50   %   ��  �� ElementName$ StartWindow��51   %   53      �� 54      $��13��55      $��13��56      $��	0,13,15,0q�57      $��Right=�58      $
 Hand��59      $��Right=�5:      $��../Image/collapse.png��5;      	 5<      d� 5=   "   $
 	LeftClicke�5@   %    5>   %   �� *CollapseWindowCommand+ 5?   %   �� $ StartWindow��5@   %   5B      5C      	 5E      d� 5F      $
 	LeftClicke�5I       5G      �� *DragWindowCommand+ 5H      �� $ StartWindow��5I      5K      �� 5M      $��1��6   $��20q�6*   .+�5N      �� $��0,0,0,10q�6   ��60   �� *CountOfFloor+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5O      $��0,0,0,10q�6   ��60   �� *CountOfLift+$ TwoWay=�$ PropertyChanged=��� 5P      $��30��5Q      $��0,0,0,10q�5R      
����  �$��0q�5T      $��Запустить��5W      $��16(�5X      
���������5U      �� *CreateMainViewCommand+��5V      �� $ StartWindow��5Y      5Z      5\      5]      5_      