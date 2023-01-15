using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.TagScreens
{
  public static class CreateTagScreen
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

      Create(new Tag
      {
        Name = name,
        Slug = slug
      });
      Console.ReadKey();
      MenuTagScreen.Load();
    }
    private static void Create(Tag tag)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Create(tag);
        Console.WriteLine("Tag criada com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel cadastrar a tag!");
        Console.WriteLine(e.Message);
      }

    }
  }
}