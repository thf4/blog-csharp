using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.UserRoleScreens
{
  public static class UpdateUserRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualização de vinculo");
      Console.WriteLine("------------------");
      Console.WriteLine("Id do vinculo: ");
      var id = short.Parse(Console.ReadLine());

      Console.WriteLine("Id do Usuário: ");
      var userId = short.Parse(Console.ReadLine());

      Console.WriteLine("Id do Perfil: ");
      var roleId = short.Parse(Console.ReadLine());

      Update(new UserRole
      {
        Id = id,
        UserId = userId,
        RoleId = roleId
      });
      Console.ReadKey();
      MenuUserRoleScreen.Load();
    }
    private static void Update(UserRole tag)
    {
      try
      {
        var repository = new Repository<UserRole>(Database.Connection);
        repository.Update(tag);
        Console.WriteLine("Atualizando vinculo usuario e perfil feita com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel atualizar vinculo do usuario e perfil!");
        Console.WriteLine(e.Message);
      }

    }
  }
}