namespace Blog.Screens.PostTagScreens
{
  public static class MenuPostTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Vinculos");
      Console.WriteLine("-----------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar vinculos");
      Console.WriteLine("2 - Cadastrar vinculo");
      Console.WriteLine("3 - Atualizar vinculo");
      Console.WriteLine("4 - Excluir vinculo");
      Console.WriteLine("5 - Sair!");
      Console.WriteLine("6 - Voltar ao menu principal!");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          ListPostTagScreen.Load();
          break;
        case 2:
          CreatePostTagScreen.Load();
          break;
        case 3:
          UpdatePostTagScreen.Load();
          break;
        case 4:
          DeletePostTagScreen.Load();
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