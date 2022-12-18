using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain;

public class QueryTransferDetail : WeChatPayObject
{
    /// <summary>
    /// 微信明细单号
    /// </summary>
    /// <remarks>
    /// 微信支付系统内部区分转账批次单下不同转账明细单的唯一标识
    /// <para>示例值：1040000071100999991182020050700019500100</para>
    /// </remarks>
    [JsonPropertyName("detail_id")]
    public string DetailId { get; set; }

    /// <summary>
    /// 商家明细单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部区分转账批次单下不同转账明细单的唯一标识
    /// <para>示例值：x23zy545Bd5436</para>
    /// </remarks>
    [JsonPropertyName("out_detail_no")]
    public string OutDetailNo { get; set; }

    /// <summary>
    /// 明细状态
    /// </summary>
    /// <remarks>
    /// 枚举值：
    /// PROCESSING：转账中。正在处理中，转账结果尚未明确
    /// SUCCESS：转账成功
    /// FAIL：转账失败。需要确认失败原因后，再决定是否重新发起对该笔明细单的转账（并非整个转账批次单）
    /// <para>示例值：SUCCESS</para>
    /// </remarks>
    [JsonPropertyName("detail_status")]
    public string DetailStatus { get; set; }
}
