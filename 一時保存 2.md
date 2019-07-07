# usingを使ったリソース破棄

IDisposableインターフェイスを実装しているクラスはDisposeメソッドを使用する必要がある

## BAD

```c#
var filePath = @"パス";
StreamReader stream = new StreamReader(filePath);

try{
	string texts = stream.ReadToEnd();
	Console.WriteLine(texts);
}finally
{
	stream.Dispose();
}
```

- 動作的にはusingを使用した場合と同じ
- しかし、簡潔さがない

## GOOD

```c#
var filePath = @"";

using (var stream = new StreamReader(filePath))
{
	string texts = stream.ReadToEnd();
	Console.WriteLine(texts);
}
```

- try-finalyを使用する場合より、簡潔に書ける
- Dispose忘れがない
