# bool値の名前
# true とfalseの意味を明確にする

## 例 ) bool read_password = true;

## 問題 : 変数名が複数の意味にとれる
1. パスワードを**これから読み取る必要がある**
2. パスワードを**すでに読み取っている**

## 解決 : 変数名を明確にする
1. パスワードを**これから読み取る必要がある**
    - need_password
2. パスワードを**すでに読み取っている**
    - user_id_authenticated
## 変数名の頭につけやすい名前
- is
- has
- can
- should

# 変数名を否定形にしない

## sslを使用したか
- BAD
    - disable_ssl
- GOOD
    - use_ssl
