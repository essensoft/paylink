using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 发起商家转账API - 最新更新时间：2022.04.24
/// </summary>
/// <remarks>
/// 商户可以通过该接口同时向多个用户微信零钱进行转账操作。
/// </remarks>
public class WeChatPayTransferBatchesRequest : IWeChatPayPrivacyPostRequest<WeChatPayTransferBatchesResponse>
{
    private WeChatPayObject _bodyModel;

    public string GetRequestUrl()
    {
        return "https://api.mch.weixin.qq.com/v3/transfer/batches";
    }

    public WeChatPayObject GetBodyModel()
    {
        return _bodyModel;
    }

    public void SetBodyModel(WeChatPayObject bodyModel)
    {
        _bodyModel = bodyModel;
    }
}
