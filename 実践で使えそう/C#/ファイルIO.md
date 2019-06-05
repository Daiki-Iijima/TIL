# C#でファイルの読みこみを行う(詳しく)



## 使用準備

- using System.IO;が必要
- ここで使用するパスはすべて絶対パス

## 基本的に使える方法

- 読み込み

```c#
using (var reader = new StreamReader("ファイルパス"))
{
	var readedSt = reader.ReadToEnd();
}
```



- 書き込み

```c#
var saveSt = "保存する文字列";

using (var writer = new StreamWriter("保存先パス"))
{
    writer.Write(saveSt);
}
```



## 相対パスから絶対パスを取得

```c#
Console.WriteLine(Path.GetFullPath("..\\ファイル名"));
```

