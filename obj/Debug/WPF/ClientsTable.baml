   M S B A M L   `   `   `  ����K  GKursovaya_ONIT_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Kursovaya_ONIT_3.WPFKursovaya_ONIT_3.WPF  5   	   '    !Kursovaya_ONIT_3.WPF.ClientsTable   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Kursovaya_ONIT_3.WPF     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Клиенты��5	   	   $	��450��6   $	��800��6&   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	DataTable��5         CanUserAddRows .  $
��Left=�6;   $	��185��6V   $��12,9,0,0q�6c   $	��Top=�6u   $	��606��6�   �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
12,384,0,0q�6?   $	��Top=�6S   $	��204��6k   $��18(�6w   6�   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��522,384,0,0q�6>   $	��Top=�6S   $	��204��6k   $��18(�6w   6�   �� 5   
   -   5        $��_TelNum��5      $
��Left=�6"   $��23��6=   $��
12,356,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   $��18(�6�   �� 5   
   -   5        $
��_FIO��5      $
��Left=�6   $��23��6:   $��
10,308,0,0q�6F   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��153��6�   $��18(�6�   �� 5   
   $��ФИО клиента:��6   $
��Left=�6'   $��
10,275,0,0q�6B   $	��Top=�6V   $��18(�6n   �� 5   
   $"��Номер телефона:��6   $
��Left=�6*   $��
10,323,0,0q�6E   $	��Top=�6Y   $��18(�6q    J� RenderTransformOrigin$ 0.414,0.324&�6   �� 5   
   -   5         ��Name$ _TelNum_Copy��5      $
��Left=�6)   $��23��6D   $��
12,356,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   $��18(�6�   �� 5   
   -   5        $ Search��5      $
��Left=�6#   $��23��6>   $��264,311,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��153��6�   $��18(�6�   �� 5   
   -   5        $��
Найти��5      $
��Left=�6!   $��264,384,0,0q�6<   $	��Top=�6Q   $	��204��6i   $��18(�6u   6�   �� 5   
   $��ФИО клиента:��6   $
��Left=�6'   $��264,275,0,0q�6B   $	��Top=�6W   $��18(�6o   �� 5   
   -	   5        $��Убрать фильтр��5      $
��Left=�6)   $��264,352,0,0q�6D   $	��Top=�6Y   $	��195��6q   $��18(�6}   6�   5      5      