# GIF構造

|ブロック名|有無|サイズ(Byte)|
|---|---|---|
|Header|○|6|
|Logical Screen Descriptor|○|7|
|Global Color Table| 「Logical Screen Descriptor」内のフラグが立っているか|0~?|
|Image Descripotr|○|10|
|Local Color Table|「Image Descriptor」内のフラグが立っているか|0~?|
|||
