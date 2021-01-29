using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付 - 申请资金账单API（电商平台、服务商、直连商户）- 返回参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_7.shtml">JSAPI支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_7.shtml">APP支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_7.shtml">H5支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_7.shtml">Native支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_7.shtml">小程序支付 - 申请资金账单API</a></para>
    /// 最新更新时间：2019.09.16    /// </summary>
    public class WeChatPayBillFundflowBillResponse : WeChatPayResponse
    {
        /// 哈希类型
        /// 从download_url下载的文件的哈希类型，用于校验文件的完整性。
        /// 示例值：SHA1
        /// </summary>
        [JsonPropertyName("hash_type")]
        public string HashType { get; set; }

        /// <summary>
        /// 哈希值
        /// 从download_url下载的文件的哈希值，用于校验文件的完整性。
        /// 示例值：79bb0f45fc4c42234a918000b2668d689e2bde04
        /// </summary>
        [JsonPropertyName("hash_value")]
        public string HashValue { get; set; }

        /// <summary>
        /// 账单下载地址
        /// 供下一步请求账单文件的下载地址，该地址30s内有效。
        /// 示例值：https://api.mch.weixin.qq.com/v3/billdownload/file?token=xxx
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }
    }
}
