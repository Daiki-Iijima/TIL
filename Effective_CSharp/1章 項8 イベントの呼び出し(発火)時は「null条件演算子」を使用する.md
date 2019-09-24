# 1章 8項 イベントの呼び出し時(発火)時は「null条件演算子」を使用する

# null条件演算子を使用しないとどうなるか
- イベントにハンドラが登録されていない場合は「NullReferenceException」が出る
```c#
private EventHandler<string> TestHandler;

public void StartEvent()
{

    TestHandler(this, "テスト");

    //  処理

    TestHandler += Log;

}

private void Log(object obj, string str)
{
    Console.WriteLine(str);
}

```

## 解説

- イベント発火時にハンドラが登録されていないのでエラーが出る

# nullチェックを入れてエラーが出ないようにする

```c#
private EventHandler<string> TestHandler;

public void StartEvent()
{

    TestHandler += Log;

    //  nullチェック
    if (TestHandler != null)
        TestHandler(this, "テスト");


}

private void Log(object obj, string str)
{
    Console.WriteLine(str);
}
```

## 解説

- TestHandlerがnullの場合は、ハンドラが登録されていない場合

## 潜在的なバグがある
- nullチェックが終わった後に、別スレッドでTestHandlerへの登録が解除された場合、nullチェックをかいくぐって、ハンドラが登録されていないイベントが発火されてしまう

# 潜在的なバグ(スレッドアンセーフ)を回避する

```c#
TestHandler += Log;

var testHandler = TestHandler;

if (testHandler != null)
    testHandler(this, "テスト");
```

## 解説
- ローカル変数に現在のイベントハンドラを割り当てる

### 特徴4つ
1. 元のイベントで登録されたすべてのハンドラをローカル変数で保持できる
2. 元のイベントに設定されているハンドラが解除されてもローカル変数のハンドラには影響されない
3. イベントを変数に代入すると、参照ではなく、ハンドラのコピーを作成することと同じことになる
4. スレッドセーフ

# まとめ
## 全ての問題(nullチェック、スレッドセーフ)を解決しつつ、短く記述できる「null条件演算子」を使おう

```c#
TestHandler?.Invoke();
```