data Dyn = Fun (Dyn -> Dyn)
         | App {func :: Dyn, arg :: Dyn}
         | Char Char
         | Int Integer

reduce (App (Fun f) a) = f a
reduce (App a b) = reduce $ App (reduce a) b

instance Show Dyn where
    show (Char a) = "Dynamic " ++ show a
    show (Int a) = "Dynamic " ++ show a
    show (Fun _) = "- function"
    show a@(App f x) =  show $ reduce a

instance Ord Dyn where
    (<=) (Char a) (Char b) = a <= b
    (<=) (Int a) (Int b) = a <= b
    (<=) (App (Fun f) a) b = (f a) <= b
    (<=) b (App (Fun f) a) = b <= (f a)
    (<=) _ _ = undefined

instance Eq Dyn where
    (==) (Char a) (Char b) = a == b
    (==) (Int a) (Int b) = a == b
    (==) (App (Fun f) a) b = (f a) == b
    (==) b (App (Fun f) a) = (f a) == b
    (==) _ _ = undefined
   
instance Num Dyn where
    fromInteger = Int

    (*) (Int a) (Int b) = Int $ a * b
    (*) (App (Fun f) a) b = (f a) * b
    (*) b (App (Fun f) a) = (f a) * b
    (*) _ _ = undefined

    (+) (Int a) (Int b) = Int $ a + b
    (+) (App (Fun f) a) b = (f a) + b
    (+) b (App (Fun f) a) = (f a) + b
    (+) _ _ = undefined

    abs (Int a) = Int $ abs a
    abs (App (Fun f) a) = abs (f a)
    abs _ = undefined

    signum (Int a) = Int $ signum a
    signum (App (Fun f) a) = signum (f a)
    signum _ = undefined

    negate (Int a) = Int $ negate a
    negate (App (Fun f) a) = negate $ f a
    negate _ = undefined

instance Enum Dyn where
    fromEnum (Char c) = fromEnum c
    fromEnum (Int i) = fromEnum i
    fromEnum (App (Fun f) a) = fromEnum $ f a
    fromEnum _ = undefined

    toEnum = Int . toInteger 

instance Integral Dyn where
    quotRem (Int a) (Int b) = (Int c, Int d) where (c, d) = quotRem a b
    quotRem (App (Fun f) a)  b = quotRem (f a) b
    quotRem a (App (Fun f) b) = quotRem a (f b)
    quotRem _ _ = undefined

    toInteger (Int i) = i
    toInteger (App (Fun f) a) = toInteger $ f a
    toInteger _ = undefined

instance Real Dyn where
    toRational (Int i) = toRational i
    toRational (App (Fun f) a) = toRational $ f a
    toRational _ = undefined 

-- Комбинаторы
i :: Dyn 
i = Fun id

k :: Dyn
k  = Fun ( \a -> Fun $ \_ -> a )

s :: Dyn -> Dyn -> Dyn -> Dyn
s f1 f2 a = App (App f1 a) (App f2 a)