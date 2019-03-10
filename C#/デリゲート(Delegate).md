# デリゲート(Delegate)とは？

- 関数を入れることのできる変数
- コールバックによく使われる

## 使用例
```C#
using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1 t = new Test1();

            t.Method();
        }


    }

    public class Test1
    {

        //Test2を作成しMethodを実行する
        public void Method()
        {
            Test2 test2 = new Test2();

            Test2.Delegate delegateMethod = CallBack;
            test2.Method(delegateMethod);
        }

        //Test2の処理が終わったら呼ばれる
        public void CallBack()
        {
            Console.WriteLine("処理終わったよー");
        }
    }

    public class Test2
    {

        //引数及び返り値のないデリゲート
        public delegate void Delegate();

        //何らかの処理をした後、入力されたデリゲートを実行する
        public void Method(Delegate delegateMethod)
        {
            /*処理*/

            delegateMethod();
        }

    }
}

```
