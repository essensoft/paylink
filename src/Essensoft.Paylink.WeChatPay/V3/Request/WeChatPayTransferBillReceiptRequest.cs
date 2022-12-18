using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 转账电子回单申请受理API - 最新更新时间：2021.10.26
/// </summary>
/// <remarks>
/// 转账电子回单申请受理接口，商户通过该接口可以申请受理电子回单服务。
/// </remarks>
public class WeChatPayTransferBillReceiptRequest : IWeChatPayPostRequest<WeChatPayTransferBillReceiptResponse>
{
    private WeChatPayObject _bodyModel;

    public string GetRequestUrl()
    {
        return "https://api.mch.weixin.qq.com/v3/transfer/bill-receipt";
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
