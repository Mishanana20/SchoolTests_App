   M S B A M L   `   `   `  ????D  @Login App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Login_App.FramesLogin_App.Frames  5      1clr-namespace:Login_App.modelLogin_App.model  5          Login_App.Frames.Test   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Login_App.Frames     5      /modelclr-namespace:Login_App.model     5      -   5        $??	testFrame??5
        N? Title$
  Test??6   .??5      ? .+?5   
   ??  ?? CornerRadius$ 
20 20 20 0??6   ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #3AADA1??6#    ? Offset$ 0Q?63   ? 5      $ #3AADA1??6#   $ 1Q?63   5      ._?5      ?? $??Stretch=?6   $??	0 10 15 0q?68   .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??Center=?66   .+?5      ?? -   5         ??Name$ numberOfQuestion??5          	titleText#??[  5      ?? 5      ?6   ?? *CurrentNumberQuestion+ ?? Mode$ OneWay=? ?? 5      $?/??6    ?? 5      ?6   ?? *MaxNumberQuestion+5      5      ?? 5!      -   5        $??scroll??5!      $
??True??6-   $??Hidden=?5$      ??5"      ?? 	 ?? RelativeSource	 ?? *FindAncestor+
 ?? AncestorType"
 ? ?? Path$ ActualHeight?.??5%      ? $
??Auto??6   $
??Auto??6,   $??	0 0 0 100q?69   .+?5&      ?? .+?5'      ?? -   5         ??Name$ QuestionBorder??5'   !   $??1q?69   ???#ffffff$??20,30, 20, 0q?6c   $ 7??6y   ._?5(      ? -   5         ?Name$ GridQu??5(      $	??7 9q?6+    ? ColumnDefinitions 5)      ?? 5*      $
??Auto ?6/   ?? 5+      $??* ?6/    ? RowDefinitions 5-      ?? 5.   &   $??* ?64   $??50??6?   .+?52      ?? -   5        $ 
TextLoginS??52   $     HintText#??[ 53   "   $??22(?6D   $
??Wrap=?54   $   ??52   8   ?? *Question.QuestionText+54   $   ?? 56      -   5         ??Name$ 	TxtLoginS??56   "     textBox#??[ 57   "   58      59      ?? 5;      -   5         ??Name$ 
AnswerList??5;   #   ??5<      ?? 5=      .R?5>   "   ?? $??1q?6)   ???#ffffff$??20,30, 20, 0q?6S   $ 7??6i   ._?5?   &   ? $	??7 9q?6+    5@   *   ?? 5A   .   $
??Auto ?6?   ?? 5B   .   $??* ?6?    5D   *   ?? 5E   .   $??* ?6<   $??50??6G   .+?5I   .   	? -	   5         	? 	GroupName$ isTrueGroup??5I   :   $??Center=?6R    d? 	IsChecked$ FalseY?5J   :   $??0??6L   
 ? Tag 6Y   ?? 5K   :   ?? 5L   .   $ 	TextLogin??68   #??[ 5M   "   $??22(?6D   $
??Wrap=?5N   8   ??5L   K   ?? *
AnswerText+5N   8   ?? 5P   *   $ TxtLogin??62   #??[ 5Q   "   5R   '   5S   #   5T      5V      ?? 5W      -
   5         
 button#??[ 5W   !   $??Следующий??6A   $??Right=?5X   [   $??Bottom=?5Y   1   $??17(?6L   $??	0 20 10 0q?5Z   !   $	??135??5[   !    5X   K   ?? 5[   !   5\      5]      5^      5_      5`      5a      5b      