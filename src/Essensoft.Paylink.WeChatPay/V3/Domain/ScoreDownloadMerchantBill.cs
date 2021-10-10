using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 下载信息明细
    /// </summary>
    public class ScoreDownloadMerchantBill : WeChatPayObject
    {
        /// <summary>
        /// 账单文件序号
        /// </summary>
        /// <remarks>
        /// 商户将多个文件按账单文件序号的顺序合并为完整的资金账单文件，起始值为1
        /// <para>示例值：1</para>
        /// </remarks>
        [JsonPropertyName("bill_sequence")]
        public int BillSequence { get; set; }

        /// <summary>
        /// 哈希类型
        /// </summary>
        /// <remarks>
        /// 账单摘要计算方式
        /// SHA1：SHA1值，Secure Hash Algorithm 1
        /// <para>示例值：SHA1</para>
        /// </remarks>
        [JsonPropertyName("hash_type")]
        public string HashType { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        /// <remarks>
        /// 下载地址5min内有效
        /// <para>示例值：https://api.mch.weixin.qq.com/v3/payscore/bill/downloadurl?token=xxx</para>
        /// </remarks>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 加密密钥
        /// </summary>
        /// <remarks>
        /// 加密账单文件使用的加密密钥。密钥用商户证书的公钥进行加密，然后进行Base64编码
        /// <para>示例值：a0YK7p+9XaKzE9N4qtFfG/9za1oqKlLXXJWBkH+kX84onAs2Ol/E1fk+6S+FuBXczGDRU8I8D+6PfbwKYBGm0wANUTqHOSezzfbieIo2t51UIId7sP9SoN38W2+IcYDviIsu59KSdyiL3TY2xqZNT8UDcnMWzTNZdSv+CLsSgblB6OKGN9JONTadOFGfv1OKkTp86Li+X7S9bG62wsa572/5Rm4MmDCiKwY4bX2EynWQHBEOExD5URxT6/MX3F1D3BNYrE4fUu1F03k25xVlXnZDjksy6Rf3SCgadR+Cepc6mdfF9b2gTxNsJFMEdYXbqL0W1WQZ3UqSPQCguK6uLA==</para>
        /// </remarks>
        [JsonPropertyName("encrypt_key")]
        public string EncryptKey { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        /// <remarks>
        /// 加密账单文件使用的随机字符串
        /// <para>示例值：5K8264ILTKCH16CQ2502SI8ZNMTM67VS</para>
        /// </remarks>
        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }
    }
}
