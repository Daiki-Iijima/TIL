# Common Lipsさわってみた

## Common Lips とは

- ANSIで規格が定められているメタプログラミング可能かつ、C言語並みに早い言語



## 開発導入 for Mac

- homebrewを使用してインストール

  ```bash
  brew install roswell
  ```

- セットアップ

  ```
  ros setup
  ```

  - セットアップコマンドを打たずに「ros」コマンドを実行しても処理系が足りていなければ自動でセットアップしてくれる

# Common Lips の基本

## インタプリタ(REPL)を立ち上げる

```
ros run
```

```
* //こうなればOK
```



## Hello World を出力

```
(format t "Hello World!~%")
```



## エラーでデバッガモードに移行してしまった時の対処法

- 「abort」と入力してエンターキー
- デバッガーモードを終了して普通のREPLに移行する



