# ライブラリ
- if
- when
- dotime
- +
- -
- *
- /
- mod
- =


# コード

```
(dotimes (c 101)
  (if (= c 0)  ; 0をはじく
    (print c)
    (if (= (mod c 15) 0)  ;  15で割って0になる数
      (print "FizzBuzz")
      (if (= (mod c 5) 0)  ;  5で割って0になる数
        (print "Fizz")
        (if (= (mod c 3) 0)  ;  3で割って0になる数
          (print "Buzz")
          (print c)  ; 該当しなかった数
        )
      )
    )
  )
)
```