   M S B A M L   `   `   `  ����G  CDziennikOcen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DziennikOcenDziennikOcen  5   	       DziennikOcen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DziennikOcen     5   	     � Title$  	Logowanie��5   	   $	��450��6   $	��450��6(    � 
ResizeMode$ CanMinimize=�64    � ShowInTaskbar$ False��6M   .��5	      � ���	#FFC7B39F.+�5
   
   � $��10,10,10,10q�6   
�������.+�5      �� $��Center=�6   $��27��65   $
��Wrap=�6A   $	��Top=�6U   $	��200��6m   $��0,28,0,0q�6y   $��20(�6�   $��Franklin Gothic Medium)�6�   $��Medium&�6�   $��Normal"�6�    �� TextAlignment$ Center=�6�   �� 6�   $�Menu logowania��6  �� 6  6'  �� 5      $��Center=�6   $��17��65   $��0,51,0,0q�6A   $
��Wrap=�6S   $	��Top=�6g   $	��250��6   $
��Bold"�6�    J� Opacity$ 0.805Q�6�   $ Center=�6�   ���	#FF806E6E�� 6�    � Language$ pl-pl�6�   $,�&Proszę wprowadź swój login i hasło��6�   6  �� 5      -   5         ��Name$ nazwaUzytkownika��5      $��Center=�60   $��50��6M   $��0,92,0,0q�6Y    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��200��6�   $��Center=�6�   $��Center=�6�   $��0,0,0,0q�6�   ���	#FFE8E8E86  G� 5      -   5         G�Name$ hasloUzytkownika��5      ���	#FFE8E8E8$��Center=�6K   $��Center=�6o   $��Normal"�6�   ���	#FF979797$	��200��6�   $��50��6�   $��Center=�6�   $	��Top=�6�   $��	0,157,0,0q�6	  	� 5      -   5        	 	�Name$	 	jakoUczen��5      $��Jestem uczniem��6-   $��Center=�6F   $��28��6c   $��	0,223,0,0q�6o   $	��Top=�6�   $	��120��6�   
 	� 	GroupName$
 	ktoLoguje��6�   	� 5      -   5        $	 jakoNauczyciel��5      $��Jestem nauczycielem��62   $��Center=�6P   $��27��6m   $��	0,251,0,0q�6y   $	��Top=�6�   $	��134��6�   $
 	ktoLoguje��6�   �� 5      -   5         ��Name$ 
zalogujBtn��5      $��ZALOGUJ��6)   $��Center=�6;   $��30��6X   $��	0,283,0,0q�6d   $	��Top=�6w   $	��150��6�   ���	#FFD4AC66
�������$
��Bold"�6�   $��0,0,0,1q�6�   6�   �� 5      -   5        $ 
zmienHaslo��5      $��Zmień hasło��6)   $��Center=�6?   $��30��6\   $��	0,324,0,0q�6h   $	��Top=�6{   $	��150��6�   
�������$
��Bold"�6�   ���	#FF705151��6�   Z� 6�   5      5      5      