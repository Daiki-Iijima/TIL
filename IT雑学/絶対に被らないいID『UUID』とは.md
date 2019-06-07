# ほぼ絶対に被らない固有ID「UUID」

## UUIDとは?

- Universally Unique Identifier
- 128ビットの数値
- 世界で1つのユニークなID
- 分散システム上で統制なしに作成できる識別子として設計されている
- マイクロソフトのGUIDもUUIDの一部とみなすことができる

## UUIDのバージョン(2019/06/07現在)

|version|生成方法|
|:-:|:-:|
|1|MAC-Addressと生成時刻によるもの|
|2|DCE Security Version|
|3|名前(byte列)のMD5ハッシュによるもの|
|4|ランダム|
|5|名前(byte列)のSHA-1ハッシュによるもの|

## UUIDバージョンの見分けかた

- Vの部分がVersion番号になっている

```
xxxxxxxx-xxxx-Vxxx-xxxx-xxxxxxxxxxxx
```

# どのバージョンのUUIDを使えばいいのか

- version4がいいらしい