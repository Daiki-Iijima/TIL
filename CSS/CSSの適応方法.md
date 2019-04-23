# CSSをHTML文書に適応させる方法

1. 「link」要素で外部CSSファイルを呼び出して適用する
2. 「style」要素で文書単位に適用する
3. 要素にstyle属性を追加して局所的に適用する

# 「link」要素で外部CSSファイルを呼び出して適用する

- 「head」要素内に<link>要素を記述し、外部CSSファイルを指定

```html

<html>
  <head>

<!--cssを指定-->
    <link 
      rel ="stylesheet" 
      type = "text/css" 
      href = "xxx.cs"
    >
<!--ここまで-->
  </head>

  <body>
    <p> 段落となります。</p>
  </body>
</html>

```

# 「style」要素で文書単位に適用する

- スタイルシートの要素を直接指定する
- スタイルシート部分を<!ーー>でコメントにするのは、スタイルシートに対応していない古いブラウザで「style」要素の内容がそのまま表示されてしまうのを防ぐためです


```html

<html>
  <head>

<!--cssの要素を指定-->

  <style type="text/css">
    <!--
    p {color:blue; line-height:1.5;}
    -->
  </style>

<!--ここまで-->

  </head>

  <body>
    <p> 段落となります。</p>
  </body>
</html>

```

# 要素にスタイル属性を追加して局所的に追加する

- HTMLソース内に直接スタイル指定を記述する

```html
<html>
  <head>
    <meta name="Content-Style-Type"
    content="text/css">
  </head>

  <body>

    <!--直接スタイルシートを指定-->
    
    <p style="color:blue; line-height:1.5;">
    段落となります。
    </p>
    
    <!--ここまで-->
  
  </body>
</html>
```
