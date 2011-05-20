using System;
using System.Collections.Generic;
using System.Text;

namespace nothinbutdotnetstore.web.core.urls
{
  public class TransformTokensToNiceUrl : ITransformStoreTokensToANiceUrl
  {
    public StringBuilder string_builder = new StringBuilder();

    public void visit(KeyValuePair<string, object> item)
    {
      string_builder.Append(item.Value);
    }

    public string get_result()
    {
      throw new NotImplementedException();
    }
  }
}