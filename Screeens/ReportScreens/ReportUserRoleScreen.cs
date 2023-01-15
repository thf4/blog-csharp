using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
  public class ReportUserRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Listagem de user e roles relacionadas!");
      Console.WriteLine("-----------------");
      Console.WriteLine();
      Console.WriteLine();

      List();

      Console.ReadKey();
      MenuReportScreen.Load();
    }

    private static void List()
    {
      try
      {
        var repository = new UserRepository(Database.Connection);
        var users = repository.GetWithRoles();

        foreach (var user in users)
        {
          Console.WriteLine(user.Email);
          foreach (var role in user.Roles) Console.WriteLine($" - {role.Slug}");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Problema ao gerar relatorios!");
        Console.WriteLine(ex.Message);
      }

    }
  }
}