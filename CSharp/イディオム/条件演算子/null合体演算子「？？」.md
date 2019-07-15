# null合体演算子

## BAD

```c#
var message = GetMessage(code);
if(message == null)
{
    message = DefaultMessage();
}
```

- 悪くはないが、null合体演算子を使えばさらに短縮できる

## GOOD

```c#
var message = GetMessage(code) ?? DefaultMessage();
```

- ワンライナーで書ける
