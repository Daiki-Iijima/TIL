# CL開発環境をもっと整える(統合開発環境)

## sbclを導入する

1. sbclを導入する

   ```bash
   brew install sbcl
   ```

2. テストしてみる

   ```
   sbcl
   ```

   ```
   (* 3 3)
   
   =>	9
   ```

## Emacsを導入する

1. Emacsを導入

   ```
   brew cask install emacs
   ```

2. 一度起動する

   ```
   emacs
   ```

   - ホームディレクトリにフォルダを作成するため

3. 終了する

   ```
   Ctr + x
   Ctr + c
   ```

## Slimeを導入する

1. Gitから導入

   1. emacsディレクトリに移動

      ```
      cd ~/.emacs.d/
      ```

      

   2. git cloneする

      ```
      git clone https://github.com/slime/slime.git
      ```

## 環境設定

1. init.elの作成

   ```
   touch ~/.emacs.d/init.el
   ```

2. Vimで開く

   ```
   vim ~/.emacs.d/init.el
   ```

3. 以下を書き込む

   ```
   ;; SBCLをデフォルトのCommon Lisp処理系に設定
   (setq inferior-lisp-program "sbcl")
   ;; ~/.emacs.d/slimeをload-pathに追加
   (add-to-list 'load-path (expand-file-name "~/.emacs.d/slime"))
   ;; SLIMEのロード
   (require 'slime)
   (slime-setup '(slime-repl slime-fancy slime-banner)) 
   ```

## 起動

```
emacs
```

```
Alt + x
slime
```

