   M S B A M L   `   `   `  ����K  GKursovaya_ONIT_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kursovaya_ONIT_3Kursovaya_ONIT_3  5   	   (    "Kursovaya_ONIT_3.LogOfRecordsTable   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Kursovaya_ONIT_3     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$! Журнал записей��5	   	   $	��608��6    $
��1076��6-   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
DataTable3��5   *      CanUserAddRows .  $
��Left=�6<   $	��185��6W   $��	10,10,0,0q�6d   $	��Top=�6w   $
��1034��6�   �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
10,384,0,0q�6?   $	��Top=�6S   $	��204��6k   $��18(�6w   6�   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��517,384,0,0q�6>   $	��Top=�6S   $	��204��6k   $��18(�6x   6�   �� 5   
   -   5        $	��fio��5      $
��Left=�6   $��110,208,0,0q�69   $	��Top=�6l   $	��120��6�    �� IsDropDownOpen . 6�   �� 5   
   -   5        $��	treatment��5      $
��Left=�6$   $��110,313,0,0q�6?   $	��Top=�6t   $	��120��6�    J� RenderTransformOrigin$ -1.735,-0.581&�6�    . 6�   �� 5   
   -   5        $
��date��5      $
��Left=�6   $��23��69   $��110,241,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   �� 5   
   $��ФИО клиента��6   $
��Left=�6&   $��
10,205,0,0q�6A   $	��Top=�6U   �� 5   
   $��Дата записи��6   $
��Left=�6&   $��
10,239,0,0q�6A   $	��Top=�6U   �� 5   
   $��Процедура��6   $
��Left=�6$   $��
10,313,0,0q�6?   $	��Top=�6S   �� 5   
   -   5         ��Name$ 	date_Copy��5      $
��Left=�6%   $��23��6@   $��110,284,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   $��Время записи��6   $
��Left=�6'   $��
10,282,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $��ClientCheckBox��5      $+��%Отображать клиентов��6)   $
��Left=�6G   $��18��6b   $��293,223,0,0q�6n   $	��Top=�6�   $	��144��6�   6�   �� 5   
   -	   5        $��TreatmentCheckBox��5      $'��!Отображать услуги��6,   $
��Left=�6H   $��18��6c   $��293,270,0,0q�6o   $	��Top=�6�   $	��144��6�   6�   5      5      