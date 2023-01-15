using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public class DeleteUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir um usuario");
      Console.WriteLine("-------------------");
      Console.WriteLine();
      Console.WriteLine("Id:  ");
      var id = short.Parse(Console.ReadLine());

      Delete(id);

      Console.ReadKey();
      MenuUserScreen.Load();
    }

    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Usuário deletado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possivel deletar o usuario!");
        Console.WriteLine(ex);
      }
    }
  }
}