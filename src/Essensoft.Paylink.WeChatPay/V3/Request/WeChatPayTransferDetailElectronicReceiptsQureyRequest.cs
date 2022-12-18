using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 查询转账明细电子回单受理结果API - 最新更新时间：2021.10.26
/// </summary>
/// <remarks>
/// 查询转账明细电子回单受理结果接口，商户通过该接口可以查询电子回单受理进度信息，包括电子回单据信息，电子回单文件的hash值，电子回单文件的下载地址等。
/// </remarks>
public class WeChatPayTransferDetailElectronicReceiptsQureyRequest : IWeChatPayGetRequest<WeChatPayTransferDetailElectronicReceiptsQureyResponse>
{
    private WeChatPayObject _queryModel;

    public string GetRequestUrl()
    {
        return "https://api.mch.weixin.qq.com/v3/transfer-detail/electronic-receipts";
    }

    public WeChatPayObject GetQueryModel()
    {
        return _queryModel;
    }

    public void SetQueryModel(WeChatPayObject queryModel)
    {
        _queryModel = queryModel;
    }
}
