# Listから配列に変換

```C#
var array = new[]{"バラ","ひまわり","あさがお"};

//配列をList生成時に代入
var list = new List<string>(array);
```



# 配列からListに変換

```C#
var list = new List<string>
{
	"バラ",
	"ひまわり",
	"あさがお",
}

//ToArray()メソッドで配列に変換
var array = list.ToArray();
```



# インデックスの初期化を見やすくする「インデックス初期化子」

```C#
//基本的な初期化

var flower = new Dictionary<string,string>()
{
    {"Rose","バラ"},
    {"Sunflower","ひまわり"},
    {"Morning Glory","あさがお"}
};

//インデックス初期化子(見やすくする)

var flower = new Dictionary<string,string>()
{
    ["Rose"] = "バラ",
    ["Sunflower"] = "ひまわり",
    ["Morning Glory"] = "あさがお"
};


```



# foreachでコレクション順に処理

```c#
var list = new List<string>
{
	"バラ",
	"ひまわり",
	"あさがお",
}

foreach(var data in list)
{
    Console.WriteLine(data);
}

//結果:
//バラ
//ひまわり
//あさがお
```

- foreach構文とはwhile命令の**シンタックスシュガー(より簡単化された構文)**

## foreach文を自力で実装してみる

一つ上のコードのforeach部分を置き換える形で書いてみる

```c#
var enu = list.GetEnumerator();   //1
while(enu.MoveNext()) 			 //2
{
    string str = enu.Current;     //3
    Console.WriteLine(str);
}
```

1. GetEnumerator()

   それぞれの実装(Listの型)に応じた列挙子を取得できる(Enumeratorオブジェクト)

2. enu.MoveNext()

   列挙子を次の要素に移動させると同時に、次の要素がない場合はfalseを返すのでwhile文でループ判別できる

3. enu.Current

   現在の要素を取得

   

   ### 列挙子メンバーまとめ

   | メンバー        | 概要                               |
   | --------------- | ---------------------------------- |
   | T Current       | 現在の要素(Tは現在の型要素)        |
   | bool MoveNext() | 列挙子を次の要素に移動             |
   | void Reset()    | 列挙子をリセット(最初の要素に戻す) |

