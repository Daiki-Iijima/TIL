# html,css,javascriptの連携サンプル

# HTML

```html
<!DOCTYPE html>

<html>

  <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width" />
    <title>Hello, world!</title>
    <link rel="stylesheet" href="style.css" />
  </head> 

  <body>
    <h1>Hello, world!</h1>
    <div id="test"></div>
    <img src="img/icon.png">
    <script src="script.js"></script> 
  </body>

</html>

```

- <div id="test"></div>

  

# CSS
```css
#test {
  color: red;
  line-height:1.5;
}
```


# Javascript

ロード時にブロック内部を実行する

```

addEventListener('load', function(e) 
{
  var result = document.querySelector('#test')
  result.innerHTML = 'Hello, world!';
  console.log('hello');
});


```

- document.querySelector('#test')

  ページ内の要素を取得する(HTML)

  今回の場合はCSS内のtestタグのついたセレクタ情報を取得してくる
  
- .innerHTML

  前のステップで取得した要素に指定した文字列を設定
  