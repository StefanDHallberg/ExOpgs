   M S B A M L   `   `   `  ����F  BWPFAndMVVM1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFAndMVVM1WPFAndMVVM1  5   	       WPFAndMVVM1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFAndMVVM1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$	 LB1��5
      $
��Left=�6R   $��	83,78,0,0q�6m   $	��Top=�6�   $	��150��6�   ��6   ��  �� ElementName$ 	firstName�� �� Path$
 Text�6�   �� 5   
   -   5         ��Name$ 	firstName��5      $
��Left=�6e   $��
363,86,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6%   �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ lastName��5      $
��Left=�5   	   $��
83,169,0,0q�6$   $
 Wrap=�68   $	��Top=�6L   $	��120��6d   ��5   $   �� $ FullName�$ PropertyChanged=� �� Mode$ TwoWay=�5   d   �� 5   
   -   5        $ fullName��5      $
��Left=�5      $��363,169,0,0q�6-   $
 Wrap=�6B   $	��Top=�6V   $	��120��6n   ��5   $   �� $ FullName�$ PropertyChanged=�$ OneWay=�5   n   �� 5   
   -   5        $ sliderBarText��5      $
��Left=�5      $��363,249,0,0q�6(   $
 Wrap=�6=   $	��Top=�6Q   $	��120��6i   ��5   )   �� $ MySlider��$ Value�$ PropertyChanged=�5   i   �� 5   
   -   5         ��Name$ MySlider��5      	 � Maximum$		 100Q�6#   
 � Minimum$
 0Q�61    �� TickPlacement$ BottomRight=�6=    �� TickFrequency$ 5Q�6Y    �� IsSnapToTickEnabled$
 True��6k    � Value$ 0Q�6�   $
��Left=�5      $��
96,249,0,0q�6,   $	��Top=�6@   $	��120��6X   6d   �� 5   
   -   5         ��Name$ Update_to_DateTime��5      $��Update-To-DateTime��6-   $��50��6J   $	��129��6V   $
��Left=�5      $��586,160,0,0q�6,   $	��Top=�6A   6Y   �� 5   
   -   5        $ Update_to_Text��5      $��Update-To-Text��6)   $��50��6B   $	��129��6N   $
��Left=�5      $��586,233,0,0q�6(   $	��Top=�6=   6U   5      5      