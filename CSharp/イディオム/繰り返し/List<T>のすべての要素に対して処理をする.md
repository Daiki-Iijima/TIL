# List < T >のすべての要素に対して処理をする

## BAD

```c#
var nums = new List<int> {1, 2, 3, 4, 5, };

nums.ForEach(n => 
             {
                ...
                //	複数行の処理
                ...
             });
```

- 処理が複数行になる場合、ForEachは使わないほうがいい
- 複数行になる場合はforeach文をつかう

## GOOD

```c#
var nums = new List<int> {1, 2, 3, 4, 5,};
nums.ForEach(n => Console.WriteLine(n));
```

- 1行で終わる処理には最適

- メソッドの中身がそのまま引数に渡せ、戻り値がない場合

  ```c#
  var nums = new List<int> {1, 2, 3, 4, 5,};
  nums.ForEach(Console.WriteLine);
  ```

  - ここまで簡潔に書ける

## 注意

- ForEachメソッドでは「break」「continue」「yield return」が使えない
