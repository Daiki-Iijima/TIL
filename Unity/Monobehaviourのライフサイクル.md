# Monobehaviourライフサイクルについて

- 以下公式リファレンスを読んで自分でまとめた
  https://docs.unity3d.com/ja/2018.1/Manual/ExecutionOrder.html

# 覚えておきたい実行順序

## シーンロード時
1. Awake
2. OnEnable
3. Start
4. Update

## シーン終了時
1. OnApplicationQuit
2. OnDisable

## オブジェクト消去時
1. OnDestroy