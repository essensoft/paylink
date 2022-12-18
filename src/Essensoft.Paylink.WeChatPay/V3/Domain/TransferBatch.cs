using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain;

public class TransferBatch : WeChatPayObject
{
    /// <summary>
    /// 商户号
    /// </summary>
    /// <remarks>
    /// 微信支付分配的商户号
    /// <para>示例值：1900001109</para>
    /// </remarks>
    [JsonPropertyName("mchid")]
    public string MchId { get; set; }

    /// <summary>
    /// 商家批次单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部的商家批次单号，在商户系统内部唯一
    /// <para>示例值：plfk2020042013</para>
    /// </remarks>
    [JsonPropertyName("out_batch_no")]
    public string OutBatchNo { get; set; }

    /// <summary>
    /// 微信批次单号
    /// </summary>
    /// <remarks>
    /// 微信批次单号，微信商家转账系统返回的唯一标识
    /// <para>示例值：1030000071100999991182020050700019480001</para>
    /// </remarks>
    [JsonPropertyName("batch_id")]
    public string BatchId { get; set; }

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
    /// 批次状态
    /// </summary>
    /// <remarks>
    /// 枚举值：
    /// WAIT_PAY：待付款，商户员工确认付款阶段
    /// ACCEPTED:已受理。批次已受理成功，若发起批量转账的30分钟后，转账批次单仍处于该状态，可能原因是商户账户余额不足等。商户可查询账户资金流水，若该笔转账批次单的扣款已经发生，则表示批次已经进入转账中，请再次查单确认
    /// PROCESSING:转账中。已开始处理批次内的转账明细单
    /// FINISHED：已完成。批次内的所有转账明细单都已处理完成
    /// CLOSED：已关闭。可查询具体的批次关闭原因确认
    /// <para>示例值：ACCEPTED</para>
    /// </remarks>
    [JsonPropertyName("batch_status")]
    public string BatchStatus { get; set; }

    /// <summary>
    /// 批次类型
    /// </summary>
    /// <remarks>
    /// 枚举值：
    /// API：API方式发起
    /// WEB：页面方式发起
    /// <para>示例值：API</para>
    /// </remarks>
    [JsonPropertyName("batch_type")]
    public string BatchType { get; set; }

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
    /// 批次关闭原因
    /// </summary>
    /// <remarks>
    /// 如果批次单状态为“CLOSED”（已关闭），则有关闭原因
    /// MERCHANT_REVOCATION：商户主动撤销
    /// OVERDUE_CLOSE：系统超时关闭
    /// <para>示例值：OVERDUE_CLOSE</para>
    /// </remarks>
    [JsonPropertyName("close_reason")]
    public string CloseReason { get; set; }

    /// <summary>
    /// 转账总金额
    /// </summary>
    /// <remarks>
    /// 转账金额单位为分
    /// <para>示例值：4000000</para>
    /// </remarks>
    [JsonPropertyName("total_amount")]
    public int TotalAmount { get; set; }

    /// <summary>
    /// 转账总笔数
    /// </summary>
    /// <remarks>
    /// 一个转账批次单最多发起三千笔转账
    /// <para>示例值：200</para>
    /// </remarks>
    [JsonPropertyName("total_num")]
    public int TotalNum { get; set; }

    /// <summary>
    /// 批次创建时间
    /// </summary>
    /// <remarks>
    /// 批次受理成功时返回，遵循rfc3339标准格式，格式为yyyy-MM-DDTHH:mm:ss.sss+TIMEZONE，yyyy-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒
    /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
    /// </remarks>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// 批次更新时间
    /// </summary>
    /// <remarks>
    /// 批次最近一次状态变更的时间，遵循rfc3339标准格式，格式为yyyy-MM-DDTHH:mm:ss.sss+TIMEZONE，yyyy-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒
    /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
    /// </remarks>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; }

    /// <summary>
    /// 转账成功金额
    /// </summary>
    /// <remarks>
    /// 转账成功的金额，单位为分。当批次状态为“PROCESSING”（转账中）时，转账成功金额随时可能变化
    /// <para>示例值：3900000</para>
    /// </remarks>
    [JsonPropertyName("success_amount")]
    public int? SuccessAmount { get; set; }

    /// <summary>
    /// 转账成功笔数
    /// </summary>
    /// <remarks>
    /// 转账成功的笔数。当批次状态为“PROCESSING”（转账中）时，转账成功笔数随时可能变化
    /// <para>示例值：199</para>
    /// </remarks>
    [JsonPropertyName("success_num")]
    public int? SuccessNum { get; set; }

    /// <summary>
    /// 转账失败金额
    /// </summary>
    /// <remarks>
    /// 转账失败的金额，单位为分
    /// <para>示例值：100000</para>
    /// </remarks>
    [JsonPropertyName("fail_amount")]
    public int? FailAmount { get; set; }

    /// <summary>
    /// 转账失败笔数
    /// </summary>
    /// <remarks>
    /// 转账失败的笔数
    /// <para>示例值：1</para>
    /// </remarks>
    [JsonPropertyName("fail_num")]
    public int? FailNum { get; set; }
}
