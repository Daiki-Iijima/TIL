# Hello Worldしてみる

1. 「HelloWorld.go」ファイルを生成

2. 「hello world」を出力するプログラムを書く

   ```go
   package main
   
   import (
       "fmt"
   )
   
   func main() {
       fmt.Println("hello world")
   }
   ```

3. C直下に保存

4. コマンドプロンプトで実行

   ```
   go run HelloWorld.go
   ```

   - hello worldと出力されれば成功
