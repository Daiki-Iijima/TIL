# Swichのdefaultは必要

- 最終的な受け皿として「default」句があるのが望ましい

```c#
switch(data)
{
    case "a":
        break ;
    case "b":
        break;
    case "c":
        break;
    case default:
        Console.WriteLine("何にもあてはまらなかった");
        break;
}
```

# break命令は必須

- c/c++ではbreak命令を省略することができた 
- これを、「**フォールスルー**」という
- breakがないときは基本書き忘れであることから、C#では**breakが必須**になった

```c
//Cで書いている
//「フォールスルー」の例

int rank =3;
switch(rank)
{
    case 3:
        print("大変よろしいです\n")		//「3」が実行される
    case 2:
        print("合格です\n")			  //「3」「2」いずれも実行される
}
```



## C#でも例外的にフォールスルー出来る

- case句が連続している場合**break命令を挟まない**（フォールスルー）が可能
- 使い方的には「**or条件**」

```c#
var drink = "ビール";

switch(drink)
{
        case"日本酒":
        case"ビール":
        case"ワイン":
        	Console.WriteLine("醸造酒です");
        	break;
        case"ブランデー":
        case"ウイスキー":
             Console.WriteLine("蒸留酒です");
        	break;
}

//結果 : 醸造酒です
```

