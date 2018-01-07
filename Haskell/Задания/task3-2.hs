data ReverseList a = RNil 
                   | RCons (ReverseList a) a

showAsList :: (Show a) => ReverseList a -> String
showAsList RNil = ""
showAsList (RCons RNil h) = show h
showAsList (RCons tl hl) = (showAsList tl) ++ ", " ++ (show hl)

toList :: ReverseList a -> [a]
toList RNil = []
toList (RCons tl hl) = hl:(toList tl)

fromList :: [a] -> ReverseList a
fromList [] = RNil
fromList (h:t) = RCons (fromList t) h

instance (Show a) => Show (ReverseList a) where
  show RNil = "[]"
  show list = "[" ++ (showAsList list) ++ "]"

instance (Eq a) => Eq (ReverseList a) where
  (==) RNil RNil = True
  (==) RNil _ = False
  (==) _ RNil = False
  (==) (RCons tl hl) (RCons tr hr) = hl == hr && tl == tr

instance (Ord a) => Ord (ReverseList a) where
  (<=) RNil RNil = True
  (<=) RNil _ = True
  (<=) _ RNil = False
  (<=) (RCons tl hl) (RCons tr hr) = if (hl <= hr) then True
                                      else tl <= tr

instance Functor ReverseList where
  fmap f RNil = RNil
  fmap f (RCons tl hl) = RCons (fmap f tl) (f hl)

instance Monoid (ReverseList a) where
  mempty = RNil
  mappend RNil list = list
  mappend list RNil = list
  mappend list (RCons tl hl) = RCons (mappend list tl) hl