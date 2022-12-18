using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain;

public class WeChatPayTransferBillReceiptBodyModel : WeChatPayObject
{
    /// <summary>
    /// 商家批次单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部的商家批次单号，在商户系统内部唯一。需要电子回单的批次单号
    /// <para>示例值：plfk2020042013</para>
    /// </remarks>
    [JsonPropertyName("out_batch_no")]
    public string OutBatchNo { get; set; }
}
