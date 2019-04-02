# ファイル操作

## テキストをファイルに書き込む

```c#
using (var writer = new StreamWriter(@"c:¥data¥data.log"))  //1
{
  writer.WriteLine(DateTime.Now.ToString());  							//2
}
```

1. 「using (var writer = new StreamWriter(@"c:¥data¥data.log"))」

   - 「using」ー  ファイルを確実にクローズする

     using命令によって生成されたオブジェクトはブロックを抜けたところで強制的に破棄されます

   - 「@」 ー 「¥」(エスケープシーケンス)を含むパスなので逐語的文字列リテラルを使用している

   - 「StreamWriter」ー ファイルをテキストに書き込む

     ```c#
     StreamWriter(string path)[,bool append [,Encoding encoding [, int bufferSize ] ] ] )
     ```

     path - ファイルパス

      [ 任意 ]

     append - 追記する(true) 上書きする(false)

     encoding - ファイルの文字エンコーディング

     bufferSize - バッファーのサイズ(バイト単位)

2. 「writer.WriteLine(DateTime.Now.ToString());」

   - 「WriteLine」 ー 文字列末尾に無条件で改行を付与する

     改行したくない場合「Write」メソッドを使用すればいい

# 「using」について

1. Disposeメソッド(IDisposableインターフェイス)を実装しているオブジェクトのみ使える

2. 複数のリソースを宣言することも可能

   ```c#
   using (var writer = new StreamWriter(@"c:¥data¥data.log"))
   using (var reader = new StreamReader(@"c:¥data¥sample.txt"))
   {
     //処理
   }
   ```

   
