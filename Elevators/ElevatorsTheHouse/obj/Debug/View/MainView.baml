   M S B A M L   `   `   `  ����  ElevatorsTheHouse%    ElevatorsTheHouse.View.MainView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5        $��
MainWindow��5        � Title$  
Лифты��5      $	��825��5      $	��600��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! ../View/MainDictionary.xaml?�6%   %    5      ��5      �� 5   
   ���#F5F5F5
������ $��0q�5       �� CornerRadius$ 5��5      ._�5      � 	 � RowDefinitions	 5      �� 5      $��30 �6$   �� 5      $��* �6$   .+�5"      �� $��0��5#      
����  �
������ $ 5 5 0 0��5&      ._�5'      ]� .+�5(      �� $��20��5)      $��20��5*      $��20,2,0,0q�5+      $
��Left=�5,      
 � Cursor$

 Hand��5-      ��5.      �� 5/   "    �� 
TargetType" ��6(   �50   &   �� 51   *    �� Property � �� �� Value$ ../Image/power (1).png��6C    �� Triggers 53   &   �� 54   *    �� Binding 66   �� *IsStoppedSystem+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� Value True6�   a�55   .   �� 56   2    � ��$ ../Image/power (2).png��6K   58   +   �� 59   *    66   �� *IsStoppedSystem+$ TwoWay=�$ PropertyChanged=�	 False6�   a�5:   .   �� 5;   2    � ��$ ../Image/power (1).png��6K   5=   +   5?   #    J� InputBindings 5A      d� 5B   "    d� MouseAction$ 	LeftClicke�6U    �� Command 6/   �� *StopSystemCommand+6U   5D      �� 5E      $��15��5F      $��15��5G      $��0,3,20,0q�5H      $��Right=�5I      $

 Hand��5J      $��../Image/exit.png��5K       5L      d� 5M   "   $ 	LeftClicke�5P   %    5N   %   �� *CloseWindowCommand+ �� CommandParameter 5O   %   ��  �� ElementName$ 
MainWindow��5P   %   5R      5S       5U      d� 5V      $ 	LeftClicke�5Y       5W      �� *DragWindowCommand+ 5X      �� $ 
MainWindow��5Y      5[      �� 5]      $��1��5^      $
��Auto=�5_      $
��Auto=�5`      .��5a      ��    HouseTempate#��[  6?   ��6%   �� *House+6?   5b      5c      5d      5f      