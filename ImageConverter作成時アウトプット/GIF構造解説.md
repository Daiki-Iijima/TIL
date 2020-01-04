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

# Version 89aの追加ブロック

- 先頭 2バイトで判断できる

  - 「0x21」「0x??」

    | 「0x??」内の文字 | 追加ブロック名             |
    | ---------------- | -------------------------- |
    | F9               | Graphic Controll Extension |
    | FE               | Comment Extension          |
    | 01               | Plain Text Extension       |
    | FF               | Application Extension      |

