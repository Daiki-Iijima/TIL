# GIF基本情報
## 使用される色数
2、4、8、16、32、64、128、256

## 画像縦横サイズ
1×1 ~ 563663

# GIF構造
# 全体像

|名称|サイズ|
|---|---|
|GIF Header|13(Byte)|
|Global Color Table|可変(ない場合もある)|
|Extension Block|4種類存在するが、ファイルによっては存在しない場合もある|
|Image Block|可変|
|Trailer|1(Byte)|

# GIF Header
|名称|サイズ|情報|
|---|---|---|
|シグネチャ|3(Byte)|0x47(G) 0x49(I) 0x46(F)|
|バージョン|3(Byte)|GIF87a : 「0x38(8) 0x37(7) 0x61(a)」 アニメーションサポート<br> GIF89a : 「0x38(8) 0x39(9) 0x61(a)」 アニメーション / 透過 サポート|
|横幅|2(Byte)||
|縦幅|2(Byte)||
|フラグと情報|1(Byte)|共通パレット(1bit) : 0(存在しない) 1(存在する) <br> 1画素のビット数(3bit) : 0~7 (あまり重要ではない)<br> 共通パレットのソートフラグ(1bit) : 0(未ソート) 1(ソート済み) <br> 共通パレットのパレット数(3bit) : 0~7|
|背景色のパレットインデックス|1(Byte)|基本的に「0」<br> 「GIF Header」で定義されるイメージサイズと「Image Data」ブロックで定義されているイメージサイズが「異なる場合」数字が入る|
|ピクセル縦横比|1(Byte)|基本的に0(比率情報なし) <br>1~255(この値をNとして「(N+15)/64」で縦横比が算出)|

## Global Color Table
### 共通パレットのパレット数(bit)から実際のパレット数の算出
```
パレット数　n(0~7)
m(実際のパレット数) = n + 1

色数 = 2 ^ m
```
実際に記述されているバイト数は「0x00 0x00 0x00」(RGB)で1パレットなので

```
バイト数 = 色数 * 3
```
になる

|bit数|計算式(色数)|色数|計算式(バイト数)|コード内のバイト数(Byte)|
|---|---|---|---|---|
|0|2^(0+1)|2|2*3|6|
|1|2^(1+1)|4|4*3|12|
|2|2^(2+1)|8|8*3|24|
|3|2^(3+1)|16|16*3|48|
|4|2^(4+1)|32|32*3|96|
|5|2^(5+1)|64|64*3|192|
|6|2^(6+1)|128|128*3|384|
|7|2^(7+1)|256|256*3|764|

# Version 89aの追加ブロック

先頭 2バイトで判断できる

  - 「0x21」「0x??」

    | 「0x??」内の文字 | 追加ブロック名             |概要|
    | ---------------- | -------------------------- |---|
    | F9               | Graphic Controll Extension |透過色など|
    | FE               | Comment Extension          |画像のコメント|
    | 01               | Plain Text Extension       |テキストデータ(使われることはあまりない)|
    | FF               | Application Extension      |アプリ独自の情報|

## Graphic Controll Extension(8 Byte)

|情報名|サイズ|固定値の場合のコード|概要|
|---|---|---|---|
|Extension Introducer|1 (Byte)|0x21|拡張ブロック判定|
|Graphic Control Label|1 (Byte)|0xf9|Graphic Control Extensionの判定|
|Block Size|1 (Byte)|0x04|この拡張ブロックのサイズ|
|Transparent Color Flag|1 (Byte)|0x01 or 0x00|行う or 行わない|
|Delay Time|2 (Byte)|-|表示する際の値遅延(1/100)|
|Transparent Color Index|1 (Byte)|-|透過する色のインデックス|
|Block Terminator|1 (Byte)|0x00|ブロック並びの終わり|


# Image Block
## Image Blockの全体像
|名称|バイト数|
|---|---|
|Image Data Header|10(Byte)|
|固有パレット|可変(省略可能)|
|LZW最小コードサイズ|1(Byte)|
|Blocks|可変|
|Block Terminator|1(Byte)|

## Image Data Header
|名称|サイズ|概要|
|---|---|---|
|目印|1(Byte)|0x2C|
|「Left」位置|2(Byte)|複数個「Block」がある場合の開始位置|
|「Right」位置|2(Byte)|複数個「Block」がある場合の開始位置|
|横幅|2(Byte)||
|縦幅|2(Byte)||
|いろいろなフラグ|1(Byte)|固有パレットの有無(1bit) : 0(存在しない) 1(存在する) <br>インターレス(1bit) : 0(あり) 1(なし) <br> 固有パレットのソートフラグ(1bit) : 0(未ソート) 1(色の重要度順に整列) <br> 予約(2bit) : 未使用 <br> 固有パレット数(3bit) : 0~7(固有パレットが存在する場合)|

## LZW最小コードサイズ
最初の辞書のサイズ(LZW圧縮最小ビット数)(2~8)

LZWを展開するときに重要になる情報

## Blocks(複数個ある場合あり)

データ数が多ければこのBlockの数が複数個になる場合もある

|名称|サイズ|
|---|---|
|Block Size|1(Byte)|
|Image Data|可変|

## Block Terminator

最後の「Block」の後に「0x00(0)」が書き込まれる

# Trailer
ファイルの終端

必ず「0x3b」アスキー文字(;)


# 参考
基本構造

http://www.tohoho-web.com/wwwgif.htm

圧縮アルゴリズム

https://nodamushi.hatenablog.com/entry/20090531/1243775161

http://bttb.s1.valueserver.jp/wordpress/blog/2018/12/23/gif-lzw-comp/