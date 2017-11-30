data Term = IntConstant{ intValue :: Int }    
            | Variable{ varName :: String }    
            | BinaryTerm{ lhv :: Term, rhv :: Term } deriving(Show,Eq)