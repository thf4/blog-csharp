using Blog.Screens.CategoryScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Blog.Screens.UserRoleScreens;
using Microsoft.Data.SqlClient;
using Blog.Screens.PostTagScreens;
using Blog.Screens.ReportScreens;

namespace Blog
{
  public class Program
  {
    private const string CONNECTION_TRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

    static void Main(string[] args)
    {
      Database.Connection = new SqlConnection(CONNECTION_TRING);
      Database.Connection.Open();

      Load();

      Database.Connection.Close();
    }

    public static void Load()
    {
      Console.WriteLine("Bem vindo ao blog!");
      Console.WriteLine("------------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Gestão de usuários");
      Console.WriteLine("2 - Gestão de perfil");
      Console.WriteLine("3 - Gestão de categorias");
      Console.WriteLine("4 - Gestão de tag");
      Console.WriteLine("5 - Gestão de post");
      Console.WriteLine("6 - Vincular perfil/usuario");
      Console.WriteLine("7 - Vincular post/tag");
      Console.WriteLine("8 - Relatorios");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          MenuUserScreen.Load();
          break;
        case 2:
          MenuRoleScreen.Load();
          break;
        case 3:
          MenuCategoryScreen.Load();
          break;
        case 4:
          MenuTagScreen.Load();
          break;
        case 5:
          MenuPostScreen.Load();
          break;
        case 6:
          MenuUserRoleScreen.Load();
          break;
        case 7:
          MenuPostTagScreen.Load();
          break;
        case 8:
          MenuReportScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}