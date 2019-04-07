# C#のコレクションAPI

## List(リスト)

- 順番を持つ
- 要素は重複OK
- List,LinkedList,Stack,Queue

## Set(セット)

- 要素に順番はない
- 要素の重複はNG
- HashSet,SortedSet

## Map(マップ)

- キー/値の組で管理
- キーの重複はNG
- Dictionary,SortedDictionary,SortedList

| 分類           | クラス           | 概要                                                |
| -------------- | ---------------- | --------------------------------------------------- |
| リスト         | List             | 要素を順に格納したリスト                            |
|                | LinkedList       | 要素同士を双方向リンクで連結したリスト              |
|                | Stack            | 後入れ先出しのデータ構造                            |
|                | Queue            | 先入れ後出しのデータ構造                            |
| セット         | HashSet          | 重複しないデータの集合(順序を保証しない)            |
|                | SortedSet        | 重複しないデータの集合(順序を保証)                  |
| ディクショナリ | Dictionary       | 基本的なディクショナリ(キーの順序を保証しない)      |
|                | SortedDictionary | キーの順序を管理できるディクショナリ                |
|                | SortedList       | キーの順序を管理できるディクショナリ(2分探索が可能) |

