   M S B A M L   `   `   `  ???? D  @Login App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Login_App.FramesLogin_App.Frames  1clr-namespace:Login_App.modelLogin_App.model  *    $Login_App.Frames.ListOfTestQuestions   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:Login_App.Frames     /modelclr-namespace:Login_App.model       N? Title$  ListOfTestQuestions??.??? .+???  ?? CornerRadius$ 
20 20 20 0??????  ?? 
StartPoint$	 0,0&? ?? EndPoint$	 1,1&?.???  ? Color$ #3AADA1?? ? Offset$ 0Q?? $ #3AADA1??$ 1Q?._??? $??Stretch=?$??	0 10 15 0q?.+???  ?? Orientation$ 
Horizontal=?$??Center=?.+??? -    ??Name$ numberOfQuestion??   	titleText#??[  ?? $#?Список вопросов???? -   $??scroll??$
??True??$??Hidden=?????  ?? RelativeSource ?? *FindAncestor+	 ?? AncestorType"	 ?
 ?? Path$
 ActualHeight?.??? $
??Auto??$
??Auto??$??	0 0 0 100q?.+??? -    ??Name$ 
AnswerList??$??1?????? .R??? $??1q????#ffffff$??20,30, 20, 0q?$ 7??._?? $	??7 9q? ? ColumnDefinitions ?? $
??Auto ??? $??* ? ? RowDefinitions ?? $??* ?$??50??.+??? $ 	TextLogin??  HintText#??[ $??22(?$
??Wrap=????? *QuestionText+??  ??Name$ TxtLogin??  textBox#??[ 