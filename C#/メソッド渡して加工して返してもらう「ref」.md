# 値自体を変えたい場合

## 値の参照渡し「ref」を使用する

```C#
class SuperClass
{
	public int CountUp(ref int data)
	{
  	data++;
  	return data;
	}

	static void Main(string[] args)
	{
 	 	var data =1;
  	var p = new SuperClass();
    
    //参照を渡すときはrefをつける
    Console.WriteLine(p.CountUP(ref data));	//2
    
    Console.WriteLine(data)	//2
	}
}
```

- 「ref」を修飾子としてつけることで「変数data」の参照を引数に渡すことができる
- 参照した変数に対してインクリメントしているので元の渡した変数自体もインクリメントされた

## ローカル変数は参照渡しできない

```C#
public ref int ReturnRef(int data)
{
  return ref data;
}
```

- ローカル変数は、本来、メソッドを終えた時点で消去されるべきものなので参照渡しはできない
