# メソッドから値を返すことを目的にしている場合は「out」を使おう

- 「ref」引数と同じく参照渡しされるが、事前の初期化は不要
- メソッド内で明示的に値が割り当てられなかった場合、**コンパイルエラーが出る**のでわかりやすい

# 使い方

与えられた引数x、yのうち、「大きなものをout引数max」で、「小さなものをout引数min」で返すメソッド

```C#
class PassOut
{
  //戻り値ではないのでvoidで大丈夫
  public void GetMaxMin(int x,int y,out int max,out int min)
  {
    if(x >= y)
    {
      max = x;
      min = y;
    }
    else
    {
      max = y;
      min = x;
    }
    
    //returnもいらない
  }
  
  static void Main(string[] args)
  {
    var a = new PassOut();
    
    //初期化はいらない
    int resultMax,resultMin;
    
    //outを明示的に宣言する
    a.GetMainMin(3,5,out resultMax,out resultMin);
    
    Console.WriteLine(resultMax);			//5
    Console.WriteLine(resultMin);			//3
  }
}
```

# C#7から使えるシンプル表現

```C#
a.GetMazMin(3,5,out int resultMax,out int resultMin);
```

- 変数宣言と、メソッド呼び出しを同時に記述できる
