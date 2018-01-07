newtype PSet a = PSet{ contains :: (a -> Bool) }
newtype PSet' a = PSet'{ contains2 :: (a -> Bool) }

--Cложение множеств
instance Monoid (PSet a) where
  mempty = PSet (\a -> False)
  mappend (PSet f1) (PSet f2) = PSet (\a -> (f1 a) || (f2 a))

--Пересечение множеств
instance Monoid (PSet' a) where
  mempty = PSet' (\a -> True)
  mappend (PSet' f1) (PSet' f2) = PSet' (\a -> (f1 a) && (f2 a))

--Функтор всегда возвращает False
instance Functor PSet where
  fmap f (PSet fa) = PSet (\b -> False)
