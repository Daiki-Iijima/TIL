# 同一ネットワークに接続されているIP一覧を取得する

## 前提

- 「using System.Net.NetworkInfomation」が必要

# 処理

```C#

private void CheckPing()
{
    const string ip = "192.168.0.";

    for(inttt i=1;i<=11;i++)
    {
        var p = new Ping();
    
        //  第2引数 : TimeOut: 100ms
        PingReply r = p.Send(ip + i,100);
    
        //  Ping成功時
        if(r.Status == IPStatus.Success)
        {
            Console.WriteLine(ip + i);
        }
        //  Ping失敗時
        else
        {
            Console.WriteLine(ip + i);
        }
    }
}

```

# 使用上の注意

- 別スレッドで処理しないとPing送り終わるまで固まってしまう