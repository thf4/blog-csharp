using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.CategoryScreens
{
  public static class UpdateCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizando categoria");
      Console.WriteLine("------------------");
      Console.WriteLine("Id: ");
      var id = short.Parse(Console.ReadLine());

      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Update(new Category
      {
        Id = id,
        Name = name,
        Slug = slug
      });

      Console.ReadKey();
      MenuCategoryScreen.Load();
    }
    private static void Update(Category categorie)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Update(categorie);
        Console.WriteLine("Categoria atualizada com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel atualizar a categoria!");
        Console.WriteLine(e.Message);
      }

    }
  }
}