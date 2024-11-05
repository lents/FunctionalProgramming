namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        string GetTowerDamageReport(IEnumerable<Tower> towers)
        {
            int totalDamage = 0;
            foreach (Tower tower in towers)
            {
                if (tower.IsActive)
                {
                    totalDamage += tower.Damage;
                }
            }
            return $"Active towers deal {totalDamage} total damage";

        }
    }
