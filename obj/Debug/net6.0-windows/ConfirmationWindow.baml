   M S B A M L   `   `   `  ????D  @Login App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Login_App	Login_App  5   	   "    Login_App.ConfirmationWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Login_App     5   	     ? WindowStartupLocation$  CenterScreen=?5       ? WindowStyle$
 None=?6?    ? AllowsTransparency$
 True??5   	   
??????  ? Title$ ConfirmationWindow??5	   	   $	??250??6$   $	??350??61    ? 
ResizeMode$ NoResize=?5
   	   .??5      ? .+?5   
   ?? -   5        $??/Images/Close.png??5       K? ZIndex$ 2??6,      ImgClose#??[  5   )   $??	0 25 25 0q?6L   ?? 5   
   -   5         ?? CornerRadius$ 20 20 20 20??5      $??10q?6-   
???????._?5      ? .+?5      ?? $ 20 20 20 20??6   $??10q?65   $??0??6J   ??5      ?? 5       ?? 
StartPoint$	 0,0&?6.    ?? EndPoint$	 1,1&?6?   .??5      ? 	 ? Color$	 #3AA9AD??6+   
 ? Offset$
 0Q?6;   ? 5      $	 #3AADA1??6+   $
 1Q?6;   5      5      ?? 5      .+?5      ?? -   5         ??Name$ ConfitmitionTextBlock??5       $
??Wrap=?6?   $??
30 50 30 0q?5   !     
normalText#??[ 5       ???#e8e8e85      ?? 5       ?? Orientation$ 
Horizontal=?6!   $??Center=?6:   $??Bottom=?6W   .+?5      ?? -   5         
 button#??[ 5   !   $
??Да??6A   $??	10 30 0 0q?6g   $??50??6z   $	??100??6?   ?? 5       -   5        #??[ 5    !   $??Нет??6A   $??	10 30 0 0q?6g   $??50??6z   $	??100??6?   5!      5#      5$      5&      5'      5(      