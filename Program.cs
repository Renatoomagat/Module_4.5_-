namespace Module_4._5_Итоги
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] FavColors, double Age)User;

            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у Вас животные? Да или Нет");
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }
                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите три любимых цвета пользователя");
                User.FavColors = new string[3];
                for (int i = 0; i < User.FavColors.Length; i++)
                {
                    User.FavColors[i] = Console.ReadLine();
                }
            }
        }
    }
}