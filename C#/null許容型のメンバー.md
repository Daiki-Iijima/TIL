# null許容型を使用した場合に使える便利なメンバー

|          |                                                        | 
|----------|--------------------------------------------------------| 
| プロパティ    | 概要                                                     | 
| HasValue | null許容型が値を持っているか(nullの場合はfalse)                        | 
| Value    | null許容型が保持している値(nullの場合はInvalidOperationException(例外)) | 

# 例

```C#
//変数numが値を持っていれば、その値を取得

int? = 1

if(num.HasValue)
{
  //iにnumの値を代入
  int i = num.Value;
}

```
