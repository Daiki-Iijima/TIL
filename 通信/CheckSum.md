# チェックサム
データが信頼できるものか(送信中に破損してないかetc..)を確認するためのチェック法

#メリット
- アルゴリズムが簡単
- 動作が軽い

# デメリット
- 他のチェック方法に比べると信頼性は低い
(CRC,MD5)

# アルゴリズム
- 目標
I can do it を送信する
[ICANDOIT]

データ部の各バイトの和を8ビット幅で計算し、データ部の各バイトの総和を16ビットのアスキー文字列2文字で表現します。

- 文章を理解する

データ部を8ビットなのでまずは8ビットに変換する

```C#

string st = ICANDOIT;

byte[] stbytes = System.Text.Encoding.ASCII.GetBytes(st);

int sum = 0;

forech(byte data in stbytes)
{
    sum += data;
}

string CheckSum = sum.ToString(X2);

```


# 参考
- Wiki
https://ja.m.wikipedia.org/wiki/%E3%83%81%E3%82%A7%E3%83%83%E3%82%AF%E3%82%B5%E3%83%A0

- 8ビット加算知恵袋
https://detail.chiebukuro.yahoo.co.jp/qa/question_detail/q12155715972

- AscIIコード表
https://www.k-cube.co.jp/wakaba/server/ascii_code.html