# 作業手順

# git pull
ソースコードを最新の状態に更新

# git branch **
作業ブランチを切る

# git checkout **
作業ブランチへ移動

# 作業、テスト、コミット
'''
git add .
git commit
'''

# git checkout master

作業中に他の人が更新している可能性があるのでmasterを更新するために移動

# git pull
最新のバージョンを取得

# git checkout **
作業ブランチに戻る

# git rebase master
rebase : 自分の変更が先頭になるようにする
(もちろんコンフリクトする事もある)

# git checkout master
masterに移動

# git merge **
作業ブランチをmasterと合体させる
rebaseしているから問題なくいけるはず

# git push origin master

