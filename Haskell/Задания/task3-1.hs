data WeirdPeanoNumber = Zero 
                      | Succ (WeirdPeanoNumber) 
                      | Pred (WeirdPeanoNumber) deriving Show

isSimple :: WeirdPeanoNumber -> Bool
isSimple Zero = True
isSimple (Succ (Pred _)) = False
isSimple (Pred (Succ _)) = True
isSimple (Succ num) = isSimple num
isSimple (Pred num) = isSimple num

simplify' :: WeirdPeanoNumber -> WeirdPeanoNumber
simplify' (Zero) = Zero
simplify' (Succ (Pred num)) = simplify' num
simplify' (Pred (Succ num)) = simplify' num
simplify' (Succ num) = Succ $ simplify' num
simplify' (Pred num) = Pred $ simplify' num

simplify :: WeirdPeanoNumber -> WeirdPeanoNumber
simplify num = let simplified = simplify' num in
                if (isSimple simplified) then simplified
                else simplify simplified

simpleDIV :: WeirdPeanoNumber -> WeirdPeanoNumber -> WeirdPeanoNumber
simpleDIV lhv rhv = let dif = lhv - rhv in
                    if (dif >= Zero) then
                      (simpleDIV dif rhv) + 1
                    else 0

reduce Zero = Zero
reduce (Succ (Pred a)) = reduce a
reduce (Pred (Succ a)) = reduce a
reduce (Succ a) = let rdcd = reduce a in 
                  case rdcd of (Pred b) -> b 
                               _        -> Succ $ rdcd
reduce (Pred a) = let rdcd = reduce a in
                  case rdcd of (Succ b) -> b
                               _ -> Pred $ rdcd


instance Enum WeirdPeanoNumber where
  toEnum num | num == 0 = Zero
             | num < 0 = Pred (toEnum $ num + 1)
             | otherwise = Succ (toEnum $ num - 1) 
  fromEnum Zero = 0
  fromEnum (Succ lhv) = (fromEnum lhv) + 1
  fromEnum (Pred lhv) = (fromEnum lhv) - 1

instance Real WeirdPeanoNumber where
   toRational num = toRational (toInteger num)
   
instance Eq WeirdPeanoNumber where
    (==) a b = rdcdEq (reduce a) (reduce b)
     where
            rdcdEq Zero Zero = True
            rdcdEq Zero _    = False
            rdcdEq _ Zero    = False
            rdcdEq (Pred a) (Pred b) = rdcdEq a b
            rdcdEq (Succ a) (Succ b) = rdcdEq a b
            rdcdEq _ _               = False

instance Ord WeirdPeanoNumber where
    (<=) a b = rcdcOrd (reduce a) (reduce b)
     where
        rcdcOrd (Pred a) (Pred b) = rcdcOrd a b
        rcdcOrd (Succ a) (Succ b) = rcdcOrd a b
        rcdcOrd Zero a  = case a of
                                    Pred _ -> False
                                    _      -> True
        rcdcOrd a Zero  = case a of
                                    Succ _ -> False
                                    _      -> True

instance Num WeirdPeanoNumber where
  (+) Zero rhv = rhv
  (+) lhv Zero = lhv
  (+) (Succ lhv) rhv = Succ (lhv + rhv)
  (+) (Pred lhv) rhv = Pred (lhv + rhv)

  negate Zero = Zero
  negate (Succ num) = Pred (negate num)
  negate (Pred num) = Succ (negate num) 

  fromInteger x | x == 0 = Zero
                | x < 0 = Pred (fromInteger (x + 1))
                | otherwise = Succ (fromInteger (x - 1))

  signum Zero = Zero
  signum (Succ (Pred num)) = signum num
  signum (Pred (Succ num)) = signum num
  signum (Succ num) = Succ Zero
  signum (Pred num) = Pred Zero

  abs num = if (signum num < Zero) then negate num else num

  (*) Zero _ = Zero
  (*) _ Zero = Zero
  (*) (Succ lhv) rhv = rhv + (lhv * rhv)
  (*) (Pred lhv) rhv = if (signum lhv == signum rhv) then  (rhv + (lhv * rhv))
                       else if (signum lhv < Zero) then negate(rhv + ((negate lhv) * rhv))
                       else let nrhv = negate rhv in negate (nrhv + (lhv * nrhv))

instance Integral WeirdPeanoNumber where
  quotRem lhv rhv = let isNeg = (signum lhv) == (signum rhv) in
                    let div = simpleDIV (abs lhv) (abs rhv) in
                    if (isNeg) then (div, simplify $ lhv - div * rhv) else (negate div, simplify $ lhv - div * rhv)

  toInteger Zero = 0
  toInteger (Succ lhv) = (toInteger lhv) + 1
  toInteger (Pred lhv) = (toInteger lhv) - 1