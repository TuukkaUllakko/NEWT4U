namespace Animals
{
    public interface ITame
    {
        string Name { get; set; }
        string ComeHere();
        void GiveName(string newName);
    }
}