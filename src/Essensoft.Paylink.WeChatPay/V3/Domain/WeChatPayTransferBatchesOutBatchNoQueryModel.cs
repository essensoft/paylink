using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain;

public class WeChatPayTransferBatchesOutBatchNoQueryModel : WeChatPayObject
{
    /// <summary>
    /// 是否查询转账明细单
    /// </summary>
    /// <remarks>
    /// 枚举值：
    /// true：是；
    /// false：否，默认否。
    /// 商户可选择是否查询指定状态的转账明细单，当转账批次单状态为“FINISHED”（已完成）时，才会返回满足条件的转账明细单
    /// <para>示例值：true</para>
    /// </remarks>
    [JsonPropertyName("need_query_detail")]
    public bool NeedQueryDetail { get; set; }

    /// <summary>
    /// 请求资源起始位置
    /// </summary>
    /// <remarks>
    /// 该次请求资源的起始位置，从0开始，默认值为0
    /// <para>示例值：1</para>
    /// </remarks>
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// 最大资源条数
    /// </summary>
    /// <remarks>
    /// 该次请求可返回的最大明细条数，最小20条，最大100条，不传则默认20条。不足20条按实际条数返回
    /// <para>示例值：20</para>
    /// </remarks>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// 明细状态
    /// </summary>
    /// <remarks>
    /// 查询指定状态的转账明细单，当need_query_detail为true时，该字段必填
    /// ALL:全部。需要同时查询转账成功和转账失败的明细单
    /// SUCCESS:转账成功。只查询转账成功的明细单
    /// FAIL:转账失败。只查询转账失败的明细单
    /// <para>示例值：FAIL</para>
    /// </remarks>
    [JsonPropertyName("detail_status")]
    public string DetailStatus { get; set; }
}
