using Gateway.WebApi.Sync_ebIX_CombinerCode_Service;

namespace Gateway.WebApi.SoapEndpoints;

public class CombinerCodeEndpoint : ebIX_CombinerCode_PortType
{
    public Task CreateAsync(Create_input request)
    {
        throw new NotImplementedException();
    }

    public Task NotifyAsync(Notify_input request)
    {
        throw new NotImplementedException();
    }

    public Task RejectAsync(Reject_input request)
    {
        throw new NotImplementedException();
    }
}