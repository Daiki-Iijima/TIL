# null条件演算子とnull合体演算子を使った例

```c#
var product = GetProduct(id);
var name = product?.Name ?? DefaultName;
```

- productがnullのときには、DefaultNameがnullに代入される
- nullを代入したくない場合に使える
