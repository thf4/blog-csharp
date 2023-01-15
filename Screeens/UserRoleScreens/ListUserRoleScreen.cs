using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.UserRoleScreens
{
  public static class ListUserRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de vinculo perfil e usuario");
      Console.WriteLine("------------------");
      List();
      Console.ReadKey();
      MenuUserRoleScreen.Load();
    }
    private static void List()
    {
      try
      {
        var repository = new Repository<UserRole>(Database.Connection);
        var userRoles = repository.Read();
        foreach (var item in userRoles)
        {
          Console.WriteLine($"{item.UserId} - {item.RoleId}");
        }
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel listar vinculo usuario e perfil!");
        Console.WriteLine(e.Message);
      }

    }
  }
}