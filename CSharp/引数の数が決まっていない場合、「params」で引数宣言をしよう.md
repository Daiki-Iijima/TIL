# 引数の値の変化が起こる可能性がある場合に対応メソッド



## 可変長引数のメソッド

- 引数の省略が可能(呼び出さない)

- 引数の個数があらかじめ決まっていないメソッド

  ```C#
  public int TotalProducts(params int[] values)
  {
    int result = 1;
    
    foreach(var value in valiues)
    {
      result += value;
    }
    return result;
  }
  
  static void Main(string[] args)
  {
    var v = new ArgsParams();
    
    //呼び出し方
    Console.WriteLine(v.TotalProducts(12,10,643));
  }
  ```

  ## 配列引数との違い

  - いちいち配列に入れずに呼び出すことができる

    ```C#
    //宣言時
    public int TotalParams(params int[] values)
    
    public int TotalArray(int[] values)
      
    //呼び出し時
    TotalParams(1,2,3,4,5);
    
    TotalArray(new[]{1,2,3,4,5});
    ```

    

# 注意点

1. 可変長引数はメソッドに一つ、引数リストの末尾にだけ指定できる

   - エラーになる例

     ```c#
     void Hoge(params int[] pnum,int num);	//エラー
     void Hoge(params int[] pnumX,params int[] pnumY)  //エラー
     ```

2. 想定される引数まで可変長引数にまとめない

   - 全てを可変長引数にまとめることも可能だが、可動性の面で考えると重要な引数をメソッドを知らないと理解できない

   ```C#
   //全てを「params」でまとめた場合
   public void AddString(params string[] addSts)
   
   //想定される引数以外を「params」でまとめた場合
   public void AddString(string originSt,params string[] addSts)
   
   ```

3. 「１個以上の引数」を表す方法

   - 可変長引数は省略することも可能なので、必ず1つは宣言してほしい

     ```c#
     public void AddString(string st , params string[] sts)
     ```

   - 全てを「params」で取得して、メソッド内部で判定する方法もあるがこれは最善とは言えない

   - エラーの検知が実行時になってしまう

     ```C#
     public void AddString(params string[] sts)
     {
       //引数が指定されていない場合stsは0の配列になる
       if(sts.Lensgth == 0)
       {
         //エラー
        	throw new ArgumentNullExpention();
       }
     }
     ```

     
