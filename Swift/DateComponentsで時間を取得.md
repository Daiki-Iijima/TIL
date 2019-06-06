# [Swift]DateComponentsで時間を操る



## DateComponentsとは

- 年月日時分秒を個別に管理するクラス

##  現在の日付の取得

- DateメソッドをDateComponentsメソッドに変換する

```swift
//  第一引数には指定したい日時の要素を指定
//  第二引数にはDateメソッドを指定
let nowComponents = Calendar.current.dateComponents(
  [.year,.month,.day,.hour,.minute], 
  from: Date()
)

//  バックスラッシュ入力方法
//  optionキー + ¥キー
print("現在の日付 \(nowComponents)")

//結果 : 
//現在の日付 year: 2019 month: 5 day: 29 hour: 17 minute: 58 isLeapMonth: false
```

- 各要素を一つずつ取り出す

  ```swift
  print("\(nowComponents.year!)年")
  print("\(nowComponents.month!)月")
  print("\(nowComponents.hour!)時")
  print("\(nowComponents.minute!)分")
  
  //  結果 :
  //  2019年
  //  5月
  //  18時
  //  2分
  ```

- DataComponentsの宣言時に取得していない情報を取得しようとするとエラーになる

  ```swift
  //取得していない秒を設定した場合
  print("\(nowComponents.second)秒")
  // 結果 : nil秒
  ```

  
