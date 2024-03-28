record Product(string Name, string Category, decimal Price)
{
    public override string ToString()
    {
        return $"{Name} - {Category} - ${Price}";
    }
}
