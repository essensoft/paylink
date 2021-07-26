using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 资金应用 - 分账 - 申请分账账单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_11.shtml">资金应用 - 分账 - 申请分账账单API</a> - 最新更新时间：2021.07.22</para>
    /// </remarks>
    public class WeChatPayProfitSharingBillResponse : WeChatPayResponse
    {
        /// <summary>
        /// 哈希类型
        /// </summary>
        /// <remarks>
        /// 原始账单（gzip需要解压缩）的摘要值，用于校验文件的完整性。
        /// <para>示例值：SHA1</para>
        /// </remarks>
        [JsonPropertyName("hash_type")]
        public string HashType { get; set; }

        /// <summary>
        /// 哈希值
        /// </summary>
        /// <remarks>
        /// 原始账单（gzip需要解压缩）的摘要值，用于校验文件的完整性。
        /// <para>示例值：79bb0f45fc4c42234a918000b2668d689e2bde04</para>
        /// </remarks>
        [JsonPropertyName("hash_value")]
        public string HashValue { get; set; }

        /// <summary>
        /// 账单下载地址
        /// </summary>
        /// <remarks>
        /// 供下一步请求账单文件的下载地址，该地址30s内有效。
        /// <para>示例值：https://api.mch.weixin.qq.com/v3/billdownload/file?token=xxx</para>
        /// </remarks>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }
    }
}
