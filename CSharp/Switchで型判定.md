# Switch文で型判定



```c#
object obj = -123;

switch(obj)
{
  case int i:
    Console.WriteLine(Math.Abs(i)); //int型の場合絶対値で取得
    break;
    
  case string str:
    Console.WriteLine(str[0]); //string型の場合先頭の文字を取得
    break;
    
  default:
    Console.WriteLine("意図しない型です"); //エラーメッセージ
    break;
}
```

- 型の宣言の後の**変数名は必須**

  

  ## case句の配下で**変数を使用しない場合「 _ 」を使うことで変数は用意しない**という宣言になる

```c#
switch(obj)
{
  case int _:
    break;
}
```



## 条件式を同時に使用する

- **When**を使用する

  ```c#
  object obj = -123;
  
  switch(obj)
  {
    case int i when i >= 15:
      Console.WriteLine("objは15以上です"); //int型かつ15以上の場合
      break;
      
    case string str when str.Length < 10:
      Console.WriteLine("10文字以上です"); //string型かつ10文字以上の場合
      break;
      
    default:
      Console.WriteLine("意図しない型です"); //エラーメッセージ
      break;
  }
  ```

  
