data BinaryTree = Leaf | Branch Integer BinaryTree BinaryTree
                                   deriving (Show)

--Добавление элемента								   
insert :: BinaryTree -> Integer -> BinaryTree
insert Leaf a = Branch a Leaf Leaf
insert (Branch elem elemL elemR) a = if a > elem then Branch elem elemL (insert elemR a)
                                   else if a < elem then Branch elem (insert elemL a) elemR
                                   else Branch elem elemL elemR

--Удаление элемента
remove :: BinaryTree -> Integer -> BinaryTree
remove Leaf _ = Leaf
remove (Branch elem elemL elemR) a = if a > elem then Branch elem elemL (remove elemR a)
                                   else if a < elem then Branch elem (remove elemL a) elemR
                                   else if isLeaf elemR then elemL
                                   else Branch leftmost elemL elemR'
                                       where
                                         isLeaf Leaf = True
                                         isLeaf _    = False
                                         (leftmost, elemR') = deleteLeftmost elemR
                                         deleteLeftmost (Branch elem'' Leaf elemR'') = (elem'', elemR'')
                                         deleteLeftmost ~(Branch elem'' elemL'' elemR'') = (pair, Branch elem'' elemL' elemR'')
                                              where (pair, elemL') = deleteLeftmost elemL'

--Создание пустого элемента
emptyTree :: BinaryTree
emptyTree = Leaf

--Поиск элемента в дереве
containsElement :: BinaryTree -> Integer -> Bool
containsElement Leaf _ = False
containsElement (Branch elem elemL elemR) a = if a > elem then containsElement elemR a
                                            else if a < elem then containsElement elemL a
                                            else True

--Поиск в дереве наименьшего элемента, который больше или равен заданному											
nearestGE :: BinaryTree -> Integer -> Integer
nearestGE t a = get t 0
    where get Leaf p = p
          get (Branch elem elemL elemR) p = if a > elem then get elemR p
                                          else if a < elem then get elemL elem
                                          else a

--Создание дерева из списка
treeFromList :: [Integer] -> BinaryTree
treeFromList = foldr (flip insert) Leaf

--Создание списка из дерева
listFromTree :: BinaryTree -> [Integer]
listFromTree tree = toList' tree []
    where
      toList' Leaf list = list
      toList' (Branch elem elemL elemR) list = toList' elemL (elem: toList' elemR list)
