   M S B A M L   `   `   `  ����K  GKursovaya_ONIT_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Kursovaya_ONIT_3.WPFKursovaya_ONIT_3.WPF  5   	   )    #Kursovaya_ONIT_3.WPF.TreatmentTable   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Kursovaya_ONIT_3.WPF     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Процедуры��5	   	   $	��450��6   $	��800��6(   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
DataTable2��5   *      CanUserAddRows .  $
��Left=�6=   $	��185��6X   $��	10,10,0,0q�6e   $	��Top=�6x   $	��606��6�   �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
10,384,0,0q�6?   $	��Top=�6S   $	��151��6k   $��18(�6w   6�   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��610,384,0,0q�6>   $	��Top=�6S   $	��128��6k   $��18(�6w   6�   �� 5   
   -   5        $��
MasterName��5      $
��Left=�6$   $��23��6?   $��
10,356,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $��Duration��5      $
��Left=�6#   $��23��6>   $��
10,309,0,0q�6J   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $
��Cost��5      $
��Left=�6   $��23��6:   $��
10,263,0,0q�6F   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $��NameOfTreatment��5      $
��Left=�6)   $��23��6D   $��
10,220,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   $)��#Название процедуры��6   $
��Left=�6-   $��
10,195,0,0q�6H   $	��Top=�6\   �� 5   
   $+��%Стоимость процедуры��6   $
��Left=�6.   $��
10,238,0,0q�6I   $	��Top=�6]   �� 5   
   $1��+Длительность процедуры��6   $
��Left=�61   $��
10,284,0,0q�6L   $	��Top=�6`   �� 5   
   $��Имя мастера��6   $
��Left=�6&   $��
10,332,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $��DurationMin��5      $
��Left=�6%   $��23��6@   $��247,352,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -	   5        $��DurationMax��5      $
��Left=�6%   $��23��6@   $��401,352,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�    J� RenderTransformOrigin$ 0.118,1.247&�6�   �� 5   
   -
   5        $/��)Отобразить подходящие��5      $
��Left=�61   $��247,384,0,0q�6L   $	��Top=�6a   $	��284��6y   $��18(�6�   6�   �� 5   
   -   5        $��CostMin��5      $
��Left=�6!   $��23��6<   $��247,304,0,0q�6H   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $��CostMax��5      $
��Left=�6!   $��23��6<   $��401,304,0,0q�6H   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   $+��%Стоимость процедуры��6   $
��Left=�6.   $��247,274,0,0q�6I   $	��Top=�6^   �� 5   
   $��До:��6   $
��Left=�6   $��370,302,0,0q�69   $	��Top=�6N   �� 5   
   $1��+Длительность процедуры��6   $
��Left=�61   $��247,327,0,0q�6L   $	��Top=�6a   �� 5   
   $��От:��6   $
��Left=�6   $��216,302,0,0q�69   $	��Top=�6N   �� 5   
   $��От:��6   $
��Left=�6   $��216,350,0,0q�69   $	��Top=�6N   �� 5    
   $��До:��6   $
��Left=�6   $��370,350,0,0q�69   $	��Top=�6N   �� 5!   
   -   5        $��Убрать фильтр��5!      $
��Left=�6)   $��
627,28,0,0q�6D   $	��Top=�6X   $	��132��6p   $��18(�6|   6�   �� 5"   
   $/��)Дробные числа через ',' ��6   $
��Left=�63   $��317,249,0,0q�6N   $	��Top=�6c   5$      5%      