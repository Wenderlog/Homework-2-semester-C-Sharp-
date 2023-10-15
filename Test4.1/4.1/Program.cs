class Programm
{
    static void Main(string[] args)
    {
        try
        {
            string filePath = "input.txt";

            ExpressionTree expressionTree = new ExpressionTree(filePath);

            Console.WriteLine("Дерево разбора: ");
            expressionTree.PrintTree();

            double result = expressionTree.Evaluate();
            Console.WriteLine("Результат вычисления " + result);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка " + ex.Message);
        }
    }
}