# Ruby環境作成



## Dockerでの操作

1. CentOSをPull

   ```
   docker pull centos
   ```

2. 作成したCentOSコンテナ内にログイン

   ```
   docker run -it --name centosRuby centos /bin/bash --login
   ```

   - 「-it」オプション

     `つけることでコンテナ内で操作できます

   - 「—name 好き名前」オプション

     dockerコマンドのコンテナを指定する時に好きな名前部分の名称でコンテナを指定できる

## CentOS内での操作

1. rbenvのインストール

   1. gitのインストール	

      ```
      yum install -y git
      ```

   2. GitHubからrbenvをpull

      ```
      git clone https://github.com/rbenv/rbenv.git ~/.rbenv
      ```

   3. その他の設定

      ```
      echo 'export PATH="$HOME/.rbenv/bin:$PATH"' >> ~/.bash_profile
      ~/.rbenv/bin/rbenv init
      source ~/.bash_profiler
      ```

2. ruby-buildのインストール

   1. GitHubからpull

      ```
      git clone https://github.com/rbenv/ruby-build.git ~/.rbenv/plugins/ruby-build
      ```

   2. インストール

      ```
      ~/.rbenv/plugins/ruby-build/install.sh
      ```

3. Rubyのインストール

   ```
   yum install -y openssl-devel readline-devel zlib-devel 
   yum remove bzip2
   yum install -y bzip2 gcc make
   rbenv install 2.5.0
   echo 'eval "$(rbenv init -)"' >> ~/.bash_profile
   source ~/.bash_profile
   rbenv global 2.5.0
   ```



## もっと早い方法

```
docker pull ruby
```

