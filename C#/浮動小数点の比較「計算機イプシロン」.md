# 浮動小数点は厳密な計算には不向き

- 浮動小数点は内部的に**2進数**として扱われる

  ## 解決策

  1. decimal型を利用する
  2. **計算機イプシロンを使う**

  ## 計算機イプシロンの解説

  

  ```c#
  //小数点第5位まで精度を保障したい
  const double EPSILON = 0.00001;
  
  double x = 0.2 * 3;
  double y = 0.6;
  
  Console.WriteLine( Math.Abs(x - y) < EPSILON );	//結果 : true
  ```

  - 定数**EPSILONは誤差の許容範囲**を表す

  - EPSILON未満であればEPSILONが保障した桁数までは等しいということになる
