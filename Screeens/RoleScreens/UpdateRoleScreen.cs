using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.RoleScreens
{
  public static class UpdateRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizando perfil");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Update(new Role
      {
        Id = id,
        Name = name,
        Slug = slug
      });

      Console.ReadKey();
      MenuRoleScreen.Load();
    }
    private static void Update(Role role)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Update(role);
        Console.WriteLine("Perfil atualizada com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel atualizar o perfil!");
        Console.WriteLine(e.Message);
      }

    }
  }
}