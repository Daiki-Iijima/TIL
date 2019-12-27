# 部分一致を判定する

- string型には「contains」が定義されていない
- 代わりに、「find」関数の戻り値を判定することで部分一致を判定できる

# サンプル

## 文字列(string型)の判定
```c++
std::string str = "test"; 
std::string findStr = "es";

if (str.find(findStr) != std::string::npos) {
   purintf("文字列[%s]が見つかりました",findStr);
}

==> 文字列[es]が見つかりました
```

## 文字(char型)の判定
```c++
std::string str = "test"; 
char findChar = 'e';

if (str.find(findChar) != std::string::npos) {
   purintf("文字列[%s]が見つかりました",findChar);
}

==> 文字列[es]が見つかりました
```
