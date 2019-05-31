Development Consoleの消去方法

# なぜ消すか
- エラーが出ると出てきて邪魔だから

- フレームレートが落ちるから

- 基本はデバッグ時のみ表示するようにする

## 1. Development Buildのチェックマークを外す

## 2. スクリプトで強制的に見えなくする

https://docs.unity3d.com/ScriptReference/Debug-developerConsoleVisible.html

```C#
Debug.developerConsoleVisible = false;

```
- Start内で呼んだ場合、その後にエラーなどをはいた場合はまた表示されてしまう
- 苦肉の策でUpdateで呼んだ