# 実装方法

1. ScriptableObject作成用C#ファイル作成
- EnemyData
    ```c#
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    //  AssetMenuに選択項目を追加する
    [CreateAssetMenu(menuName = "MyScriptable/Create EnemyData")]
    public class EnemyData : ScriptableObject
    {
        public string enemyName;
        public int maxHp;
        public int atk;
        public int def;
        public int exp;
        public int gold;
    }
    ```
    - これはあくまでオブジェクト作成用のコードなので、AssetウィンドウかProjectタブで右クリックで出てくる「MyScriptable」から「Create Enemy Data」を選択してScriptableObectを生成する
2. 生成したScriptableObjectの値を設定  
![スクリーンショット (2)](https://user-images.githubusercontent.com/40718695/61130496-c1fa7100-a4f1-11e9-91ff-22429d453710.png)
3. テスト用のスクリプトの作成
- ScriptableCharaController
    
    ```c#
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ScriptableCharaController : MonoBehaviour
    {

        public EnemyData enemyData;

        void Start()
        {
            ShowScriptableObjectData();
        }

        void Update()
        {

        }

        void ShowScriptableObjectData()
        {
            // 参照しているEnemyDataの中身をコンソールに表示する
            Debug.Log("私の名前は" + enemyData.enemyName +
                    ", 最大HPは" + enemyData.maxHp +
                    ", 攻撃力は" + enemyData.atk +
                    ", 防御力は" + enemyData.def +
                    ", 経験値は" + enemyData.exp +
                    ", ゴールドは" + enemyData.gold + "です。");
        }
    }
    ```
4. 結果

    ```
    私の名前はスライム, 最大HPは4, 攻撃力は3, 防御力は2, 経験値は1, ゴールドは10です。
    ```
