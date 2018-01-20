data FunMonad a = FunMonad { fun :: () -> a } 

instance (Show a)=> Show (FunMonad a) where
    show (FunMonad a) = "FunMonad -> " ++ (show $ a ()) 

instance Applicative FunMonad where
    pure x = FunMonad $ \() -> x
    FunMonad a <*> FunMonad b = FunMonad $ \() -> (a ()) (b ())

instance Functor FunMonad where
    fmap f (FunMonad x) = FunMonad (\() -> f (x ()) )

instance Monad FunMonad where
    return a  = FunMonad ( \() -> a )
    m >>= k = k (fun m ())  
    fail = error

--Пример работы
exampleFM x = FunMonad $ \() -> 10*x