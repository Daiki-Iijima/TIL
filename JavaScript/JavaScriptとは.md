# JavaScriptとは

1. ECMAScript(エクマスクリプト)との繋がり
2. JavaScriptの特徴

## ECMAScript(エクマスクリプト)との繋がり

ECMAScriptはどの実行環境でも共通な動作のみが定義されているので、どの環境でも同じ動作をする

UIはフロントサイドでは必要だが、バックエンドで使うNode.jsなどのサーバーサイドでは必要ない
このような用途によって固有な動作をする部分はJavaScriptが含んでいる

ECMAScriptとはJavaScriptの核となる部分だと言える

## JavaScriptの特徴

- 変数名の大文字小文字は区別される
  
  ```JavaScript
  const name = "なまえ"
  const NAME = "なまえ"
  ```

- セミコロンはつけなくても暗黙的にシステム側でつけてくれるが、セミコロンは自分でつける癖をつけたい

  ```JavaScript
  // セミコロンなしでも問題なく動く
  const num = 0

  // セミコロンつけても問題なく動く
  const num = 0;
  ```

- strict modeを使うと古く安全でない構文や機能が一部禁止されるのでモダンなコードが書ける
  - use strictをソースの最初につける
  
  ```JavaScript
  use strict

  const sample = 100;
  ```

