# null条件演算子

## BAD

-  典型的なnullチェック

```c#
if(sale == null)
{
    return null;
}
else
{
    return sale.Product;
}
```

- 条件演算子を使った場合

```c#
return sale == null ? null : sale.Product;
```

- 典型的な場合は冗長になりすぎて、コードの可読性が落ちている
- 条件演算子を使った場合は、理解するのに時間がかかる可能性がある

## GOOD

```c#
return sale?.Product;
```

- ?を「.」の前につけることでワンライナーかつ、nullチェックをしていることが読み取れる
