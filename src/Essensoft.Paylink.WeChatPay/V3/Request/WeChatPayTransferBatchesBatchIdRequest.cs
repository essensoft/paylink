using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 微信批次单号查询批次单API - 最新更新时间：2022.4.6
/// </summary>
/// <remarks>
/// 商户可以通过该接口查询转账批次单以及指定状态的转账明细单。
/// </remarks>
public class WeChatPayTransferBatchesBatchIdRequest : IWeChatPayGetRequest<WeChatPayTransferBatchesBatchIdResponse>
{
    private WeChatPayObject _queryModel;

    /// <summary>
    /// 微信批次单号
    /// </summary>
    /// <remarks>
    /// 微信批次单号，微信商家转账系统返回的唯一标识
    /// <para>示例值：1030000071100999991182020050700019480001</para>
    /// </remarks>
    [JsonPropertyName("batch_id")]
    public string BatchId { get; set; }

    public string GetRequestUrl()
    {
        return $"https://api.mch.weixin.qq.com/v3/transfer/batches/batch-id/{BatchId}";
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
