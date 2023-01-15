using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.UserRoleScreens
{
  public static class CreateUserRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Criação de Vinculo");
      Console.WriteLine("------------------");
      Console.WriteLine("Id do Usuário: ");
      var userId = short.Parse(Console.ReadLine());

      Console.WriteLine("Id do Perfil: ");
      var roleId = short.Parse(Console.ReadLine());

      Create(new UserRole
      {
        UserId = userId,
        RoleId = roleId
      });
      Console.ReadKey();
      MenuUserRoleScreen.Load();
    }
    private static void Create(UserRole tag)
    {
      try
      {
        var repository = new Repository<UserRole>(Database.Connection);
        repository.Create(tag);
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