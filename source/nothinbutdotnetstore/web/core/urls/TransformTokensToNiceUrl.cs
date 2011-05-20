using System;
using System.Collections.Generic;
using System.Text;

namespace nothinbutdotnetstore.web.core.urls
{
  public class TransformTokensToNiceUrl : ITransformStoreTokensToANiceUrl
  {
    public List<string> strings = new List<string>();
    StringBuilder string_builder = new StringBuilder();

    public void visit(KeyValuePair<string, object> item)
    {
      strings.Add(item.Value.ToString());
    }

    public string get_result()
    {
      string_builder.Append(strings[0]);
      string_builder.Append(".denver/");

      return string_builder.ToString();
    }
  }
}