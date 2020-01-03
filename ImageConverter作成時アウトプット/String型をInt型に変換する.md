# std::stoiの概要

- string型を数値(int型)として読み取って、int型に変換する
- 戻り値はint型

## 日本語リファレンス

https://cpprefjp.github.io/reference/string/stoi.html

# 引数

```c++
int stoi(const std::string& str, std::size_t* idx = nullptr, int base = 10); 
```

| 引数名 | 概要                                                         |
| ------ | ------------------------------------------------------------ |
| str    | 変換したい文字列(string,wstring)                             |
| idx    | size_t型が欲しい時に指定する,基本はnullptrでおけ,https://cpprefjp.github.io/reference/cstddef/size_t.html |
| base   | 変換したい進数、指定しない場合10進数に変換される             |

- 「base」に0を指定した場合、基数を自動的に変換する

  | 頭文字 | 変換される進数 |
  | ------ | -------------- |
  | 0      | 8進数          |
  | 0x,0X  | 10進数         |

# 使用例

```c++
#include <iostream>

using namespace std;

int main(int argc, const char * argv[]) {
   
    
    string binaryStr = "1010";
    string octStr = "12";
    string disStr = "10";
    string hexStr = "0x0A";
    
    int binaryNum = stoi(binaryStr,nullptr,2);
    int octNum = stoi(octStr,nullptr,8);
    int disNum = stoi(disStr,nullptr,10);   //  stoi(disStr);でも同じ
    int hexNum = stoi(hexStr,nullptr,16);
    
    cout << "2進数 : " << binaryStr << " = " << binaryNum << endl; //  2進数
    cout << "8進数 : " << octStr << " = " << octNum << endl;     //  8進数
    cout << "10進数 : " << disStr << " = "<< disNum << endl;    //  10進数
    cout << "16進数 : " << hexStr << " = "<< hexNum << endl;    //  16進数
    
    return 0;
}
```

## 出力

```出力
2進数 : 1010 = 10
8進数 : 12 = 10
10進数 : 10 = 10
16進数 : 0x0A = 10
```



# 似たような関数

- `stol`: 戻り値の型が`long`となったもの。
- `stoll`: 戻り値の型が`long long`となったもの。
- `stoul`: 戻り値の型が`unsigned long`となったもの。
- `stoull`: 戻り値の型が`unsigned long long`となったもの。
- `stof`: 戻り値の型が`float`となったもの。
- `stod`: 戻り値の型が`double`となったもの。
- `stold`: 戻り値の型が`long double`となったもの。