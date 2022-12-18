using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 转账明细电子回单受理API - 最新更新时间：2021.10.26
/// </summary>
/// <remarks>
/// 受理转账明细电子回单接口，商户通过该接口可以申请受理转账明细单电子回单服务。
/// </remarks>
public class WeChatPayTransferDetailElectronicReceiptsRequest : IWeChatPayPostRequest<WeChatPayTransferDetailElectronicReceiptsResponse>
{
    private WeChatPayObject _bodyModel;

    public string GetRequestUrl()
    {
        return "https://api.mch.weixin.qq.com/v3/transfer-detail/electronic-receipts";
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
