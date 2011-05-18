using System;
using System.Web;

namespace nothinbutdotnetstore.web.core
{
  public class RawHandler : IHttpHandler
  {
    private readonly IProcessIncomingRequests _processIncomingRequests;
    private readonly ICreateRequests _createRequests;

    public RawHandler(IProcessIncomingRequests processIncomingRequests, ICreateRequests createRequests)
    {
      _processIncomingRequests = processIncomingRequests;
      _createRequests = createRequests;
    }

    public void ProcessRequest(HttpContext context)
    {
      object requestFrom = _createRequests.create_request_from(context);
      _processIncomingRequests.process(requestFrom);
    }

    public bool IsReusable
    {
      get { return true; }
    }
  }
}