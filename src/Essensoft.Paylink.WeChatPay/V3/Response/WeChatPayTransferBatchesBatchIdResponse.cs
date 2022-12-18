using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response;

public class WeChatPayTransferBatchesBatchIdResponse : WeChatPayResponse
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
}
