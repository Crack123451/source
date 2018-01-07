--Наибольший общий делитель двух чисел
maxCommonDiv :: Int -> Int -> Int
maxCommonDiv x y = if x>=y then maximum [n | n<-[1..y] , mod x n==0, mod y n==0] else maximum [n | n<-[1..x] , mod x n==0, mod y n==0]

{-Существует ли натуральное число, являющееся квадратом другого числа, 
между двумя заданными целыми числами?-}
existenceSquare :: Int -> Int -> Bool
existenceSquare x y = not (null [a | a<-[x..y], b<-[x..y], a^2==b])

{-Является ли заданная дата (число, месяц, год) 
корректным числом с учётом високосных годов и количества дней в месяце?-}
correctDate :: (Int, Int, Int)-> Bool
correctDate (a,b,c) = if a>=1 && a<=31 && b>=1 && b<=12 && c>=0 
then if b/=2
then True
else if mod c 4/=0 && a>28  
then False
else if mod c 100/=0 && a<=29 
then True
else if mod c 400==0 && a<=29 
then True
else False
else False