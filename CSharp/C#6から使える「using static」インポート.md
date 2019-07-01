# C#6から使える「using static」インポート


- 名前空間だけでなく、「型」「構造体」「クラス」を略記できるようになる

```c#
using static 完全修飾名
```

## 省略できる条件

- 静的(static)メンバー
- 入れ子になった型

# コンソール出力を略記してみる

```C#
using static System.Console;
using static System.Math;

class Program
{
   static void Main(string[] args)
   {

       WriteLine("Console宣言がいらない");
       WriteLine(Round(5.2));

       ReadLine();
   }
}
```

