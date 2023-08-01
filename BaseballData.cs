using System;
using System.Linq;
using System.Linq.Expressions;
using System.Xml;
using System.Xml.Linq;
using System.Data.Linq;
using System.Data;
using System.Collections.Generic;

namespace Baseball.Data;

public partial class BaseballData
{
  public BaseballData()
    {
    XDoc = XDocument.Load("BaseballData.xml");
    }

  public XDocument XDoc { get; set; }
  }
}
