# swiftのOptionalとは

変数に「nil」(C#でいうnull)を入れられるようにする型

## 基本構文

型の後ろに「？」をつける
```swift
var 変数名 : 型？
```

# optional型使用時の注意点

- オプショナル型はオプショナル型として扱われる

```swift
var firstName : string?
var secondName : string

firstName = nil
secondName = "田中"

var fullName = firstName + SecondName

//結果 : Error
```
 普通のstring型同士の結合ならエラーにはならないが、firstNameをoptional型で宣言しているのでstring型の振る舞いはできずにエラーになった

string型として扱いたい場合は「!」をoptional型の変数名の末尾につけるとその型として扱うことができる

```swift
var fullName = firstName! + SecondName
```

- firstNameが「nil」の状態で「!」をつけるとエラーになる