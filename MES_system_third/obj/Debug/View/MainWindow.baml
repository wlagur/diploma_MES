   M S B A M L   `   `   `  ����  MES_system_third&     MES_system_third.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$	  MES��5   	   $
��1350��5   	   $	��600��5   	   .��5      � .+�5
   
   o� 
������� o� 
IsMainMenu . .@�5      m� $��	_Файл��6   .@�5      m� $��_Сохранить��6   m� 5      $��_Выйти��6   5      m� 5      $��_Помощь��6   .@�5      m� $��_Справка��6   5      5      �� 5   
   $��
0,21,0,-21q�6   .@�5      �� $��Заказы��6   .��5      � .+�5      �� $	��150��6   $	��185��5      $��	10,10,0,0q�5      $
��Left=�5      $	��Top=�5       �� DisplayMemberPath$
 Name��5      $��9(�5      ��5      ��  �� Path$ ListOfOrders� �� SelectedItem 5      �� $ NewOrder� �� Mode$ TwoWay=�	� 5!      $��425,70,702,446q�6"   $%��Новый автомобиль��5"   "    	� 	GroupName$ new_car��5#   "    d� 	IsChecked 5$   "   �� $ flag_new_car�$ TwoWay=�	� 5%      $��165,70,916,446q�6"   $3��-Существующий автомобиль��5&   "   $ new_car��5'   "   :  4System.Windows.Controls.Primitives.DatePickerTextBox  5)      $��270,10,916,506q�6(   ��6@   �� $ NewOrder.dateTime�$ TwoWay=��� 5*      $��484,16,702,500q�6   $��Статус��6b    67   �� $ NewOrder.status�6b   �� 5+      $	��150��6   $��25��5,      $��
270,40,0,0q�5-      $
��Left=�5.      $	��Top=�5/      $ FullName��50       51      �� $ NewOrder.worker�$ TwoWay=���52      �� $ ListOfWorkers��� 53      $	��100��6   $��25��54      $��
165,10,0,0q�55      $
��Left=�56      $	��Top=�57      $��Дата и время��58      �� 59      $	��100��6   $��25��5:      $��
165,40,0,0q�5;      $
��Left=�5<      $	��Top=�5=      $��Рабочий��5>       J� RenderTransformOrigin$ 	0.53,0.56&�5?      � 5@      {�6   �� $ flag_old_car�.+�5A      �� $	��150��6#   $��25��5B   #   $��270,100,0,0q�5C   #   $
��Left=�5D   #   $	��Top=�5E   #   $ registrNumber��5F   #    5G   #   �� $ NewOrder.car�$ TwoWay=���5H   #   �� $ 
ListOfCars��� 5I      $	��100��6    $��25��5J       $��165,100,0,0q�5K       $
��Left=�5L       $	��Top=�5M       $��Автомобиль��5N       5O      � 5P      {�6   �� $ flag_new_car�.+�5Q      �� $	��125��6"   $��25��5R   "   $��510,100,0,0q�5S   "   $
��Left=�5T   "   $	��Top=�5U   "   ��5V   "   �� $ NewOrder.car.vincod�$ TwoWay=��� 5X      $	��125��6"   $��25��5Y   "   $��510,130,0,0q�5Z   "   $
��Left=�5[   "   $	��Top=�5\   "   ��5]   "   �� $  NewOrder.car.registrNumber�$ TwoWay=��� 5_      $	��125��6#   $��25��5`   #   $��510,160,0,0q�5a   #   $
��Left=�5b   #   $	��Top=�5c   #   $ nameMarkOfCar��5d   #    5e   #   �� $' !NewOrder.car.modelofcar.markofcar�$ TwoWay=���5f   #   �� $ ListOfMarks��� 5g      $	��125��6#   $��25��5h   #   $��510,190,0,0q�5i   #   $
��Left=�5j   #   $	��Top=�5k   #   $ nameModelOfCar��5l   #    5m   #   �� $ NewOrder.car.modelofcar�$ TwoWay=���5n   #   �� $ ListOfModels��� 5o      $	��125��6#   $��25��5p   #   $��510,220,0,0q�5q   #   $
��Left=�5r   #   $	��Top=�5s   #   $ nameColorOfCar��5t   #    5u   #   �� $ NewOrder.car.colorofcar�$ TwoWay=���5v   #   �� $ ListOfColors��� 5x      $��80��6    $��25��5y       $��425,100,0,0q�5z       $
��Left=�5{       $	��Top=�5|       $��
VIN-код��5}       �� 5~      $��80��6    $��25��5       $��425,130,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��
Номер��5�       �� 5�      $��80��6    $��25��5�       $��425,160,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��
Марка��5�       �� 5�      $��80��6    $��25��5�       $��425,190,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��Модель��5�       �� 5�      $��80��6    $��25��5�       $��425,220,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��Цвет��5�       	� 5�      $��425,262,702,254q�6&   $��Новый клиент��5�   "   $ 
new_client��5�   "    5�   "   �� $ flag_new_client�$ TwoWay=�	� 5�      $��165,262,916,254q�6&   $+��%Существующий клиент��5�   "   $ 
new_client��5�   "   � 5�      {�6   �� $ flag_old_client�.+�5�      �� $��80��6$   $��25��5�       $��161,291,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��Клиент��5�       �� 5�      $	��125��6'   $��25��5�   #   $��246,291,0,0q�5�   #   $
��Left=�5�   #   $	��Top=�5�   #   $ FullName��5�   #    5�   #   �� $ NewOrder.car.client�$ TwoWay=���5�   #   �� $ ListOfClients�5�      � 5�      $��0,195,0,-195q�6J   {�6   �� $ flag_new_client�.+�5�      �� $	��125��6&   $��25��5�   "   $��510,100,0,0q�5�   "   $
��Left=�5�   "   $	��Top=�5�   "   ��5�   "   �� $" NewOrder.car.client.lastName�$ TwoWay=��� 5�      $	��125��6&   $��25��5�   "   $��510,130,0,0q�5�   "   $
��Left=�5�   "   $	��Top=�5�   "   ��5�   "   �� $# NewOrder.car.client.firstName�$ TwoWay=��� 5�      $	��125��6&   $��25��5�   "   $��510,160,0,0q�5�   "   $
��Left=�5�   "   $	��Top=�5�   "   ��5�   "   �� $$ NewOrder.car.client.middleName�$ TwoWay=��� 5�      $	��125��6&   $��25��5�   "   $��510,190,0,0q�5�   "   $
��Left=�5�   "   $	��Top=�5�   "   ��5�   "   �� $ NewOrder.car.client.phone�$ TwoWay=��� 5�      $	��125��6&   $��25��5�   "   $��510,220,0,0q�5�   "   $
��Left=�5�   "   $	��Top=�5�   "   ��5�   "   �� $ NewOrder.car.client.email�$ TwoWay=��� 5�      $��80��6$   $��25��5�       $��425,100,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��Фамилия��5�       �� 5�      $��80��6$   $��25��5�       $��425,130,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��Имя��5�       �� 5�      $��80��6$   $��25��5�       $��425,160,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��Отчество��5�       �� 5�      $��80��6$   $��25��5�       $��425,190,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��Телефон��5�       �� 5�      $��80��6$   $��25��5�       $��425,220,0,0q�5�       $
��Left=�5�       $	��Top=�5�       $��E-mail��5�       5�      5�      �� 5�      $	��150��6   $��25��5�      $��165,467,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $!��Добавить заказ��5�      ��5�      �� *AddOrderCommand+5�      �� 5�      $	��150��6   $��25��5�      $��320,467,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $!��Изменить заказ��5      ��5�      �� *UpdateOrderCommand+5      5     5     �� 5     $��Планирование��6   .��5     � .+�5     �� $	��150��6   $	��185��5     $��	10,10,0,0q�5     $
��Left=�5     $	��Top=�5	     $
 Name��5
     $��9(�5     ��5     �� $ ListOfOrders� 5     �� *SelectedOrder+$ TwoWay=��� 5     $	��150��6   $��25��5     $��
10,260,0,0q�5     $
��Left=�5     $	��Top=�5     $��Сохранить��5     ��5     �� *ColorButtonSave+��5     �� *SaveCommand+5     �� 5     $	��150��6   $��25��5     $��
10,230,0,0q�5     $
��Left=�5     $	��Top=�5     $#��Добавить процес��5     ��5     �� *AddProcessCommand+.  (System.Windows.Interactivity.Interaction	   Triggers	 5      /  )System.Windows.Interactivity.EventTrigger  5!     
   	EventName$
 Click��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 5"  "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *CommandColorButtonSave+5#     5%     �� 5&     $	��150��6   $��25��5'     $��
10,200,0,0q�5(     $
��Left=�5)     $	��Top=�5*     $!��Удалить процес��5,     ��5+     �� *DeleteProcessCommand+	 5-       5.     $
 Click��6-   . 5/  "      68   �� *CommandColorButtonSave+50     52     �� 54     $	��820��6   $	��275��55     $��
165,10,0,0q�56     $
��Left=�57     $	��Top=�58     ��59     �� $ ListOfProcesses� 5:     �� $ SelectedProcess�$ TwoWay=���5<     �� 5=      �� 
TargetType" ��6$   .�5>  "   ��  �� Property � �� �� Value 6?   �� $ operation.ColorBrush�5?      �� View 5A     �� 5B     .P�5C  "   �� $��Операция��61    �� CellTemplate 5D  &   �� 5E  *   .R�5F  .   ��  �� Orientation$ 
Horizontal=�69   .+�5G  2   �� $	��170��6;   $ nameOperation��5H  ;   ��5I  ;   ��  �� RelativeSource ��  �� AncestorType$ ListBoxL�$" DataContext.ListOfOperations� 5K  ;   �� $ 	operation�$ TwoWay=�	 5M  6     5N  :   $
 SelectionChanged��6I   . 5O  >      6T   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5P  ;   5R  3   5S  /   5T  +   5V  #   �� 5W  "   $��Деталь��61    5X  &   �� 5Y  *   .R�5Z  .   �� $ 
Horizontal=�69   .+�5[  2   �� $	��150��6;    �� 
IsEditable .  �� 
IsReadOnly . ��5\  ;   �� $ ListProcess_has_detail� 5]  ;   �� $ detail�$ TwoWay=���5_  ;   �� $ operation.ColorBrush� �� Text 5b  ;   �� $ NameDetails�$ OneWay=���5c  6   �� 5d  :   .R�5e  >   �� $ 
Horizontal=�6I   .+�5f  B   ��  6K   �� *FlagProcess_has_detail+�� 5g  B   ��6L   �� $. (detail.standartdetail.nameStandartDetail�5h  ?   5i  ;   	 5k  6     5l  :   $
 SelectionChanged��6I   . 5m  >      6T   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5n  ;   5p  3   5q  /   5r  +   5t  #   �� 5u  "   $��Начало��61    5v  &   �� 5w  *   .R�5x  .     $	��130��6@   ��5y  @   �� $ operation.ColorBrush���5z  @   �� $ dateTimeStart�$ TwoWay=�.��5{  ]   	 5|  2     5}  6   $
 SelectionChanged��6E   . 5~  :      6P   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5  7   .��5�  J   5�  /   5�  +   5�  #   �� 5�  "   $��
Конец��61    5�  &   �� 5�  *   .R�5�  .     $	��130��6@   ��5�  @   �� $ operation.ColorBrush���5�  @   �� $ dateTimeFinish�$ TwoWay=�.��5�  ]   	 5�  2     5�  6   $
 SelectionChanged��6E   . 5�  :      6P   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5�  7   .��5�  J   5�  /   5�  +   5�  #   �� 5�  "   $��Рабочий��61    5�  &   �� 5�  *   .R�5�  .   �� $ 
Horizontal=�69   .+�5�  2   �� $	��170��6;   $ FullName��5�  ;   ��5�  ;   ��  �� $ ListBoxL�$ DataContext.ListOfWorkers� 5�  ;   �� $ worker�$ TwoWay=� � ToolTip 5�  6   _� 5�  :   ���	#90004455.��5�  >   �� .+�5�  B   �� $��3q�6L   
�������$6��0Подсказка выбора рабочего��6j   �� 5�  B   ���	#90004455��6K   �� $ operation.ListWorkers� 5�  F   �� 5�  J   .P�5�  N   �� $��Рабочий��6]    5�  R   �� 5�  V   .R�5�  Z   �� 
���������6w   �� $ worker.FullName�5�  W   5�  O   �� 5�  N   $��Уровень��6]    5�  R   �� 5�  V   .R�5�  Z   �� 
���������6w   �� $ level�5�  W   5�  O   5�  K   5�  C   5�  ?   5�  ;   	 5�  6     5�  :   $
 SelectionChanged��6I   . 5�  >      6T   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�  5�  >    6T   ��  �� $ ListBoxL�$- 'DataContext.CommandChangeWokerInProcess�5�  ;   5�  3   5�  /   5�  +   5�  #   5�     5�     �� 5�     $	��150��6   $��10,290,0,10q�5�     $
