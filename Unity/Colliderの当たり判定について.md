# unityのボックスコライダーの深いところ

## 目次

1. Coliderとは
2. 使い方
3. 詳細な設定

## Colliderとは

- 物理衝突のためのオブジェクト形状を定義する
- コライダーは目に見えない
- オブジェクトのメッシュと同じ形状にする必要はない

## 単純形状のCollider

- Box Collider
- Sphere Collider
- Capsule Collider

上記の3つをプリミティブColliderともいう

## meshに沿ったMesh Collider

- プリミティブColliderよりも処理負荷が高い
- meshに沿わせることができるので正確な当たり判定が取れる
- 公式はあまり推奨してない？

### Convexオプションについて

- Mesh Collider同士の衝突を判定できる
- プリミティブColliderとの当たり判定はConvexオプションをオンにせずに実行可能