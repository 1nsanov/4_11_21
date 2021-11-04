namespace Task1
{
    public class GeneralNotebook : Notebook
    {
        private string MaterialCover { get; set; }
        public GeneralNotebook(string materialCover, string name, int countLists) : base(name, countLists)
        {
            MaterialCover = materialCover;
        }

        public override int CostNotebook()
        {
            return base.CostNotebook() + 50;
        }

        public override string OutputToString()
        {
            return $"Обложка: {MaterialCover}| Имя: {Name} Л. {CountLists} Цена: {CostNotebook()} руб.";
        }

        public override string ToString()
        {
            return $"Обложка: {MaterialCover}| Имя: {Name} Л. {CountLists} Цена: {CostNotebook()} руб.";
        }
    }
}
