   M S B A M L   `   `   `  ���� E  Aturniej v2, Version=2.1.3.7, Culture=neutral, PublicKeyToken=null'clr-namespace:turniej_v2
turniej_v2      turniej_v2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:turniej_v2       � Title$  
MainWindow��$
��1080��$
��1920�� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � Cursor$ 
normal.cur��.��� .+��� -    ��Name$ 
background��$O��ILOL_CMS_309_Tile_01-Feature_H00-V50-min_1l8rc5dxueggbt78ktgw-1200x630.png��$
��Fill=�� -    �Name$ player1��$��
80,80,0,80q����#675831$
��Left=�$	��680��.+��� $	��100��$��
10,10,10,0q�$	��Top=����#000000�� $	��100��$��
10,0,10,10q�$��Bottom=����#000000�� -   $ img1p��$��10,115,10,120q�$��default.jpg��$
��Fill=��� -    ��Name$	 p1r��$�� ��$��25,0,450,25q����#DD3030$��70��$��Bottom=��� -   $	 p1g��$�� ��$��236,0,236,25q����#30DD30$��70��$��Bottom=��� -   $	 p1b��$�� ��$��450,0,25,25q����#3030DD$��70��$��Bottom=��� -    ��Name$ p1points��$��0��$
��Left=�$��	22,19,0,0q�$	��Top=�$��81��$	��636��$
��Bold"�
�������$��48(��� -   $ img1set��$�� ��$
��Left=�$��
10,115,0,0q�$	��Top=�$	��660��$	��677�����	#00DDDDDD���	#00707070 J� Opacity$ 0Q��� -	   $ g1btn��$��
10,0,0,120q�$
��Left=�$	��215��$��89��$��Bottom=����#30DD30�� -
   $ b1btn��$��
0,0,10,120q�$��89��$��Bottom=�$��Right=�$	��215�����#DD3030�� -   	 ��Name$	 p1select�����	#FF3030DD$��10,115,10,120q�$��15q�$y�Hidden=�� -   $ player2��$��1152,80,0,80q����#675831$
��Left=�$	��680��.+��� $	��100��$��
10,10,10,0q�$	��Top=����#000000�� $	��100��$��
10,0,10,10q�$��Bottom=����#000000�� -   $ img2p��$��10,115,10,120q�$��default.jpg��$
��Fill=��� -   $	 p2r��$�� ��$��25,0,450,25q����#DD3030$��70��$��Bottom=��� -   $	 p2g��$�� ��$��236,0,236,25q����#30DD30$��70��$��Bottom=��� -   $	 p2b��$�� ��$��450,0,25,25q����#3030DD$��70��$��Bottom=��� -   $ p2points��$��0��$
��Left=�$��	22,19,0,0q�$	��Top=�$��81��$	��636��$
��Bold"�
�������$��48(��� -   $ img2set��$�� ��$
��Left=�$��
10,115,0,0q�$	��Top=�$	��660��$	��677�����	#00DDDDDD���	#00707070$ 0Q��� -   $ g2btn��$��
10,0,0,120q�$
��Left=�$	��215��$��89��$��Bottom=����#30DD30�� -   $ b2btn��$��
0,0,10,120q�$��89��$��Bottom=�$��Right=�$	��215�����#DD3030�� -   $	 p2select�����	#FF3030DD$��10,115,10,120q�$��15q�$y�Hidden=�� $��765,170,0,0q�$	��902��$	��Top=�$
��Left=�$	��382��.+��� ���#675831$
��Left=�$	��226��$��0,0,0,7q�$��Bottom=�$	��382���� $��
10,0,10,81q�
���   �$	��141��$��Bottom=��� -   $ 	kategorie��$��category��$��20,0,20,105q�
�������$
��Bold"�$��48(�$��76��$��Bottom=�A� 
���   �$��105,0,105,271q�$	��173��$��Bottom=��� -   $
 time��$
��time��$��105,488,105,271q�
�������$
��Bold"�$��72(�$	��172��$��Center=��� -   $ 
timeButton��$��105,0,105,271q�$	��173��$��Bottom=�$ 0Q��� 
���   �$��
10,0,10,17q�$��59��$��Bottom=��� -   $ questionPoints��$	��200��$��
20,0,20,30q�
�������$
��Bold"�$��24(�$��37��$��Bottom=��� -   $ losuj��$��
10,0,10,81q����	#00000000$	��141��$��Bottom=����	#00707070$ 0Q��� -   $ setPointsButton��$��
10,0,10,17q�$��59��$��Bottom=�$ 0Q��� -   
 ��Name$
 whoFirst��$��49��$��165,371,165,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��Stretch=����	#40FFFFFF$��50�� �� CharacterCasing$ Lower=� J� RenderTransformOrigin$ 0.5,0.5&�$ 0Q�� -   $ commandGrid��$y�Hidden=�.+��� 
���   �$
��Left=�$
��1072��$	��Top=�$
��1912��$	 0.1Q�� $��200,200,200,300q����#675831.+��� $��15q����#000000�� -   $
 
commandBox��$��45,0,45,129q�$��36(�$
��Bold"�$��58��$��Bottom=��� -   $ sumbit��$��1279,0,45,45q�$��Submit��$��36(�$
��Bold"�$��62��$��Bottom=��� $��45,0,45,215q�$	��314��$��Bottom=�$
��Bold"�$��24(�
�������$����p1/p2 (filename/random/randomcat)
set category c1,c2,c3,c4
set points p1/p2/q [int]
set background/localbackground
set time seconds��