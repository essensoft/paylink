using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请交易账单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_6.shtml">基础支付 - JSAPI支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_6.shtml">基础支付 - APP支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_6.shtml">基础支付 - H5支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_6.shtml">基础支付 - Native支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_6.shtml">基础支付 - 小程序支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_6.shtml">基础支付(服务商) - JSAPI支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_6.shtml">基础支付(服务商) - APP支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_6.shtml">基础支付(服务商) - H5支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_6.shtml">基础支付(服务商) - Native支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_6.shtml">基础支付(服务商) - 小程序支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// </remarks>
    public class WeChatPayBillTradeBillResponse : WeChatPayResponse
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
