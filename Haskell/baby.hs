import qualified Data.Map as Map

doubleMe x = x+x
doubleUs x y = x*2+y*2
double x y = doubleMe x + doubleMe y
doubleSmallNumber x = if x < 100 then x*2 else x
ppp :: Int->[Int]
ppp b = [a | a<-[1..b], odd a]
factorial :: Int -> Int
factorial n = product [1..n]
factorial' :: Integer -> Integer
factorial' n = product [1..n]

lucky :: Int->String
lucky 7 = "Pasha pidr"
lucky x = "Sorry, friend. Pasha pidr"

fact:: Int->Int
fact 0 =1
fact n = n*fact(n-1)

head'::[a]->a
head' [] = error "Idi nahyi"
head' (x:_) =x

prog::Int->Int
prog xy = case xy of 25->20; 35->30; ab->40

sumir' :: Num a=>[a]->a
sumir' [] = 0
sumir' [x] =x
sumir' (x:xs) = x+ sumir' xs






 