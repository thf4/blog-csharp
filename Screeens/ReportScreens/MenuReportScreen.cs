namespace Blog.Screens.ReportScreens
{
  public static class MenuReportScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Relatorios");
      Console.WriteLine("-----------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Relatorio post e tag");
      Console.WriteLine("2 - Relatorio user e perfil");
      Console.WriteLine("3 - Sair!");
      Console.WriteLine("4 - Voltar ao menu principal!");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          ReportPostTagScreen.Load();
          break;
        case 2:
          ReportUserRoleScreen.Load();
          break;
        case 3:
          Environment.Exit(0);
          break;
        case 4:
          Program.Load();
          break;
        default: Load(); break;
      }
      Console.WriteLine();
    }
  }
}