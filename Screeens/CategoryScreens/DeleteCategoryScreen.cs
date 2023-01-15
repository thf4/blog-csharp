using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.CategoryScreens
{
  public static class DeleteCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir uma categoria");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Delete(id);

      Console.ReadKey();
      MenuCategoryScreen.Load();
    }
    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Categoria excluida com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel excluir a categoria!");
        Console.WriteLine(e.Message);
      }
    }
  }
}