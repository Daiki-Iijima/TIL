# 目次

1. リポジトリのクローンと初期化
2. MSBuildに参照を紐づける
3. 使用したいライブラリをインストール

# １.リポジトリのクローンと初期化

1. リポジトリをクローン
    ```c#
    git clone https://github.com/microsoft/vcpkg.git
    ```

2. ディレクトリをvcpkgに移動
    ```c#
    cd vcpkg
    ```

3. **vcpkg.exe**の生成
    ```c#
    bootstrap-vcpkg.bat
    ```

# ２.MSBuildにライブラリ参照を紐づける

- **管理者権限で実行(初回のみ)**
    ```c#
    vcpkg integrate install
    ```

# ３.使用したいライブラリをインストール

```c#
vcpkg install {インストールしたいパッケージ名}
```

# エラー対応
```bash
Warning: The following VS instances are excluded because the English language pack is unavailable.
    C:\Program Files (x86)\Microsoft Visual Studio\2017\Community
Please install the English language pack.
Could not locate a complete toolset.
```

- Visual Studioに英語言語パックをインストールする
