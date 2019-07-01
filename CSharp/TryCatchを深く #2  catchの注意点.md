# catchブロック記述時の注意点

## catchブロックの呼び出されるルール

- catchブロックは正確には発生した例外がcatchブロックのそれと一致した場合
- 発生した例外の基底クラスである場合

```c#
try
{
    //例外が発生する可能性のあるコード
}
catch(Exception ex)
{
    Console.WriteLine(ex.StackTrace);
}
```

- すべての例外の基底クラスである「Exception」を使用した場合はすべての例外をキャッチできる

## 「Exception」でのキャッチは極力避ける

- 例外の対象があいまいになりがち
- より細かい原因でキャッチするようにする

## catchブロックの記述順序

- 記述が先にある例外が優先される

- 細かい例外から徐々に大きなくくりの例外を記述するように

  ```C#
  try
  {
      
  }
  catch(ArgumentNullException ex) //最初にチェック
  {
      
  }
  catch(FileNotFoundException ex) //次にチェック
  {
      
  }
  catch(Exception ex)	//最終チェック
  {
      
  }
  ```

  - 一番最初に「Exception」を記述するとすべての以降の例外には絶対に引っかからないので、「Exception」をやむを得ずに書く場合は一番最後に記述すること
