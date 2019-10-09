# KotlinでJsonを扱う

# Jsonを扱えるライブラリ

1. GSON
  - Googleが作ったJsonライブラリ
2. Kotshi
  - JavaのMoshiをJson変換ライブラリをKotlin用に拡張したもの
3. Jackson
  - これもJavaライブラリの拡張したもの？
  - https://github.com/FasterXML/jackson

# GSON使ってみる

https://qiita.com/HanaleiMoon/items/c1b8aa26732ac120a230

## ライブラリインストール

1. 「build.gradle(Module: app)」に宣言
    ```kotlin
    //  Json用ライブラリGSONを使用するための宣言
    implementation 'com.google.code.gson:gson:2.8.5'
    ```
## 使用方法

```kotlin
fun test(){
    val map : MutableMap<String, String> = mutableMapOf()
    map.put("a1", "A1")
    map.put("a2", "A2")
    map.put("a3", "A3")

    val gson = Gson()
    val jsonString : String = gson.toJson(map)
    Log.d("Kotlin", jsonString)
    val type : Type = object : TypeToken<MutableMap<String, String>>() {}.type

    val map2 : MutableMap<String, String> = gson.fromJson(jsonString, type)
    for (mapValue in map2.values) {
        Log.d("Kotlin", mapValue)
    }
}
```