# 例外にさらに条件を追加する



## 例外フィルター

- 「catch」ブロックに条件句(when句)を加えられる

- 条件式を使った例外の振り分けを行うことができる

  ```C#
  catch(例外型 変数) when(条件式)
  ```

## 具体的な記述方法

```C#
try
{
   var file = new StreamReader(@"C:\test.dat");
}
   //メッセージに「.dat」ファイルが含まれている場合
catch (FileNotFoundException ex) when (ex.Message.Contains(".dat"))
{
   Console.WriteLine("「.dat」ファイルが含まれている");
}
//メッセージに「.dat」ファイルが含まれていない場合
catch (FileNotFoundException ex)
{
    Console.WriteLine("「.dat」ファイルが含まれていない");
}
```

# 複数の例外を一緒に記述する(マルチキャッチ)

- 出力内容が同じなのに、例外は違う場合でも従来だと一つづつ分けて書くしかなかった

  ```C#
  try
  {
     var file = new StreamReader(@"C:\test.dat");
  }
  catch (FileNotFoundException ex)
  {
     Console.WriteLine("エラーメッセージ");//同じ
  }
  catch (ArgumentException ex)
  {
      Console.WriteLine("エラーメッセージ");//同じ
  }
  ```

- しかし、マルチキャッチを使用すれば例外を同じブロックにまとめることができる

  ```c#
  try
  {
     var file = new StreamReader(@"C:\test.dat");
  }
  catch (FileNotFoundException ex) when(
  ex is ArgumentException ex
  ex is Exception //これはほんとはダメ(複数選択できるという例)
  )
  {
     //例外を一つにまとめることができた
     Console.WriteLine("エラーメッセージ");//同じ
  }
  ```

  
