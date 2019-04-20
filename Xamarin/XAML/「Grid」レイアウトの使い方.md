# Grid

一番シンプルなパターン

```xaml
 <Grid>
   <!--列-->
   <Grid.ColumnDefinitions>
     <ColumnDefinition />
     <ColumnDefinition />
     <ColumnDefinition />
     </Grid.ColumnDefinitions>
   <!--行-->
    <Grid.RowDefinitions>
      <RowDefinition />
      <RowDefinition />
      <RowDefinition />
   </Grid.RowDefinitions>
   
   <!--ここからデータの挿入-->
   <BoxView Color="Red" /> <!-- デフォルトは0,0に配置される -->
   
   <BoxView Color="Blue" 
            Grid.Row="0"
            Grid.Column="1" />
   
   <BoxView Color="Aqua" 
            Grid.Row="0"
            Grid.Column="2" />
   
   <BoxView Color="Maroon" 
            Grid.Row="1"
            Grid.Column="0" />
   
   <BoxView Color="Navy" 
            Grid.Row="1"
            Grid.Column="1" />
   
   <BoxView Color="Silver" 
            Grid.Row="1"
            Grid.Column="2" />
   
   <BoxView Color="Purple" 
            Grid.Row="2"
            Grid.Column="0" />
   
   <BoxView Color="Lime" 
            Grid.Row="2"
            Grid.Column="1" />
   
   <BoxView Color="Yellow" 
            Grid.Row="2"
            Grid.Column="2" />
</Grid>
```

- 最初の「Grid.ColumnDefinitions」「Grid.ColumnDefinitions」で列数と行数を定義している
- 「<RowDefinition />」「<ColumnDefinition />」の数が列数、行数
- 「Grid.Row = "X"」Xが行番号(0から始まる)
- 「Grid.Colum = "X"」Xが列番号(0から始まる)
- 行番号・列番号を指定しない場合は、「 Row = 0 , Colum = 0 」になる
