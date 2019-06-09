# Dockerfileの解説

## Dockerfileとは

- Dockerfile独自のコマンドの組み合わせて、どのようなイメージを作るか記述するもの

## Dockerのコンテナを作成し、JavaScriptを動作させてみる

### JavaScriptファイルを作成

- 1000msごとに「こんにちは、世界」と表示する

```javascript
setInterval(() => {
  console.log('こんにちは、世界');
}, 1000);
```

### JavaScriptを実行するためのコンテナの設定をDockerfileに記述

1. node.jsのイメージをベースに作成

2. ワーキングディレクトリに「app.js」がある

3. 起動時に「node app.js」コマンドを実行する

   ```dockerfile
   FROM node:6.9.1
   
   ENV HOME=/home/app
   
   COPY app.js $HOME/
   WORKDIR $HOME
   
   CMD ["node","app.js"]
   ```

| コマンド | 解説                                                   |
| -------- | ------------------------------------------------------ |
| FROM     | ベースになるDockerイメージ(DockerHubから探す)          |
| ENV      | Dockerfile上で使う変数を定義する                       |
| COPY     | ホスト上でファイルを、イメージ上にコピーする           |
| WORKDIR  | コンテナを起動した時にワーキングディレクトリを指定する |
| CMD      | コンテナを起動した時に実行するコマンドを定義する       |

### 実行

1. 前のステップで作成したファイルたちは同じディレクトリの同じフォルダ内に配置しておく

2. ターミナルでそのフォルダに移動

3. Dockerfileを元にコマンドでイメージを作成

   ```
   sudo docker build -t docker-sample:1.0 .
   ```

4. 起動

   ```
   sudo docker run docker-sample:1.0
   ```

- 上記で起動したコンテナは、「node.jsの実行環境が整っていてワーキングディレクトリにapp.js」があるコンテナということになる

5. 停止

   ```
   sudo docker rm -f <コンテナID>
   ```

   - ログが流れてくるので止め方がわからなかった

   - もう一つターミナル起動すればいけるかも？

   - 止まったから、別のターミナル開いてゆっくり対処しよう

     - コンテナ一覧表示

     ```
     docker container ls
     ```

     





