using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain;

/// <summary>
/// 发起商家转账
/// </summary>
public class WeChatPayTransferBatchesBodyModel : WeChatPayObject
{
    /// <summary>
    /// 直连商户的appid
    /// </summary>
    /// <remarks>
    /// 申请商户号的appid或商户号绑定的appid（企业号corpid即为此appid）
    /// <para>示例值：wxf636efh567hg4356</para>
    /// </remarks>
    [JsonPropertyName("appid")]
    public string AppId { get; set; }

    /// <summary>
    /// 商家批次单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部的商家批次单号，要求此参数只能由数字、大小写字母组成，在商户系统内部唯一
    /// <para>示例值：plfk2020042013</para>
    /// </remarks>
    [JsonPropertyName("out_batch_no")]
    public string OutBatchNo { get; set; }

    /// <summary>
    /// 批次名称
    /// </summary>
    /// <remarks>
    /// 该笔批量转账的名称
    /// <para>示例值：2019年1月深圳分部报销单</para>
    /// </remarks>
    [JsonPropertyName("batch_name")]
    public string BatchName { get; set; }

    /// <summary>
    /// 批次备注
    /// </summary>
    /// <remarks>
    /// 转账说明，UTF8编码，最多允许32个字符
    /// <para>示例值：2019年1月深圳分部报销单</para>
    /// </remarks>
    [JsonPropertyName("batch_remark")]
    public string BatchRemark { get; set; }

    /// <summary>
    /// 转账总金额
    /// </summary>
    /// <remarks>
    /// 转账金额单位为“分”。转账总金额必须与批次内所有明细转账金额之和保持一致，否则无法发起转账操作
    /// <para>示例值：4000000</para>
    /// </remarks>
    [JsonPropertyName("total_amount")]
    public int TotalAmount { get; set; }

    /// <summary>
    /// 转账总笔数
    /// </summary>
    /// <remarks>
    /// 一个转账批次单最多发起一千笔转账。转账总笔数必须与批次内所有明细之和保持一致，否则无法发起转账操作
    /// <para>示例值：200</para>
    /// </remarks>
    [JsonPropertyName("total_num")]
    public int TotalNum { get; set; }

    /// <summary>
    /// 转账明细列表
    /// </summary>
    /// <remarks>
    /// 发起批量转账的明细列表，最多一千笔
    /// </remarks>
    [JsonPropertyName("transfer_detail_list")]
    public List<TransferDetail> TransferDetailList { get; set; }


    /// <summary>
    /// 转账场景ID
    /// </summary>
    /// <remarks>
    /// 该批次转账使用的转账场景，如不填写则使用商家的默认场景，如无默认场景可为空，可前往“商家转账到零钱-前往功能”中申请。
    /// 如：1001-现金营销
    /// </remarks>
    [JsonPropertyName("transfer_scene_id")]
    public string TransferSceneId { get; set; }
}
