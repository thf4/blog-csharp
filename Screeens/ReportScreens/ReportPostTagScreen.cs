using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
  public class ReportPostTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Listagem de post e tags relacionadas!");
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
        var repository = new PostRepository(Database.Connection);
        var posts = repository.GetWithTags();

        foreach (var post in posts)
        {
          Console.WriteLine(post.Title);
          foreach (var tag in post.Tags) Console.WriteLine($" - {tag.Slug}");
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