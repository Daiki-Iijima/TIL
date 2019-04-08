# Listとは

- 内部的には配列データを使用したデータ構造
- 配列と異なる点は、サイズを後からでも動的に変更できる点
- ランダムアクセス性能に優れている

# Listのメンバーをコードで紹介

```c#
var list = new List<int> {10,25,30,60}
var list2 = new List<int> {1,5,3,6}

//Insert
//2番目に7を代入
list.Insert(2,7);

//Add
//末尾に120を代入
list.Add(120);

foreach(var data in list)
{
    Console.WriteLine(data);
}
//結果 : 10,15,7,30,60,120

//要素数取得
Console.WriteLine(list.Count);				//結果 : 6

//指定番目の要素を取得
Console.WriteLine(list[0]);					//結果 : 10

//指定した要素が含まれているか
Console.WriteLine(list.Contains(30));		 //結果 : true

//指定要素が何番目にあるかを取得
Console.WriteLine(list.IndexOf(30)); 		 //結果 : 3

//指定要素が後方から何番目にあるかを取得
Console.WriteLine(list.LastIndexOf(30));	 //結果 : 2

//最初にマッチした要素を消去
Console.WriteLine(list.Remove(60));			 //結果 : true

//コレクション要素を末尾に追加
list.AddRange(list2);

//要素の順序を反転
list.Reverse();


```



# Listを使う時の注意点

- データの追加時にメモリー(配列)の再割り当てが発生する場合がある

- Listはあらかじめ一定のサイズの領域を準備しているが、要素の追加に伴って領域が不足すると、自動的に一定量だけサイズを拡張する

- もしも必要となるサイズ(要素数)があらかじめ想定できるならサイズ宣言するといい

  ```C#
  var list = new List<int>(30);
  ```

