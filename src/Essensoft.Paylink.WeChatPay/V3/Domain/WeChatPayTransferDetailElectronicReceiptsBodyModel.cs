using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain;

public class WeChatPayTransferDetailElectronicReceiptsBodyModel : WeChatPayObject
{
    /// <summary>
    /// 受理类型
    /// </summary>
    /// <remarks>
    /// 电子回单受理类型：
    /// BATCH_TRANSFER：批量转账明细电子回单
    /// TRANSFER_TO_POCKET：企业付款至零钱电子回单
    /// TRANSFER_TO_BANK：企业付款至银行卡电子回单
    /// <para>示例值：BATCH_TRANSFER</para>
    /// </remarks>
    [JsonPropertyName("accept_type")]
    public string AcceptType { get; set; }

    /// <summary>
    /// 商家转账批次单号
    /// </summary>
    /// <remarks>
    /// 需要电子回单的批量转账明细单所在的转账批次单号，该单号为商户申请转账时生成的商户单号。受理类型为BATCH_TRANSFER时该单号必填，否则该单号留空。
    /// <para>示例值：GD2021011610162610BBdkkIwcu3</para>
    /// </remarks>
    [JsonPropertyName("out_batch_no")]
    public string OutBatchNo { get; set; }

    /// <summary>
    /// 商家转账明细单号
    /// </summary>
    /// <remarks>
    /// 该单号为商户申请转账时生成的商家转账明细单号。
    /// 1.受理类型为BATCH_TRANSFER时填写商家批量转账明细单号。
    /// 2.受理类型为TRANSFER_TO_POCKET或TRANSFER_TO_BANK时填写商家转账单号。
    /// <para>示例值：mx0911231610162610v4CNkO4HAf</para>
    /// </remarks>
    [JsonPropertyName("out_detail_no")]
    public string OutDetailNo { get; set; }
}
