using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 商家明细单号查询明细单API - 最新更新时间：2022.04.24
/// </summary>
/// <remarks>
/// 商户可以通过该接口查询单笔转账明细单。
/// </remarks>
public class WeChatPayTransferBatchesOutBatchNoDetailsOutDetailNoRequest : IWeChatPayPrivacyGetRequest<WeChatPayTransferBatchesOutBatchNoDetailsOutDetailNoResponse>
{
    /// <summary>
    /// 商家明细单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部区分转账批次单下不同转账明细单的唯一标识，要求此参数只能由数字、大小写字母组成
    /// <para>示例值：x23zy545Bd5436</para>
    /// </remarks>
    [JsonPropertyName("out_batch_no")]
    public string OutBatchNo { get; set; }

    /// <summary>
    /// 商家批次单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部的商家批次单号，要求此参数只能由数字、大小写字母组成，在商户系统内部唯一
    /// <para>示例值：plfk2020042013</para>
    /// </remarks>
    [JsonPropertyName("out_detail_no")]
    public string OutDetailNo { get; set; }

    public string GetRequestUrl()
    {
        return $"https://api.mch.weixin.qq.com/v3/transfer/batches/out-batch-no/{OutBatchNo}/details/out-detail-no/{OutDetailNo}";
    }

    public WeChatPayObject GetQueryModel()
    {
        return null;
    }

    public void SetQueryModel(WeChatPayObject queryModel)
    {
    }
}
