using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialAntforestTreeSyncModel Data Structure.
    /// </summary>
    public class AlipaySocialAntforestTreeSyncModel : AlipayObject
    {
        /// <summary>
        /// 待同步的证书的来源账户id
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 待同步时的证书id，有之前调用申请兑换树种成功时返回的证书id
        /// </summary>
        [JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// JSON字符串，历史数据同步时accountName、type、participant必填，其他字段选填。其中accountName为账号名称，例如钉钉固定传“钉钉”，type为合种类型：班级或公司公益林（class/corp），cooperation为合种名称或班级名称，participant为兑换证书时合种的人数，非合种实时人数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 待同步证书的所属用户，蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
