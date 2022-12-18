using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response;

public class WeChatPayTransferBillReceiptOutBatchNoResponse : WeChatPayResponse
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

    /// <summary>
    /// 电子回单申请单号
    /// </summary>
    /// 电子回单申请单号，申请单据的唯一标识
    /// <remarks>
    /// <para>示例值：1050000010509999485212020110200058820001</para>
    /// </remarks>
    [JsonPropertyName("signature_no")]
    public string SignatureNo { get; set; }

    /// <summary>
    /// 电子回单状态
    /// </summary>
    /// <remarks>
    /// 枚举值：
    /// ACCEPTED:已受理，电子签章已受理成功
    /// FINISHED:已完成。电子签章已处理完成
    /// <para>示例值：ACCEPTED</para>
    /// </remarks>
    [JsonPropertyName("signature_status")]
    public string SignatureStatus { get; set; }

    /// <summary>
    /// 电子回单文件的hash方法
    /// </summary>
    /// <remarks>
    /// 电子回单文件的hash方法，回单状态为：FINISHED时返回。
    /// <para>示例值：SHA256</para>
    /// </remarks>
    [JsonPropertyName("hash_type")]
    public string HashType { get; set; }

    /// <summary>
    /// 电子回单文件的hash值
    /// </summary>
    /// <remarks>
    /// 电子回单文件的hash值，用于下载之后验证文件的完整、正确性，回单状态为：FINISHED时返回。
    /// <para>示例值：DE731F35146A0BEFADE5DB9D1E468D96C01CA8898119C674FEE9F11F4DBE5529</para>
    /// </remarks>
    [JsonPropertyName("hash_value")]
    public string HashValue { get; set; }

    /// <summary>
    /// 电子回单文件的下载地址
    /// </summary>
    /// <remarks>
    /// 电子回单文件的下载地址，回单状态为：FINISHED时返回。URL有效时长为10分钟，10分钟后需要重新去获取下载地址（但不需要走受理）
    /// <para>示例值：https://api.mch.weixin.qq.com/v3/billdownload/file?token=xxx</para>
    /// </remarks>
    [JsonPropertyName("download_url")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    /// <remarks>
    /// 电子签章单创建时间，遵循rfc3339标准格式，格式为yyyy-MM-DDTHH:mm:ss.sss+TIMEZONE，yyyy-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒
    /// <para>示例值：2020-05-20T13:29:35.120+08:00</para>
    /// </remarks>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    /// <remarks>
    /// 电子签章单最近一次状态变更的时间，遵循rfc3339标准格式，格式为yyyy-MM-DDTHH:mm:ss.sss+TIMEZONE，yyyy-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示北京时间2015年05月20日13点29分35秒
    /// <para>示例值：2020-05-20T13:29:35.120+08:00</para>
    /// </remarks>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; }
}
