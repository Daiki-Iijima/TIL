# Xcodeを使用して開発する
1. プロジェクト名
2. Build Phases
3. Link Binary With Libraries
4. +マーク
5. 「GLUT.framework」「OpenGL.framework」を追加
  - 検索で「GL」とかでひっかかるはず

# ソースでの使用方法
インクルードして使う

```c＋＋
#include <OpenGL/OpenGL.h>
#include <GLUT/GLUT.h>
```
