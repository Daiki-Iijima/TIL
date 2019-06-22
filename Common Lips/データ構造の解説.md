# アトム

- 「リストではない」データのこと
- 自分自身に評価されるデータ型
- 文字列、数値、etc

### 例

```
* 42
=>	42
* "Hello"
=>	"Hello"
```

## シンボル

- 他の言語でいう変数のこと？
- 変数の格納場所を示す名前のことらしい
- シンボルを読み込むと大文字に勝手に変換される

### 例

- 変数として使用する

```
(setf hoge 42)
=>
; in: SETF HOGE
;     (SETF HOGE 42)
; ==>
;   (SETQ HOGE 42)
; 
; caught WARNING:
;   undefined variable: COMMON-LISP-USER::HOGE
; 
; compilation unit finished
;   Undefined variable:
;     HOGE
;   caught 1 WARNING condition
42
```

- グローバル変数を作ったという、処理系の警告なので特に気にしなくていい

```
hoge
=>	42
```

- こうなればOK!

## nil

- リスト : 空リスト
- アトム : false

## t

- アトム : true

# リスト

- 括弧で囲まれたデータを連ねた形式データ
- はじめに「'」をつける
- 実態はコンセル(データ型を用いた一方向線形リスト)
- 注意 : 関数の呼び出し「(xxx xxxx xxx)」の形に似ている(関数呼び出しは「'」をつけない)

```
* '(1 2 3)
=> (1 2 3)

* '(a b c)
=> (A B C)
```

