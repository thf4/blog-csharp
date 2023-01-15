using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.RoleScreens
{
  public static class DeleteRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir um perfil");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Delete(id);

      Console.ReadKey();
      MenuRoleScreen.Load();
    }
    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Perfil excluido com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel excluir o perfil!");
        Console.WriteLine(e.Message);
      }
    }
  }
}