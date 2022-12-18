using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 微信明细单号查询明细单API - 最新更新时间：2022.04.24
/// </summary>
/// <remarks>
/// 商户可以通过该接口查询单笔转账明细单。
/// </remarks>
public class WeChatPayTransferBatchesBatchIdDetailsDetailIdRequest : IWeChatPayPrivacyGetRequest<WeChatPayTransferBatchesBatchIdDetailsDetailIdResponse>
{
    /// <summary>
    /// 微信批次单号
    /// </summary>
    /// <remarks>
    /// 微信批次单号，微信商家转账系统返回的唯一标识
    /// <para>示例值：1030000071100999991182020050700019480001</para>
    /// </remarks>
    [JsonPropertyName("batch_id")]
    public string BatchId { get; set; }

    /// <summary>
    /// 微信明细单号
    /// </summary>
    /// <remarks>
    /// 微信支付系统内部区分转账批次单下不同转账明细单的唯一标识
    /// <para>示例值：1040000071100999991182020050700019500100</para>
    /// </remarks>
    [JsonPropertyName("detail_id")]
    public string DetailId { get; set; }

    public string GetRequestUrl()
    {
        return $"https://api.mch.weixin.qq.com/v3/transfer/batches/batch-id/{BatchId}/details/detail-id/{DetailId}";
    }

    public WeChatPayObject GetQueryModel()
    {
        return null;
    }

    public void SetQueryModel(WeChatPayObject queryModel)
    {
    }
}
