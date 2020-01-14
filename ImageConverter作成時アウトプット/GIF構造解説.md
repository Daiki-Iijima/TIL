# GIF構造

|ブロック名|有無|サイズ(Byte)|
|---|---|---|
|Header|○|6|
|Logical Screen Descriptor|○|7|
|Global Color Table| 「Logical Screen Descriptor」内のフラグが立っているか|0~?|
|Image Descripotr|○|10|
|Local Color Table|「Image Descriptor」内のフラグが立っているか|0~?|
|Table Base Image Data|○|2~?|
|Trailer|○|1|

- Trailerは必ず「0x3B」アスキー文字(;)

# Header
シグネチャとバージョンが記述されている

## シグネチャ(3byte)
```0x47(G) 0x49(I) 0x46(F)```

## バージョン(3byte)
|バージョン|組み合わせ|
|---|---|
|87a|```0x38 0x37 0x61```|
|89a|```0x38 0x37 0x61```|

# Logical Screen Descriptor


# Version 89aの追加ブロック

先頭 2バイトで判断できる

  - 「0x21」「0x??」

    | 「0x??」内の文字 | 追加ブロック名             |
    | ---------------- | -------------------------- |
    | F9               | Graphic Controll Extension |
    | FE               | Comment Extension          |
    | 01               | Plain Text Extension       |
    | FF               | Application Extension      |

# Graphic Controll Extension(8 Byte)

|情報名|サイズ|固定値の場合のコード|概要|
|---|---|---|---|
|Extension Introducer|1 Byte|0x21|拡張ブロック判定|
|Graphic Control Label|1 Byte|0xf9|Graphic Control Extensionの判定|
|Block Size|1 Byte|0x04|この拡張ブロックのサイズ|
|Transparent Color Flag|1 Byte|0x01 or 0x00|行う or 行わない|
|Delay Time|2 Byte|-|表示する際の値遅延(1/100)|
|Transparent Color Index|1 Byte|-|透過する色のインデックス|
|Block Terminator|1 Byte|0x00|ブロック並びの終わり|

# 参考
基本構造

http://www.tohoho-web.com/wwwgif.htm

圧縮アルゴリズム

https://nodamushi.hatenablog.com/entry/20090531/1243775161

http://bttb.s1.valueserver.jp/wordpress/blog/2018/12/23/gif-lzw-comp/