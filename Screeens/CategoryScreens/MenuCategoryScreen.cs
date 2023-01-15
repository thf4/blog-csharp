namespace Blog.Screens.CategoryScreens
{
  public static class MenuCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Categorias");
      Console.WriteLine("-----------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar categorias");
      Console.WriteLine("2 - Cadastrar categorias");
      Console.WriteLine("3 - Atualizar categorias");
      Console.WriteLine("4 - Excluir categorias");
      Console.WriteLine("5 - Sair!");
      Console.WriteLine("6 - Voltar ao menu principal!");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          ListCategoryScreen.Load();
          break;
        case 2:
          CreateCategoryScreen.Load();
          break;
        case 3:
          UpdateCategoryScreen.Load();
          break;
        case 4:
          DeleteCategoryScreen.Load();
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