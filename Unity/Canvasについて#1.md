## 概要

- Canvasの設定項目について  #1
- CanvasScalerの設定項目について  #2
- GtaphicRaycasterの設定項目について  #3

## Canvasの設定項目について

### RenderMode
  
#### Screen Space - Overlay
- スクリーンサイズに合わせて拡大縮小される
- オブジェクトの上に描画される
    
#### Screen Space - Camera
- 指定したカメラと一定の距離をとってレンダリングされる
- UIの大きさはカメラの錐台内で収まるように錐台のサイズに合わせてUIのサイズも変わる
- UIビューよりも前にObjectがあればObjectはUIの上に描画される
  
  ##### Render Camera

  UIを描画するカメラ

  ##### Plane Distance 

  UIの平面が描画するカメラからどのくらいの距離で配置されるか

#### Pixel Perfect (Screen Spaceモードの時のみ)
- True = アンチエイリアス無し
- False = アンチエイリアス有り

#### World Space
- UIをシーン内の平面オブジェクトのようにレンダリングする
- UIをカメラに対して水平ではなく設置できる
- UIのサイズはスクリーン上のカメラからの距離で決まる
- UIの前にObjectを配置することができる