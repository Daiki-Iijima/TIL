# Ruby on Rails テスト環境構築

# 下準備

1. ディレクトリ作成

   ```bash
   mkdir rails_minimum
   ```

   - 移動

     ```bash
     cd rails_minimum
     ```

# イメージ作成

1. Dockerfile作成

   ```
   vim Dockerfile
   ```

   - 中身

     ```dockerfile
     FROM ruby:2.5.1
     ```

     | コマンド                 | 解説                   |
     | ------------------------ | ---------------------- |
     | FROM [イメージ名]:[タグ] | 元になるイメージの指定 |

3. イメージのビルド

   ```
   docker build . -t minimum
   ```

   | オプション             | 解説                         |
   | ---------------------- | ---------------------------- |
   | .                      | 今いるディレクトリ           |
   | -t [イメージ名]:[タグ] | イメージ名、タグ名を付与する |

4. ビルドできたかチェック

   ```
   docker images
   ```

   

# コンテナ作成

1. 先ほど作成したイメージからコンテナを作成

   ```bash
   docker create --name minimum -it minimum
   ```

   | オプション         | 解説                                                       |
   | ------------------ | ---------------------------------------------------------- |
   | —name [コンテナ名] | 作成するコンテナ名前の指定(つけない場合は適当なものがつく) |
   | -i                 | 起動時にコンテナの標準出力にアタッチ                       |
   | -t                 | 擬似ターミナルを割り当て                                   |

   - この段階で「-it」オプションをつけておかないとコンテナ内を操作できない

2. 作成したコンテナを起動

   ```
   docker start minimum
   ```

- コンテナの作成と起動をいっぺんに行う

  ```
  docker run -d --name minimum -it minimum
  ```

  | オプション | 解説                   |
  | ---------- | ---------------------- |
  | -d         | バックグラウンドで起動 |

  

# コンテナ操作

1. コンテナ内のbashに入る

   ```
   docker exec -it minimum bash
   ```

2. プロジェクト用のディレクトリを作成

   ```bash
   mkdir app
   ```

   - 移動

     ```
     cd app
     ```

## railsの導入

### 下準備

1. ライブラリを更新

   ```
   apt-get update
   ```

2. Vimを導入

   ```
   apt-get install vim
   ```
   
   

### rails導入

1. Gemfileを作成

   ```
   vim Gemfile
   ```
   
   - 中身
   
     ```
     source 'https://rubygems.org'
     gem 'rails', '5.1.6'
     ```
2. bundle経由でインストール

   ```
   bundle install
   ```
   
3. インストールできたか確認

   ```
   rails -v
   ```
   
### railsの初期化

1. 初期化

   ```
   rails new .
   ```

2. 初期化できたか確認

     ```
     ls
     ```
     
     - 色々できてればok
     
       ```
       Gemfile  Gemfile.lock  README.md
       Rakefile  app  bin  config  config.ru
       db  lib  log  package.json  public 
       test  tmp  vendor
       ```
   
### railsサーバーの起動

1. railsでサーバーを起動する前にnode.jsをインストールしておく(railsはnodejsをコンパイルで使用しているため)

   ```
   apt-get install -y nodejs
   ```
   
2. サーバーを起動

   ```
   rails server -d
   ```

3. サーバー停止

   ```
   cat tmp/pids/server.pid
   
   [出力:3桁ぐらいの数字]
   
   kill 出力された数字
   ```
   

# コンテナを抜ける

```
exit
```
