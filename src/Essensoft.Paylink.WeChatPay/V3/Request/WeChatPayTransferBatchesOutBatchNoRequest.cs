using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 商家批次单号查询批次单API - 最新更新时间：2022.4.6
/// </summary>
/// <remarks>
/// 商户可以通过该接口查询转账批次单以及指定状态的转账明细单。
/// </remarks>
public class WeChatPayTransferBatchesOutBatchNoRequest : IWeChatPayGetRequest<WeChatPayTransferBatchesOutBatchNoResponse>
{
    private WeChatPayObject _queryModel;

    /// <summary>
    /// 商家批次单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部的商家批次单号，要求此参数只能由数字、大小写字母组成，在商户系统内部唯一
    /// <para>示例值：plfk2020042013</para>
    /// </remarks>
    [JsonPropertyName("out_batch_no")]
    public string OutBatchNo { get; set; }

    public string GetRequestUrl()
    {
        return $"https://api.mch.weixin.qq.com/v3/transfer/batches/out-batch-no/{OutBatchNo}";
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
