# Dictionaryの初期化

## BAD

```c#
var dict = new Dictionary<string,string>();
dict["ja"] = "日本語";
dict["en"] = "英語";
dict["es"] = "スペイン語";
dict["de"] = "ドイツ語";
```

- コードが冗長になる

## GOOD

- C# 5.0まで

```C#
var dict = new Dictionary<string,string>()
{
    {"ja","日本語"},
    {"en","英語"},
    {"es","スペイン語"},
    {"de","ドイツ語"},
};
```

- C# 6.0以降

```c#
var dict = new Dictionary<string,string>()
{
    ["ja"] = "日本語",
    ["en"] = "英語",
    ["ja"] = "スペイン語",
    ["ja"] = "ドイツ語",
}
```

- キーと対応する値が簡潔に見える
