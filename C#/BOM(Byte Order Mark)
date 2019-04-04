# BOMとは？
- Byte Order Mark : バイト順マーク
- Unicodeの先頭に付与される数バイト
- 識別するためにつける
 - Unicodeで記述されていること
 - その種類(UTF-8,UTF-16,UTF32)
- UnicodeにBOMは必須ではないうえに、利用しない方がいい

# StreamWriterクラスでBOMの管理
- エンコーディングを指定しなければ付与されない
- 既存のファイルにBOMが付いていた場合、維持される

## エンコーディングを明示するがBOMはつけたくない場合

Encoding.UTF8などのプロパティではなく、UTF8Encodingクラスを使う