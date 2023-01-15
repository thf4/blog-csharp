using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostScreens
{
  public static class ListPostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de posts");
      Console.WriteLine("------------------");
      List();
      Console.ReadKey();
      MenuPostScreen.Load();
    }
    private static void List()
    {
      var repository = new Repository<Post>(Database.Connection);
      var roles = repository.Read();
      foreach (var item in roles)
        Console.WriteLine($"{item.Id} - {item.Title} - {item.Summary} - {item.Body} - {item.Slug}");
    }
  }
}