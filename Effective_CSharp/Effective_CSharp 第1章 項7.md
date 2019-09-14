# デリゲートを使用してコールバックを表示する

# デリゲートとは？
- タイプセーフなコールバックを定義できる

## 使い道
- イベントと合わせて使う
## 利点
- 密結合を防ぐ
    - なぜ？：互いのインターフェイスを使用しなくていい
# フレームワークライブラリ( .Net API )内の3つのデリゲート型セット
- 普通に使用してもいい

# Predicate＜T＞
- 条件をテストする
- bool値を返す

## 定義
```c#
class ActionMethod
{
    public Predicate<int> CheckNo;

    public void SetAction()
    {
        CheckNo = act;
    }

    private bool act(int no)
    {
        return 10 < no;
    }
}
```

## 呼び出し、使用方法
- デリゲート定義とメソッドの追加は上で定義したものがある前提
- if文の判定条件に使ったりする？
```c#
public void Check()
{
    SetAction();
    if(CheckNo?.Invoke(3))
    {
        //  10が3よりも小さい場合
    }
    else
    {
        //  それ以外
    }
}

```

# Func＜T＞
- 複数の引数を受け取り、単一の結果を返す
- Func＜引数の型,返り値の型＞

## 定義
```c#
class ActionMethod
{
    public Func<int, string> NoJuge;

    public void SetAction()
    {            
        NoJuge = ActionFunc;
    }

    private string ActionFunc(int no)
    {
        var retStr = "";

        if (no > 5)
        {                
            retStr = "5よりも大きいよ";
        }
        else
        {
            retStr = "5よりも小さいよ";
        }

        return retStr;
    }
}
```

## 呼び出し、使用方法
- デリゲート定義とメソッドの追加は上で定義したものがある前提
```c#
public void Check()
{
    SetAction();
    Console.WriteLine(NoJuge?.Invoke(4));   //  5よりも小さいよ
}
```

# Action＜T＞
- 複数の引数を受け取り、voidを返す
- イベントのデリゲートで使う

## 定義
- イベントのデリゲートとして使う前提のサンプル
```c#
class ActionMethod
{
    public event Action<string> GetStrEvent;

    //  イベント発火用メソッド
    //  使用時に呼び出す
    public void StartAction(string sendStr)
    {
        GetStrEvent(sendStr);
    }
}
```

## 呼び出し、使用方法
```c#
public event Predicate<int> predicate;

public static void Main(string[] args)
{
    var action = new ActionMethod();

    //  イベントにメソッドを設定
    action.GetStrEvent += Action_GetStrEvent;

    //  イベントの発火
    action.StartAction("テスト");
}

private static void Action_GetStrEvent(string getStr)
{
    Console.WriteLine($"[{getStr}]を取得しました"); //  [テスト]を取得しました
}
```