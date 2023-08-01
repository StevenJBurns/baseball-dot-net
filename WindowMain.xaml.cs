using System;
using System.IO;
using System.Windows;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using Baseball.Data;

namespace Baseball;

public partial class WindowMain : Window
{
  BaseballData data;

  public WindowMain()
  {
    InitializeComponent();

    data = new BaseballData();

    var Teams = from t in data.XDoc.Descendants("Team")
      orderby t.Attribute("city").Value
      select t.Attribute("city").Value;

    lbxTeams.ItemsSource = Teams;
    // lbxTeams.DisplayMemberPath = "city";
  }
}
