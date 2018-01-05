{-Левая и правая свертка
foldl :: (a -> a -> a) -> [a] -> a
foldl f [x]         =  x
foldl f (x:(y:ys))  =  foldl1 f (f x y : ys)

foldr :: (a -> a -> a) -> [a] -> a
foldr f [x]     =  x
foldr f (x:xs)  =  f x (foldr1 f xs)
-}

foldl' :: (b -> a -> b) -> b -> [a] -> b
foldl' f x []     = x
foldl' f x (y:ys) = foldl' f (f x y) ys

foldr' :: (a -> b -> b) -> b -> [a] -> b
foldr' f x []     = x
foldr' f x (y:ys) = f y (foldr' f x ys)

--Другие функции полученные из правой и левой свертки
flatMap' :: (a -> [b]) -> [a] -> [b]
flatMap' _ []   = []
flatMap' f list = foldr' (\y ys -> (f y) ++ ys) [] list

map' :: (a -> b) -> [a] -> [b]
map' _ []   = []
map' f list = foldr' (\y ys -> (f y):ys) [] list

filter' :: (a -> Bool) -> [a] -> [a]
filter' _ []   = []
filter' f list = foldr' (\y ys -> if (f y) then (y:ys) else ys) [] list

concat' :: [a] -> [a] -> [a]
concat' [] []       = []
concat' list1 list2 = foldr' (\y ys -> y:ys) list2 list1

maxBy' :: (a -> Integer) -> [a] -> a
maxBy' f list = let hl = head list in foldr' (\y max -> if (f y) > (f max) then y else max) hl list

minBy' :: (a -> Integer) -> [a] -> a
minBy' f list = let hl = head list in foldl' (\min y -> if (f y) < (f min) then y else min) hl list

reverse' :: [a] -> [a]
reverse' []   = []
reverse' list = foldl' (\ys y -> y:ys) [] list

elementAt' :: Integer -> [a] -> a
elementAt' index (y:ys) = res
                           where (_, res) = foldl' (\pairIndex y -> let (curIndex, value) = pairIndex in
                                                                        if (curIndex < index) then (curIndex + 1, value)
                                                                        else if (curIndex == index) then (curIndex + 1, y)
                                                                        else (curIndex, value)) (0, y) (y:ys)

indexOf' :: String -> [String] -> Integer
indexOf' str list = let pr = foldl' (\pairIndex y -> let (index, flag) = pairIndex in 
                                                        if (not flag) then if (y == str) then (index, True) else (index + 1, False)
                                                        else pairIndex) (0, False) list in let (index, _) = pr in index