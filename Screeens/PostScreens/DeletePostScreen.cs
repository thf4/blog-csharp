using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostScreens
{
  public static class DeletePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir um post");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Delete(id);

      Console.ReadKey();
      MenuPostScreen.Load();
    }
    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Post excluido com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel excluir o post!");
        Console.WriteLine(e.Message);
      }
    }
  }
}