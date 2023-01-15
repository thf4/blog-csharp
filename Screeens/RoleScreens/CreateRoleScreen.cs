using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.RoleScreens
{
  public static class CreateRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Criação de tags");
      Console.WriteLine("------------------");
      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Create(new Role
      {
        Name = name,
        Slug = slug
      });
      Console.ReadKey();
      MenuRoleScreen.Load();
    }
    private static void Create(Role tag)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Create(tag);
        Console.WriteLine("Role criada com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel cadastrar a tag!");
        Console.WriteLine(e.Message);
      }

    }
  }
}