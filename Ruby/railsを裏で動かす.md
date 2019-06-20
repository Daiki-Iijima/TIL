# ruby on rails 裏でServerを動かす

- デーモンで起動

```
rails s -d
```

- 停止

```
kill `cat tmp/pids/server.pid`
```