```ruby
class Main

  # FizzBuzz
  (1..100).each do |i|                  #=> 1から100までのループ
    case i % 15                         #=> 対象の数字を「15で割ったあまり」で条件分岐
    when 0        then puts "FizzBuzz"
    when 3,6,9,12 then puts "Fizz"
    when 5,10     then puts "Buzz"
    else               puts i           #=> 全てに該当しなかった場合「i」を出力
    end
  end
  
end
```
