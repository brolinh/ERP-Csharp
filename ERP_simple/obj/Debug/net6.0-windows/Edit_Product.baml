   M S B A M L   `   `   `  ����E  AERP_simple, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ERP_simple
ERP_simple  5   	       ERP_simple.Edit_Product   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ERP_simple     5   	     � Title$  Edit_Product��5   	   $	��562��6   $	��910��6+   .��5	      � .+�5   
   �� -   5         ��Name$ ProductTable��5      $
��Left=�5      $	��230��5      $��	23,10,0,0q�5      $	��Top=�5      $	��640��5       �� SelectedValuePath$
 Name��5       �� SelectionMode$ Single=�5      ��5      �� *dt+ �� SelectedValue 5      ��  �� Path$ SelectedEmployee� �� View 5      �� 5      -   5        	GridView1��.P�5      �� $
��Name��5   !    �� Width$	 100��6/    �� DisplayMemberBinding 5   %   �� $
 Name�5   /   �� 5      $��Quantity��5   !   $	 100��63    5   %   �� $ Quantity�5   3   �� 5      $��Description��5   !   $	 400��66    5   %   �� $ Description�5   6   5       ��5"      �� 5#      	 �� 
TargetType"	 ��6   .�5$      -   5        5%      5'      �� 5(   
   $
��Name��6   $
��Left=�6   $��30��6:   $��
20,260,0,0q�6F   $	��Top=�6Z   $	��100��6r   $��16(�6~   �� 5)   
   -   5        
 ��Name$
 
UpdateName��5)      $
��Left=�6&   $��40��6A   $��130,260,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��150��6�   $��16(�6�   �� 5*   
   -   5         ��Name$ UpdateProductBtn��5*      $��Update��6+   $
��Left=�6<   $��40��6W   $��440,330,0,0q�6c   $	��Top=�6x   $	��150��6�   $��16(�6�   6�   �� 5+   
   $��Quantity��6   $
��Left=�6#   $��40��6>   $��
20,320,0,0q�6J   $	��Top=�6^   $	��100��6v   $��16(�6�   �� 5,   
   -   5        $
 UpdateQuantity��5,      $
��Left=�6*   $��40��6E   $��130,320,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��150��6�   �� 5-   
   $��Description��6   $
��Left=�6&   $��40��6A   $��
20,400,0,0q�6M   $	��Top=�6a   $	��100��6y   $��16(�6�   �� 5.   
   -   5        $
 UpdateDescription��5.      $
��Left=�6-   $��92��6H   $��130,400,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��250��6�   �� 5/   
   -   5        $ DeleteProductBtn��5/      $��Delete��6+   $
��Left=�6<   $��40��6W   $��440,260,0,0q�6c   $	��Top=�6x   $	��150��6�   $��16(�6�   6�   50      51      