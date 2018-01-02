import Data.Char

main = putStrLn "Hello s, world!"

discount :: Double -> Double -> Double -> Double
discount limit proc sum = if sum >= limit then sum * (100 - proc) / 100 else sum

standardDiscount = discount 1000 5


twoDigits2Int :: Char -> Char -> Int
twoDigits2Int x y = if ((x=='1')||(x=='2')||(x=='3')||(x=='4')||(x=='5')||(x=='6')||(x=='7')||(x=='8')||(x=='9')||(x=='0'))&&((y=='1')||(y=='2')||(y=='3')||(y=='4')||(y=='5')||(y=='6')||(y=='7')||(y=='8')||(y=='9')||(y=='0')) 
then (ord x - 48) * 10 + (ord y - 48) else 100