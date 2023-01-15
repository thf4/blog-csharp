using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.RoleScreens
{
  public static class ListRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de perfil");
      Console.WriteLine("------------------");
      List();
      Console.ReadKey();
      MenuRoleScreen.Load();
    }
    private static void List()
    {
      var repository = new Repository<Role>(Database.Connection);
      var roles = repository.Read();
      foreach (var item in roles)
        Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
    }
  }
}