using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response;

public class WeChatPayTransferDetailElectronicReceiptsQureyResponse : WeChatPayResponse
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

    /// <summary>
    /// 电子回单受理单号
    /// </summary>
    /// 电子回单受理单号，受理单据的唯一标识
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
}
