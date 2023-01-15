using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostTagScreens
{
  public static class UpdatePostTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualização de vinculo");
      Console.WriteLine("------------------");
      Console.WriteLine("Id do vinculo: ");
      var id = short.Parse(Console.ReadLine());

      Console.WriteLine("Id do Post: ");
      var postId = short.Parse(Console.ReadLine());

      Console.WriteLine("Id da Tag: ");
      var tagId = short.Parse(Console.ReadLine());

      Update(new PostTag
      {
        Id = id,
        PostId = postId,
        TagId = tagId
      });
      Console.ReadKey();
      MenuPostTagScreen.Load();
    }
    private static void Update(PostTag postTag)
    {
      try
      {
        var repository = new Repository<PostTag>(Database.Connection);
        repository.Update(postTag);
        Console.WriteLine("Atualizando vinculo post e tag feita com sucesso!");
      }
      catch (System.Exception e)
      {
        Console.WriteLine("Não foi possivel atualizar vinculo do post e tag!");
        Console.WriteLine(e.Message);
      }

    }
  }
}