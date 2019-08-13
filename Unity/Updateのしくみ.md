# Unity公式ブログの記事

```
Updateはどのように呼ばれているのか
「…System.Reflectionだ！そうだろう！！」…いえ、UnityはSystem.Reflectionを使ってメソッドを調べて毎回呼んでいる訳ではありません。

代わりに、任意の型のMonoBehaviourが初めてその基底のスクリプトにアクセスしたときに、スクリプティングランタイム(MonoもしくはIL2CPP)によって何かのマジックメソッドが定義されているかを調査され、この情報がキャッシュされます。もしMonoBehaviourが特定のメソッドを持っていたら所定のリストに追加されます。例えばスクリプトがUpdateメソッドを持っていたら「毎フレームUpdateを呼ぶべきスクリプトのリスト」に追加されるわけです。

ゲーム中は、Unityは短にこのリストをイテレーションしてメソッドを呼んでいきます – シンプルです。また、これがUpdateメソッドのアクセス権がpublicであろうとprivateであろうと関係ない理由でもあります。
```

# 解読

## System.Reflection
### 参考
- https://qiita.com/dolls/items/c7b3cf2520baae158a3a
- https://ufcpp.net/study/csharp/sp_reflection.html
- Typeが重要そう?
    - https://docs.microsoft.com/ja-jp/dotnet/api/system.type?redirectedfrom=MSDN&view=netframework-4.8

### まとめてみる
- C#にはTypeというメソッドがあり、そのメソッドでクラスのメタデータを取得して、クラス内のメンバ変数、メソッドなどを呼び出すことができるもの
- Typeについてはもう少し勉強が必要なきがする
- c#4.0以降が利用できるのであれば、dynamicで同じようなことができるっぽい

## MonoBehaviour
### 参考
- https://docs.unity3d.com/jp/current/ScriptReference/MonoBehaviour.html
- https://unity.exp.jp/archives/46
- http://albatrus.com/main/unity/8737

### まとめてみる
- MonoBehaviour継承ツリー
    - Object
    - Component
    - Behavior

- MonoBehaviourを継承すると
    - Unityヒエラルキー上のゲームオブジェクトにアタッチできる
    - コルーチンを使用することができるようになる

## イテレーション
- 反復・繰り返し