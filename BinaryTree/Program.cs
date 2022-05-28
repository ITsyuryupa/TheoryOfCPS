using BinaryTreeN;

BinaryTree t = new BinaryTree(10, 2);

t.Add(1);
t.Add(1);
t.Add(6);
t.Add(4);
t.Add(8);
t.Add(3);
t.Add(5);
t.Add(7);
t.Add(9);
t.Del(6);

for (int i = 0; i < t.tree.GetLength(0); i++)
{
    for (int j = 0; j < t.tree.GetLength(1); j++)
    {
        Console.Write(t.tree[i, j] == 0 ? " " : t.tree[i, j]);
    }
    Console.WriteLine();
}