using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostTagScreens
{
  public static class ListPostTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de vinculo post e tag");
      Console.WriteLine("------------------");
      List();
      Console.ReadKey();
      MenuPostTagScreen.Load();
    }
    private static void List()
    {
      try
      {
        var repository = new Repository<PostTag>(Database.Connection);
        var postTags = repository.Read();
        foreach (var item in postTags)
        {
          Console.WriteLine($"{item.PostId} - {item.TagId}");
        }
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel listar vinculo post e tag!");
        Console.WriteLine(e.Message);
      }

    }
  }
}