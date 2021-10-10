using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 微信支付分 - 商户申请获取对账单 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_29.shtml">微信支付分 - 商户申请获取对账单API</a> - 最新更新时间：2021.09.18</para>
    /// </remarks>

    public class WeChatPayScoreMerchantBillQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 账单日期
        /// </summary>
        /// <remarks>
        /// 格式YYYY-MM-DD，仅支持下载近三个月的账单
        /// <para>示例值：2021-01-01</para>
        /// </remarks>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单压缩类型
        /// </summary>
        /// <remarks>
        /// 账单的压缩类型
        /// GZIP：文件压缩方式为gzip，返回.gzip格式的压缩文件
        /// <para>示例值：GZIP</para>
        /// </remarks>
        [JsonPropertyName("tar_type")]
        public string TarType { get; set; }

        /// <summary>
        /// 加密算法
        /// </summary>
        /// <remarks>
        /// 对返回账单原文加密的算法
        /// AEAD_AES_256_GCM：AEAD_AES_256_GCM加密算法，账单使用AEAD_AES_256_GCM加密算法进行加密
        /// <para>示例值：AEAD_AES_256_GCM</para>
        /// </remarks>
        [JsonPropertyName("encryption_algorithm")]
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 支付分服务ID
        /// <para>示例值：2002000000000558128851361561536</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
