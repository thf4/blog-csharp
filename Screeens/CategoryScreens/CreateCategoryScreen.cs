using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.CategoryScreens
{
  public static class CreateCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Criação de categoria");
      Console.WriteLine("------------------");
      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Create(new Category
      {
        Name = name,
        Slug = slug
      });
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }
    private static void Create(Category categorie)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Create(categorie);
        Console.WriteLine("Categoria criada com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel cadastrar a categoria!");
        Console.WriteLine(e.Message);
      }

    }
  }
}