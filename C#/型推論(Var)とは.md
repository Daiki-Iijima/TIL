# 型推論(var)
- 変数宣言をする際にデータ型を省略できる



## 注意点

### 期値は省略できない
- メモリ上に値を確保する必要がある

### 複数の変数をまとめて宣言できない
- あたりまえ

### フィールド宣言では利用できない
- メソッドの中でのみ使用可能

### varという名前のクラスが存在した場合そちらを優先
- varはコンテキストキーワードなのでクラス名に使用ができる(使用することはないと思う)

### 変数宣言時に推論した型と別の型リテラルを代入はできない(variant型ではない)

```C#
var name = "aaa";
var name = 1000;
//エラー(型'int'を'string'に暗黙的に変換できません。)
```

# 暗黙的な型指定(var)と明示的な型(int,string,etc...)どちらを優先すればいいのか

[Microsoftの見解]( https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variablesZ )

- 結論
積極的に利用していこう
しかし、個人やチーム内で何かルールや心に決めていることがあれば無理に使用する必要はない
