# ポリモーフィズムにおいてオーバーライドを保証する

- 抽象メソッドを使用する
- 抽象メソッドを含んだクラスを抽象クラスという

# 抽象メソッド(クラス)とは

- それ自体は中身(機能)を持たない「空のメソッド」

- 抽象クラスを継承したクラスは、すべての抽象メソッドをオーバーライドしなければならない(オーバーライドの強制)

- 抽象クラスはインスタンス化できない(実装がないので)

  ```C#
  [アクセス修飾子] abstract class クラス名
  {
      [アクセス修飾子] abstract 戻り値の型 メソッド名(引数の型　引数名,...);
  }
  ```

  ## サンプル

  ```C#
  	//抽象基底クラス
      abstract class Figure
      {
          public double Width { get; set; }
          public double Height { get; set; }
  
          public Figure(double width,double height)
          {
              this.Width = width;
              this.Height = height;
          }
  
          // 抽象メソッド
          // メソッドのブロック({})はいらない
          // virtual修飾子はいらない
          public abstract double GetArea();
      }
  ```

# 抽象クラスの問題点

- 多重継承ができない(1つの抽象メソッドのみしか継承できない)

- 不要なオーバーライドをしなければいけなくなる可能性がある
