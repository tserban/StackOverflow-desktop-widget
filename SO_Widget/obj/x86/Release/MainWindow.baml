   M S B A M L   `   `   `  ����   	SO_Widget    SO_Widget.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  StackOverflow Widget�� � AllowsTransparency .  J� Opacity$	 0.8Q� � WindowStyle$
 None=�$	��150��$	��255�� � ShowInTaskbar .   � 
ResizeMode$ NoResize=�
������  � ContextMenu �� .@�m� -   $��Always On Top��.���  � ColumnDefinitions �� $��* ��� $��0.12* �.+�� $��5,5,8,12q�.+��� $��1q� �� CornerRadius$ 10,10,10,10��
���   �
�����F�	 J� Effect	 3  -System.Windows.Media.Effects.DropShadowEffect  
   
BlurRadius$
 15Q�._��  � RowDefinitions �� $��* ��� $��* ��� $
��0.8* ��� $
��0.8* � �� $��* ��� $��0.55* ��� $��0.45* �.+��� $��img\SO_logo.png��$��3���� -   $��RepLabel��$��10,5,0,0q�$��1��
�������$
��Bold"�$��Reputation:���� -   $��ValLabel��$��0,5,0,0q�$��1��$��1��
�������$
��Bold"�$�� ���� -   $��	DiffLabel��$��0,5,0,0q�$
��Left=�$y�Hidden=�$��1��$��2��
�������$
��Bold"�$�� ���� $��10,2,0,0q�$��2��$��0��$��10(�
�������$��Last update:���� -   $��LastUpdLabel��$��0,2,0,0q�$��2��$��1��$��10(�
�������$�� ���� -   $��ProfileLabel��$��10,0,0,0q�$��3��$��0��$��10(�
�������$��View Profile���� -   $��RefreshLabel��$��3��$��1��$��10(�
�������$��Refresh��� $��1��.+��� -	   $��CloseImg��$��img\close.png��$
��Left=�$	��Top=�$��0,2,0,0q�$��20��$��20��	    � ToolTip$ Close���� -
   $��DiscImg��$��img\disc.png��$
��Left=�$	��Top=�$��0, 28, 0, 0q�$��20��$��20��	   $ Connection failed��