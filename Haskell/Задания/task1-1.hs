data Term = IntConstant{ intValue :: Int }    
            | Variable{ varName :: String }    
            | VarAdd{ addL :: Term, addR :: Term }
            | VarMulti{ multiL :: Term, multiR :: Term }
            | VarSub{ subL :: Term, subR :: Term }
            | UnMin{ unmin :: Term }
            deriving(Show,Eq)

(<+>) :: Term -> Term -> Term
a <+> b = VarAdd a b

(<*>) :: Term -> Term -> Term
a <*> b = VarMulti a b

(<->) :: Term -> Term -> Term
a <-> b = VarSub a b

--Выставляем приоритет и ассоциативность слева
infixl 6 <+>,<->
infixl 7 <*>

--Функция замены
replaceVar :: String -> Int -> Term -> Term
replaceVar _ _ t@IntConstant{} = t 
replaceVar x z Variable{ varName = x' } | x==x' = IntConstant z
                                        | otherwise = Variable x'
replaceVar x z VarAdd{ addL=l,addR=r } = VarAdd (replaceVar x z l) (replaceVar x z r)
replaceVar x z VarMulti{ multiL=l,multiR=r } = VarMulti (replaceVar x z l) (replaceVar x z r)
replaceVar x z VarSub{ subL=l,subR=r } = VarSub (replaceVar x z l) (replaceVar x z r)
replaceVar x z UnMin{ unmin=n } = UnMin (replaceVar x z n)
 
