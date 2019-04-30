# Goの基本

```go
package main

import
{
    "fmt"
}

func main()
{
    fmt.Println("hello world")
}
```

## Goのコードはパッケージ宣言から始まる

- ```go
  package main
  ```

  - コンパイルして実行すると、mainパッケージの中にある「main()関数」が実行されるのでここで宣言している

## プログラム内の他のパッケージを取り込むために使用する「import」

```go
import 
{
    "fmt"
}

func main()
{
    fmt.Println("hello world")
}
```

- インポートしたパッケージ名にドットを付けてアクセスする
- 「fmt」はC言語の「printf」「scanf」と似た関数を持つ
