 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.specs
{   
  [Subject(typeof(ConfigurationGateway))]
  public class ConfigurationGatewaySpecs
  {
    public abstract class concern : Observes<ILoadConfigurationInformation<OurType>,
                                      ConfigurationGateway>
    {
        
    }

    public class when_asked_for_a_configuration_item : concern
    {
      private It uses_mapping_gateway_to_provide_configuration_items = () =>
      {
        mapping_gateway.map<OurType,string>(new OurType());
      };
             

      private static IMapFromOneTypeToAnother mapping_gateway;
    }
  }

  public class ConfigurationGateway : ILoadConfigurationInformation<OurType>
  {
  }

  public class OurType
  {
  }
}
