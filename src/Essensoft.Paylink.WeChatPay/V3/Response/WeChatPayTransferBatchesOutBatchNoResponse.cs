using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response;

public class WeChatPayTransferBatchesOutBatchNoResponse : WeChatPayResponse
{
    /// <summary>
    /// 转账批次单
    /// </summary>
    /// <remarks>
    /// 转账批次单基本信息
    /// </remarks>
    [JsonPropertyName("transfer_batch")]
    public TransferBatch TransferBatch { get; set; }

    /// <summary>
    /// 转账明细单列表
    /// </summary>
    /// <remarks>
    /// 当批次状态为“FINISHED”（已完成），且成功查询到转账明细单时返回。包括微信明细单号、明细状态信息
    /// </remarks>
    [JsonPropertyName("transfer_detail_list")]
    public List<QueryTransferDetail> TransferDetailList { get; set; }

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
}