��Left=�5�     $ FullName��5�     $��9(�5�     ��5�     �� $ ListOfWorkers� 5�     �� *SelectedWorker+$ TwoWay=��� 5�     $��165,290,10,10q�6   ��66   �� $ ListOfLoadingWorker���5�     �� 5�     " ��6$   .�5�  "   ��  � �� 6?   �� $ operation.ColorBrush�5�      5�     �� 5�     .P�5�  "   �� $��Операция��61    5�  &   �� 5�  *   .R�5�  .   �� $ 
Horizontal=�69   .+�5�  2   �� $	��170��6;   $ nameOperation��5�  ;   ��5�  ;   ��  �� $ ListBoxL�$" DataContext.ListOfOperations� 5�  ;   �� $ 	operation�$ TwoWay=�	 5�  6     5�  :   $
 SelectionChanged��6I   . 5�  >      6T   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5�  ;   5�  3   5�  /   5�  +   5�  #   �� 5�  "   $��Деталь��61    5�  &   �� 5�  *   .R�5�  .   �� $ 
Horizontal=�69   .+�5�  2   �� $	��150��6;   ��5�  ;   �� $ ListProcess_has_detail� 5�  ;   �� $ detail�$ TwoWay=���5�  6   �� 5�  :   .R�5�  >   �� $ 
Horizontal=�6I   .+�5�  B   ��  6K   �� *FlagProcess_has_detail+�� 5�  B   ��6L   �� $. (detail.standartdetail.nameStandartDetail�5�  ?   5�  ;   	 5�  6     5�  :   $
 SelectionChanged��6I   . 5   >      6T   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5  ;   5  3   5  /   5  +   5  #   �� 5  "   $��Начало��61    5	  &   �� 5
  *   .R�5  .     $	��130��6@   ��5  @   �� $ operation.ColorBrush���5  @   �� $ dateTimeStart�$ TwoWay=�.��5  ]   	 5  2     5  6   $
 SelectionChanged��6E   . 5  :      6P   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5  7   .��5  J   5  /   5  +   5  #   �� 5  "   $��
Конец��61    5  &   �� 5  *   .R�5  .     $	��130��6@   ��5  @   �� $ operation.ColorBrush���5  @   �� $ dateTimeFinish�$ TwoWay=�.��5  ]   	 5  2     5   6   $
 SelectionChanged��6E   . 5!  :      6P   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�5"  7   .��5#  J   5$  /   5%  +   5'  #   �� 5(  "   $��Рабочий��61    5)  &   �� 5*  *   .R�5+  .   �� $ 
