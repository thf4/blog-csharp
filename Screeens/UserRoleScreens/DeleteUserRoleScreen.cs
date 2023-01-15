using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.UserRoleScreens
{
  public static class DeleteUserRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir Vinculo");
      Console.WriteLine("------------------");
      Console.WriteLine("Id do vinculo: ");
      var id = short.Parse(Console.ReadLine());

      Delete(id);
      Console.ReadKey();
      MenuUserRoleScreen.Load();
    }
    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<UserRole>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Vinculando usuario e perfil feita com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel vincular usuario e perfil!");
        Console.WriteLine(e.Message);
      }

    }
  }
}