# Shader描きたい 基礎編

## Standard Surface Shader を選択して作ったファイルの中身と自動生成コメントの翻訳

```shader
Shader "Custom/Shader1"
{
    //  =============== インスペクタに表示する公開変数の定義 =============
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }

    //  ============================================================

    SubShader
    {
    //  ================= ライティング・透明度などの設定 ================
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // 物理ベースの標準照明モデル、およびすべてのライトタイプの影を有効にします
        #pragma surface surf Standard fullforwardshadows

        // シェーダーモデル3.0ターゲットを使用して、見栄えの良い照明を得る
        #pragma target 3.0
    //  ============================================================
    
    //  ==================== シェーダ本体のプログラム ==================
        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        // このシェーダーのインスタンス化サポートを追加します。 シェーダーを使用するマテリアルで「インスタンスを有効にする」をチェックする必要があります。
        // インスタンス化の詳細については、https：//docs.unity3d.com/Manual/GPUInstancing.htmlを参照してください。
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
        // ここにインスタンスごとのプロパティを追加します
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // アルベドは色によって着色されたテクスチャーから来ます
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            // メタリックと滑らかさはスライダー変数に由来します
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
    //  ==============================================================
        ENDCG
    }
    FallBack "Diffuse"
}

```

## 大きく分けて3つのブロックに分かれている

1. インスペクタに表示する公開変数の定義
2. ライティング・透明度などの設定
3. シェーダ本体のプログラム