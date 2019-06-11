# Swift4でTableViewを実装する

## 目次

1. プロジェクト作成
2. レイアウト作成
3. コード記述
4. 結果

## 1. プロジェクト作成

- Single View Appでプロジェクトを作成
- Main.storyboardを開く

<img width="1440" alt="1" src="https://user-images.githubusercontent.com/40718695/57977246-533bf280-7a2f-11e9-99a5-a90b4b94fc51.png">

## 2. レイアウト作成

- Safe Area内にTableViewを追加

  <img width="456" alt="2" src="https://user-images.githubusercontent.com/40718695/57977248-58993d00-7a2f-11e9-80ca-4a89c9da8218.png">

  <img width="1440" alt="3" src="https://user-images.githubusercontent.com/40718695/57977249-59ca6a00-7a2f-11e9-9e1d-a2913260b5a2.png">

- Table ViewをViewController.swiftにOutlet接続

 <img width="1440" alt="4" src="https://user-images.githubusercontent.com/40718695/57977250-5cc55a80-7a2f-11e9-89fe-fb7bca7e6586.png">

- Name部分をわかりやすい名前にしてConnect

 <img width="259" alt="5" src="https://user-images.githubusercontent.com/40718695/57977251-5e8f1e00-7a2f-11e9-890a-6e147cfa7a1d.png">



## 3. コードの記述

```swift
import UIKit

// UITableViewDataSourceを実装
class ViewController: UIViewController,UITableViewDataSource{

    // テーブルビューを、Outlet接続する。
    @IBOutlet weak var tableView: UITableView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
      
        // テーブルビューのデータソースとしてViewControllerを指定
        self.tableView.dataSource = self
        
    }
    
    // cellを返す。
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        
        let cell = UITableViewCell()
        
        //行数を表示
        cell.textLabel?.text = "テスト:[\(indexPath.row)]"
        
        return cell
    }
    
    // セルの数をいくつにするか。
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return 100
    }
}

```



## 結果
<img width="406" alt="6" src="https://user-images.githubusercontent.com/40718695/57977253-5fc04b00-7a2f-11e9-9294-047e53f17bf5.png">
