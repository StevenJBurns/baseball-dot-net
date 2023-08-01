using System;
using System.IO;
using System.Windows;

namespace Baseball;

public class AppBaseball : Application
{
  public AppBaseball()
  {
  }

  [STAThread]
  static void Main()
  {
    AppBaseball app = new AppBaseball();
    app.Run(new WindowMain());
  }
}
