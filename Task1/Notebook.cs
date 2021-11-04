namespace Task1
{
    public class Notebook
    {
        protected string Name { get; set; }
        protected int CountLists { get; set; }

        public Notebook(string name, int countLists)
        {
            Name = name;
            CountLists = countLists;
        }

        public virtual int CostNotebook()
        {
            return 15 * CountLists;
        }

        public virtual string OutputToString()
        {
            return $"Имя: {Name}  Л. {CountLists} Цена: {CostNotebook()} руб.";
        }

        public override string ToString()
        {
            return $"Имя: {Name}  Л. {CountLists} Цена: {CostNotebook()} руб.";
        }
    }
}
