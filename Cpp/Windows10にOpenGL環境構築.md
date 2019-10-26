# FreeGLUTをインストールする

# freeGLUTをダウンロード
http://freeglut.sourceforge.net/index.php#download

- いいところに解答

# CMakeをインストール

1. 公式サイトからインストーラをダウンロード
    https://cmake.org/download/
    - .msiファイルをダウンロード

# freeGLUTをCMakeでビルド
1. buildフォルダをfreeGLUT直下に作成
2. CMakeでfreeGLUTをSouceとして指定
3. CMakeでfreeGLUT/buildにbuildを指定
4. ComfigでインストールしてあるVisualStudioを指定
5. Genarete

# buildしたfreeGLUTをVisual StudioでBuild
1. ビルド-> バッチビルドですべてを選択してBuild
2. これで使える?
