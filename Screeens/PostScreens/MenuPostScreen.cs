namespace Blog.Screens.PostScreens
{
  public static class MenuPostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de post");
      Console.WriteLine("-----------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar post");
      Console.WriteLine("2 - Cadastrar post");
      Console.WriteLine("3 - Atualizar post");
      Console.WriteLine("4 - Excluir post");
      Console.WriteLine("5 - Sair!");
      Console.WriteLine("6 - Voltar ao menu principal!");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          ListPostScreen.Load();
          break;
        case 2:
          CreatePostScreen.Load();
          break;
        case 3:
          UpdatePostScreen.Load();
          break;
        case 4:
          DeletePostScreen.Load();
          break;
        case 5:
          Environment.Exit(0);
          break;
        case 6:
          Program.Load();
          break;
        default: Load(); break;
      }
      Console.WriteLine();
    }
  }
}