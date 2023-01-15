using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.TagScreens
{
  public static class DeleteTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir uma tag");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Delete(id);

      Console.ReadKey();
      MenuTagScreen.Load();
    }
    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Tag excluida com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel excluir a tag!");
        Console.WriteLine(e.Message);
      }
    }
  }
}