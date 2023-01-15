using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostScreens
{
  public static class UpdatePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizando post");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Console.WriteLine("Title: ");
      var title = Console.ReadLine();

      Console.WriteLine("Summary: ");
      var summary = Console.ReadLine();

      Console.WriteLine("Body: ");
      var body = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Update(new Post
      {
        Id = id,
        Title = title,
        Summary = summary,
        Body = body,
        Slug = slug
      });

      Console.ReadKey();
      MenuPostScreen.Load();
    }
    private static void Update(Post role)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Update(role);
        Console.WriteLine("Post atualizada com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel atualizar o post!");
        Console.WriteLine(e.Message);
      }

    }
  }
}