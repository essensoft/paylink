using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request;

/// <summary>
/// 查询转账电子回单API - 最新更新时间：2021.10.26
/// </summary>
/// <remarks>
/// 查询转账电子回单接口，商户通过该接口可以查询电子回单受理进度信息，包括电子回单据信息，电子回单文件的hash值，电子回单文件的下载地址等
/// </remarks>
public class WeChatPayTransferBillReceiptOutBatchNoRequest : IWeChatPayGetRequest<WeChatPayTransferBillReceiptOutBatchNoResponse>
{
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
        return $"https://api.mch.weixin.qq.com/v3/transfer/bill-receipt/{OutBatchNo}";
    }

    public WeChatPayObject GetQueryModel()
    {
        return null;
    }

    public void SetQueryModel(WeChatPayObject queryModel)
    {
    }
}
