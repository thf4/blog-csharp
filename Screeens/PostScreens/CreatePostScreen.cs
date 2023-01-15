using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostScreens
{
  public static class CreatePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Criação de tags");
      Console.WriteLine("------------------");
      Console.WriteLine("Titulo: ");
      var title = Console.ReadLine();

      Console.WriteLine("Descrição: ");
      var summary = Console.ReadLine();

      Console.WriteLine("Texto: ");
      var body = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Console.WriteLine("Id do Autor: ");
      var authorId = short.Parse(Console.ReadLine());

      Console.WriteLine("Categoria Id: ");
      var categorieId = short.Parse(Console.ReadLine());

      Create(new Post
      {
        Title = title,
        Summary = summary,
        Body = body,
        Slug = slug,
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now,
        AuthorId = authorId,
        CategoryId = categorieId,
      });
      Console.ReadKey();
      MenuPostScreen.Load();
    }
    private static void Create(Post role)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Create(role);
        Console.WriteLine("Post criado com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel cadastrar um post!");
        Console.WriteLine(e.Message);
      }

    }
  }
}