   M S B A M L   `   `   `  ����D  @MP3player, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MP3player	MP3player  5   	       MP3player.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MP3player     5   	     � Title$  
MP3 Player��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��70 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��0��6K   $��10q�6X   .+�5      �� -   5         ��Name$ btnOpenFile��5      $
��Open��6*   $��75��69   6D   �� 5      -   5        $ btnPlay��5      $
��Play��6&   $��75��65   6@   �� 5      -   5        $ btnPause��5      $��Pause��6'   $��75��67   6B   �� 5      -   5        $ btnStop��5      $
��Stop��6&   $��75��65   6@   5      �� 5   
   -   5        $��lstPlaylist��5      $��
10,18,10,0q�6%   $	��Top=�69   $	��250��6Q   $��1��6�   �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��2��6K   $��10q�6X   .+�5      �� -   5         ��Name$ 	sldVolume��5      $	��100��6(    � Minimum$ 0Q�64    � Maximum$ 1Q�6@   6L   �� 5      -   5        $ sldProgress��5      $	��300��6*   $ 0Q�66   $	 100Q�6B   6P   �� 5      -   5         ��Name$ lblCurrentTime��5      $��00:00��6,   $
��10,0q�6<   �� 5      $��/��6   $	��5,0q�6    �� 5      -	   5        $ lblTotalTime��5      $��00:00��6*   $��0,0,10,0q�6:   5      5      5      