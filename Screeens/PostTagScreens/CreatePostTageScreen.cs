using System;
using Blog.Repositories;
using Blog.Models;

namespace Blog.Screens.PostTagScreens
{
  public static class CreatePostTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Criação de Vinculo");
      Console.WriteLine("------------------");
      Console.WriteLine("Id do Post: ");
      var postId = short.Parse(Console.ReadLine());

      Console.WriteLine("Id da Tag: ");
      var tagId = short.Parse(Console.ReadLine());

      Create(new PostTag
      {
        PostId = postId,
        TagId = tagId
      });
      Console.ReadKey();
      MenuPostTagScreen.Load();
    }
    private static void Create(PostTag postTag)
    {
      try
      {
        var repository = new Repository<PostTag>(Database.Connection);
        repository.Create(postTag);
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