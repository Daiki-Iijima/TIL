# Constよりもreadonlyを使用すること

# コンパイル時定数
## 使用するケース
- パフォーマンスが要求される場合

## 定義
```c#
public const int Millenninum = 2000;
```

## 内部動作

- ソースコード時 : 普通の変数のように使える(代入はできない)
    ```c#
    if( myDateTime.Year == Millennimun )
    ```
- コンパイル時 :「Millennimun」の参照ではなく、「2000」という値に置き換えられる
    ```c#
    if( myDateTime.Year == 2000)
    ```
# まとめ
```
コンパイルが生成したIL中において、リテラル値に置き換えられるものは、これらのプリミティブ型の値だけ
```
- コンパイル時定数(const)を指定できるのは「数値、文字列」に限定される
    - コンパイル時に値が決まっている必要があるなら

- コンパイル時定数(const)では、値を参照

# 実行時定数
## 使用するケース
- なるべくこっちを使おう

## 定義
```c#
public static readonly int  Millenninum = 2000;
```

## 内部動作
- ソースコード時 : 参照は「Millenninum」への参照
    ```c#
    if( myDateTime.Year == Millenninum )
    ```
- コンパイル時 :  参照は「Millenninum」への参照
    ```c#
    if( myDateTime.Year == Millenninum )
    ```

# まとめ
- 実行時定数はすべての型で作成可能
    - 参照型が値ではなく変数だから

# Word Infomation
## リテラル
- 変数の対義語
- 定数
### 訳
- 文字通り
- 定義通り
- ラテン語(littera(文字))に由来する

## プリミティブ
- データ型の中に、部分として他の型を含まない
### 訳
- 原始的な
- 根源的な