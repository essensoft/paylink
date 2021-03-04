using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 下载信息明细
    /// </summary>
    public class DownloadBill : WeChatPayObject
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
        /// 枚举值：
        /// SHA1：SHA1值
        /// <para>示例值：SHA1</para>
        /// </remarks>
        [JsonPropertyName("hash_type")]
        public string HashType { get; set; }

        /// <summary>
        /// 哈希值
        /// </summary>
        /// <remarks>
        /// 原始账单（gzip需要解压缩）的摘要值，用于校验文件的完整性
        /// <para>示例值：79bb0f45fc4c42234a918000b2668d689e2bde04</para>
        /// </remarks>
        [JsonPropertyName("hash_value")]
        public string HashValue { get; set; }

        /// <summary>
        /// 账单下载地址
        /// </summary>
        /// <remarks>
        /// 供下一步请求账单文件的下载地址，该地址5min内有效。
        /// <para>示例值：https://api.mch.weixin.qq.com/v3/bill/downloadurl?token=xxx</para>
        /// </remarks>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 加密密钥
        /// </summary>
        /// <remarks>
        /// 加密账单文件使用的加密密钥。密钥用商户证书的公钥进行加密，然后进行Base64编码
        /// <para>示例值：YpkbxSne+mDwyXq//xYPmtr9eQ5LsH7zLMZSs+GSEcY4wjhlsfioS4n9X6q1ZBL0wM1v5qd7KhWuj0rFJ4N1FidP7Q8KDy25QDTt46wiKnsPKSCAXWRFNw1D2JmJBqZsc9y5g0DupONWKYB2GfRigRDEBVszj67uOIILPdxOKX1w3N4jvu0U9IFanJa7ldm70KVvYrMWVgQFDPbgjh1gVDbuTAjmPN88AobLdkiegnBUS2woDZW+PfhPo13kweOiR3h1gXIKRlnKnN3Jkkwpna/AFFijXrFphO3voSuiV0CfptfzTtcae4X3DYG3RSroKqmpa+5tuy2aU2VJUSIuFQ==</para>
        /// </remarks>
        [JsonPropertyName("encrypt_key")]
        public string EncryptKey { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        /// <remarks>
        /// 加密账单文件使用的随机字符串
        /// <para>示例值：a8607ef79034c49c</para>
        /// </remarks>
        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }
    }
}
