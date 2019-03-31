# null条件演算子

-[?.]をメソッドの前に入れると変数がnullではない場合のみメソッドが実行されるので、nullexception(エラー)が出ない
-メソッド、プロパティ、インデクサーすべてに使える
-めちゃくそ優秀

#使用例

```C#

//strがnullだがエラーは出ない

string str = null;
string unspace = str?.Trim();


//プロパティ、インデクサーの場合も同じ

str?.Length;  (プロパティ)
str?[0];      (インデクサー)
```
