using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public class ListUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Listar todos usuarios");
      Console.WriteLine("-------------------");
      Console.WriteLine();
      Console.WriteLine();

      List();

      Console.ReadKey();
      MenuUserScreen.Load();
    }

    private static void List()
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        var users = repository.Read();
        foreach (var item in users)
          Console.WriteLine($"{item.Id} - {item.Name} - {item.Email} - {item.Bio} - {item.Slug}");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possivel listar os usuarios!");
        Console.WriteLine(ex);
      }
    }
  }
}