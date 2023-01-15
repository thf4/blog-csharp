using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostTagScreens
{
  public static class DeletePostTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir Vinculo");
      Console.WriteLine("------------------");
      Console.WriteLine("Id do vinculo: ");
      var id = short.Parse(Console.ReadLine());

      Delete(id);
      Console.ReadKey();
      MenuPostTagScreen.Load();
    }
    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<PostTag>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Vinculando post e tag feita com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel vincular post e tag!");
        Console.WriteLine(e.Message);
      }

    }
  }
}