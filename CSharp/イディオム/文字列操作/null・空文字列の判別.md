# 「null」か「空文字列」かを調べる

### BAD

```c#
var str = "";

//条件をそのまま書いた場合
if (str == null || str == "")
    Console.WriteLine("null あるいは空文字列です");


//さらに回りくどい条件設定
if (str == null || str.Length == 0)
     Console.WriteLine("null あるいは空文字列です");
```


### GOOD

```c#
var str = "";

if (String.IsNullOrEmpty(str))
     Console.WriteLine("null あるいは空文字列です");
```
- 「String.IsNullOrEmpty」メソッドを使用することで、nullと空白文字列を同時に判定できる
