# 具体的なエラー

Unsupported Modules Detected: Compilation is not supported for following modules: ToDoApp, Kotlin_ToDoApp. Unfortunately you can't have non-Gradle Java modules and Android-Gradle modules in one project.

# 対策方法

- プロジェクトファイルの「.ide」ディレクトリを消去
- プロジェクトファイル内の「.iml」拡張子のファイルをすべて消去