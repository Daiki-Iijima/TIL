# StringBuilderとは

- あらかじめ一定のサイズを確保した可変長の文字列を表す
- インスタンスの生成/破棄が頻繁に発生することがない
- 使用する文字数が想定できる場合は、インスタンス化の際にサイズを明示しておくとなおいい

# StringBuilderクラスを使うとき

- 6個以上の文字列連結がある場合
- ガベージコレクションの増大を少しでも抑えたい場合

## 5～6個程度の連結であれば[+]を使うほうがいい

# 使用例

```C#
//StringBuilderの使い方

var builder = new StringBuilder();
//サイズがどれくらいになるかわかっている場合
//var builder = new StringBuilder(15);

//Appendが文字列の結合
builder.Append("あいうえお");
builder.Append("かきくけこ");

//ToString()で結合した文字列を吐き出す
var result = builder.ToString();

//結果 : result = あいうえおかきくけこ
```
