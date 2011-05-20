using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using developwithpassion;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.web.core.urls;

namespace nothinbutdotnetstore.specs
{
  public class TransformTokenToNiceUrlSpecs
  {
    public abstract class concern : Observes<ITransformStoreTokensToANiceUrl,
                                      TransformTokensToNiceUrl>
    {

    }

    [Subject(typeof(TransformTokensToNiceUrl))]
    public class when_visiting_a_token_store : concern
    {
      private const string url = "myurl";

      private Establish c = () =>
      {
        url_token = new KeyValuePair<string, object>("blah", url);
      };

      private Because b = () =>
        sut.visit(url_token);

      private It should_contain_the_url_constituent_parts = () =>
        sut.downcast_to<TransformTokensToNiceUrl>().string_builder.ToString().ShouldContain(url);

      private static KeyValuePair<string, object> url_token;
      private static string result;
    }
  }
}
