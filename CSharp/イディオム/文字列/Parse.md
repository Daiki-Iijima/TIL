# 文字列を数値に変換する

## BAD

```c#
try{
    int retryCount = int.Parse(str);
}catch (ArgumentNullException ex){
    ...
}
```

- 例外のキャッチにはかなりのコストがかかるので極力避ける

## GOOD

- C# 6.0まで

```c#
string str = "123";
int height;
if(int.TryParse(str,out height))
{
   Console.WriteLine(height);
}else
{
   Console.WriteLine("Error");
}
```

- C# 7.0から

```c#
string str = "123";

if(int.TryParse(str,out var height))
{
   Console.WriteLine(height);
}else
{
   Console.WriteLine("Error");
}
```

- C# 7.0以降なら変数宣言を省略することができる
- 変換に成功すると「true」失敗すると「false」を返す

## 例外

```c#
int height = int.Parse(str);
```

- 文字列に数値文字列が入っていることが保証されている場合は普通にParseしてOK