Horizontal=�69   .+�5,  2   �� $	��170��6;   $ FullName��5-  ;   ��5.  ;   ��  �� $ ListBoxL�$ DataContext.ListOfWorkers� 50  ;   �� $ worker�$ TwoWay=�	 51  �     52  :   $
 SelectionChanged��6I   . 53  >      6T   ��  �� $ ListBoxL�$( "DataContext.CommandColorButtonSave�  54  >    6T   ��  �� $ ListBoxL�$- 'DataContext.CommandChangeWokerInProcess�55  ;   57  3   58  /   59  +   5;  #   5<     5>     �� 5@     $	��275��6#   $��990,10,10,0q�5A  #   $	��Top=�5B  #   $��Visible=�5C  #   $��Visible=�5D  #   .��5E     �� $	��700��6'   $	��275��5F  '   ��5G  '   �� $ ListOfRectanglesOrder���5H     �� 5I  "   .R�5J  &   �� ���	#FFF6F8FB6-   5K  #   ��5M     �� 5N  "   " ��6(   .�5O  &   ��  �@��Left 6D   �� $ X��� 5P  &    �@��Top 6C   �� $	 (Y)�5Q  #   ��5S     �� 5T  "   .R�5U  &   � .+�5V  *   �� $��24��5W  4   ��5V  4   �� $ Width���5X  4   �� $ Color��� 5Y  *   $��Center=�64   
���   ���5[  4   �� $ DuringString�5\  '   5]  #   5_     5`     5a     5b     5c     5e     5f     