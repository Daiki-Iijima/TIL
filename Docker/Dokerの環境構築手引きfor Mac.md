# Dockerの始め方

## ステップ

1. インストール
2. nginx(エンジンエックス)を起動してみる

## 使いそうなコマンド

1. コンテナの停止方法
2. コンテナの起動方法
3. コンテナの状態確認
4. コンテナの消去
5. ローカルイメージの確認
6. ローカルイメージの消去

## インストール

1. 公式ページへ

   https://docs.docker.com/docker-for-mac/install/

2. アカウント作れと言われるので作る

3. dmgを開いてインストール

4. 一度インストールしたDockerを起動しようとすると権限関係のことを聞かれるので、権限を付与

   これをしないと5のチェックでコマンドが通らない

   

5. Dockerを起動するとデスクトップのヘッダー部分にIconが生成されるのでそこから、「2」で作成したアカウントでログイン

   これをしないと5のチェックで

   ```
   Error response from daemon: Bad response from Docker engine
   ```

   が出る

   

6. インストールできたかチェック

   ```
   docker version
   ```

7. これがでればOK

   ```
   Client: Docker Engine - Community
    Version:           18.09.2
    API version:       1.39
    Go version:        go1.10.8
    Git commit:        6247962
    Built:             Sun Feb 10 04:12:39 2019
    OS/Arch:           darwin/amd64
    Experimental:      false
   
   Server: Docker Engine - Community
    Engine:
     Version:          18.09.2
     API version:      1.39 (minimum version 1.12)
     Go version:       go1.10.6
     Git commit:       6247962
     Built:            Sun Feb 10 04:13:06 2019
     OS/Arch:          linux/amd64
     Experimental:     false
   ```

## nginx(エンジンエックス)を起動してみる

1. nginxを80番ポートで起動する

   ```
   docker run -d -p 80:80 --name コンテナ名 nginx
   ```

   nginxのdocker imageがローカルで見つからない場合は、Docker Hubから自動でpullしてくれる

2. こんなんでたらOK

   ```
   [Unable to find image 'nginx:latest' locally
   latest: Pulling from library/nginx
   743f2d6c1f65: Pull complete 
   d6c2f01b1dae: Pull complete 
   d4da6ff1b555: Pull complete 
   Digest: sha256:12db363acf5b2d2f9f5fed240e228a04692bdac68402430fbd2f720c3a967d01
   Status: Downloaded newer image for nginx:latest
   8344f31f3f3df45b7553fb9ee3e632bf7853dc52088ce51d4d6fdd09e8643468
   ```

3. [http://localhost/](http://localhost/)で確認

## コンテナ停止

- 停止コマンド

  ```
  docker container stop 停止したいコンテナ名
  ```

- こんなんでたらOK

  ```
  停止したいコンテナ名
  ```

## コンテナの起動

- 起動コマンド

  ```
  docker container start 起動したいコンテナ名
  ```

- こんなんでたらOK

  ```
  起動したいコンテナ名
  ```

## コンテナの状態確認

- 起動しているコンテナの表示コマンド

  ```
  docker container ls
  ```

- 起動していない状態のコンテナも表示

  ```
  docker container ls -a
  ```

- こんなんでたらOK

  ```
  CONTAINER ID        IMAGE               COMMAND                  CREATED             STATUS              PORTS                NAMES
  8344f31f3f3d        nginx               "nginx -g 'daemon of…"   11 minutes ago      Up 2 minutes        0.0.0.0:80->80/tcp   Test_nginx
  ```

## コンテナの消去

- コンテナの消去コマンド

  ```
  docker container rm 消去したいコンテナ名
  ```

- こんなのでたらOK

  ```
  消去したいコンテナ名
  ```

## イメージの確認

- 確認コマンド

  ```
  docker image ls -a
  ```

- こんなんでたらOK

  ```
  REPOSITORY          TAG                 IMAGE ID            CREATED             SIZE
  nginx               latest              62c261073ecf        3 days ago          109MB
  ```

  - イメージが存在していない場合

    ```
    Error: No such image: nginx
    ```

    

## イメージの消去

- イメージの消去コマンド

  ```
  docker image rm 消去したいID or iamge Name
  ```

- こんなんでたらOK

  ```
  Untagged: 消去したいID or iamge Name:latest
  Untagged: nginx@sha256:12db363acf5b2d2f9f5fed240e228a04692bdac68402430fbd2f720c3a967d01
  Deleted: sha256:62c261073ecffe22a28f2ba67760a9320bc4bfe8136a83ba9b579983346564be
  Deleted: sha256:26fcb2a784c12d7eb264cffb01ab151205a9b76544ff95bbb50ad12af5522194
  Deleted: sha256:42d8e0f63ec15a63685dafc91005f57f0a335c0148f1106ead653da8710b541c
  Deleted: sha256:6270adb5794c6987109e54af00ab456977c5d5cc6f1bc52c1ce58d32ec0f15f4
  ```

  

