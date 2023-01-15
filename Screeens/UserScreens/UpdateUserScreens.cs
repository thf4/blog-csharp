using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public class UpdateUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualização de usuario");
      Console.WriteLine("-------------------");
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine("Id:  ");
      var id = short.Parse(Console.ReadLine());

      Console.WriteLine("Nome:  ");
      var name = Console.ReadLine();

      Console.WriteLine("Email: ");
      var email = Console.ReadLine();

      Console.WriteLine("Password: ");
      var passwordHash = Console.ReadLine();

      Console.WriteLine("Bio: ");
      var bio = Console.ReadLine();

      Console.WriteLine("Foto usuario: ");
      var image = Console.ReadLine();

      Console.WriteLine("Slug: ");
      var slug = Console.ReadLine();

      Update(new User
      {
        Id = id,
        Name = name,
        Email = email,
        PasswordHash = passwordHash,
        Bio = bio,
        Image = image,
        Slug = slug
      });

      Console.ReadKey();
      MenuUserScreen.Load();
    }

    private static void Update(User user)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        repository.Update(user);
        Console.WriteLine("Usuário criado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possivel criar um novo usuario!");
        Console.WriteLine(ex);
      }
    }
  }
}