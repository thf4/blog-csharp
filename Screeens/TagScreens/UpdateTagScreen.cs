using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.TagScreens
{
  public static class UpdateTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizando tag");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Update(new Tag
      {
        Id = id,
        Name = name,
        Slug = slug
      });

      Console.ReadKey();
      MenuTagScreen.Load();
    }
    private static void Update(Tag tag)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Update(tag);
        Console.WriteLine("Tag atualizada com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel atualizar a tag!");
        Console.WriteLine(e.Message);
      }

    }
  }
}