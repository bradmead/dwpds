using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using developwithpassion;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.web.core.urls;

namespace nothinbutdotnetstore.specs
{

  [Subject(typeof(TransformTokensToNiceUrl))]
  public class TransformTokenToNiceUrlSpecs
  {
    public abstract class concern : Observes<ITransformStoreTokensToANiceUrl,
                                      TransformTokensToNiceUrl>
    {

    }

    public class when_visiting_a_key_value_pair : concern
    {
      private const string url = "myurl";

      private Establish c = () =>
      {
        url_token = new KeyValuePair<string, object>("blah", url);
      };

      private Because b = () =>
        sut.visit(url_token);

      private It should_add_the_value_to_its_state = () =>
        sut.downcast_to<TransformTokensToNiceUrl>().strings.ShouldContain(url);

      private static KeyValuePair<string, object> url_token;
      private static string result;
    }

    public class when_getting_the_completed_url : concern
    {
      private const string url = "myurl";

      private Establish c = () =>
      {
        sut_setup.run(x => x.strings.Add("myurl"));
      };
      
      private Because b = () =>
      {
        result = sut.get_result();
      };


      private It should_contain_the_ = () =>
        result.ShouldEqual(url);

      private static KeyValuePair<string, object> url_token;
      private static string result;
    }
  }
}
