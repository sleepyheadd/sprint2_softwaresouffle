   M S B A M L   `   `   `  ����R  NSprint2_SoftwareSouffle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Sprint2_SoftwareSouffleSprint2_SoftwareSouffle  5   	   +    %Sprint2_SoftwareSouffle.managerScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Sprint2_SoftwareSouffle     5   	     � Title$  managerScreen��5   	   $	��312��6   $	��611��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ cplabel��5
      $��Create Profile��6!   $
��Left=�6:   $��10,0,0,0q�6U   $	��Top=�6g   $��25(�6   �� 5   
   -   5         ��Name$ newUsername��5      $
��Left=�6'   $��	15,43,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5   
   -   5        $ newPassword��5      $
��Left=�6'   $��	15,66,0,0q�6B   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5   
   -   5         ��Name$ createProfile��5      $��Create��6(   $
��Left=�69   $��	15,89,0,0q�6T   $	��Top=�6g   6   �� 5   
   -   5        $ accountAdded��5      $�� ��6&   $
��Left=�61   $��	70,89,0,0q�6L   $	��Top=�6_   $��99��6w   �� 5   
   -   5        $ modlabel��5      $��Modify Profile��6"   $
��Left=�6;   $��
15,135,0,0q�6V   $	��Top=�6j   $��25(�6�   �� 5   
   -   5        $ modifyUsername��5      $
��Left=�6*   $��
15,178,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��User To Modify��6�   �� 5   
   -   5        $ newModifiedPassword��5      $
��Left=�6/   $��
15,201,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $��New Password��6�   �� 5   
   -	   5        $ modifyButton��5      $��Modify��6'   $
��Left=�68   $��
15,224,0,0q�6S   $	��Top=�6g   6   �� 5   
   -
   5        $ accountModified��5      $�� ��6)   $
��Left=�64   $��
75,224,0,0q�6O   $	��Top=�6c   $	��139��6{   �� 5   
   -   5        $ Logout��5      $��Logout��6!   $
��Left=�62   $��530,222,0,0q�6M   $	��Top=�6b   6z   �� 5   
   -   5        $ recentlabel��5      $��Employee Activity��6%   $
��Left=�6A   $��
252,89,0,0q�6\   $	��Top=�6p   $��25(�6�   �� 5   
   -   5        $ 
mostRecent��5      $��No recent activity��6$   $
��Left=�6A   $��252,137,0,0q�6\   $	��Top=�6q   $��15(�6�   �� 5   
   -   5        $ restrictedlabel��5      $#��Authorize Restricted Activity��6)   $
��Left=�6Q   $��	252,0,0,0q�6l   $	��Top=�6   $��25(�6�   �� 5   
   -   5        $ restrictedActivity��5      $.��(No restricted activity needs authorizing��6,   $
��Left=�6_   $��
252,43,0,0q�6z   $	��Top=�6�   $	��220��6�   5      5      