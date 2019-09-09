# デリゲートを使用してコールバックを表示する

# デリゲートとは？
- タイプセーフなコールバックを定義できる

## 使い道
- イベントと合わせて使う
## 利点
- 密結合を防ぐ
    - なぜ？：互いのインターフェイスを使用しなくていい
# フレームワークライブラリ( .Net API )内の3つのデリゲート型セット

## Predicate＜T＞
- 条件をテストする
- bool値を返す

## 定義
```c#
class ActionMethod
{
    public Predicate<int> CheckNo;

    public void SetAction(int no)
    {
        CheckNo = act;
    }

    private bool act(int no)
    {
        return no > 10;
    }
}
```

## 呼び出し、使用
