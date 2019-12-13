# CentOSダウンロード

## Rasberry Pi3の場合
http://buildlogs.centos.org/centos/7/isos/armhfp/

今回はラズパイに入れるので赤い部分のファイルをダウンロード

![これや](ダウンロード画像.png)

## Rasberry Pi3+の場合
http://isoredirect.centos.org/altarch/7/isos/armhfp/CentOS-Userland-7-armv7hl-RaspberryPI-Minimal-1908-sda.raw.xz

最新のバージョンをダウンロード(このバージョン違いでOSが起動しなくて3時間が溶けた)

![これや](3+ダウンロード.png)

# microSDに焼く

## 「DD for Windows」で焼く
調べた限り、よくこのソフトが使われているが、Windows10の場合、互換モードで起動が必要らしい
- https://www.si-linux.co.jp/techinfo/index.php?DD%20for%20Windows#s74c46f6

## 「balena Etcher」で焼く
こっちは公式がおすすめしているらしい、すごい簡単
- https://www.balena.io/etcher/

# 起動できればOK
