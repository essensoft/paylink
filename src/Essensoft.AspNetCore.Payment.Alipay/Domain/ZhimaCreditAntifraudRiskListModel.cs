using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditAntifraudRiskListModel Data Structure.
    /// </summary>
    public class ZhimaCreditAntifraudRiskListModel : AlipayObject
    {
        /// <summary>
        /// 地址信息。省+市+区/县+详细地址，长度不超过256，不含",","/u0001"，"|","&","^","\\"
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 银行卡号。中国大陆银行发布的银行卡:借记卡长度19位；信用卡长度16位；各位的取值位[0,9]的整数；不含虚拟卡
        /// </summary>
        [JsonPropertyName("bank_card")]
        public string BankCard { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。IDENTITY_CARD标识为身份证，目前仅支持身份证类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 电子邮箱。合法email，字母小写，特殊符号以半角形式出现
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 国际移动设备标志。15位长度数字
        /// </summary>
        [JsonPropertyName("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// ip地址。以"."分割的四段Ip，如 x.x.x.x，x为[0,255]之间的整数
        /// </summary>
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 物理地址。支持格式如下：xx:xx:xx:xx:xx:xx，xx-xx-xx-xx-xx-xx，xxxxxxxxxxxx，x取值范围[0,9]之间的整数及A，B，C，D，E，F
        /// </summary>
        [JsonPropertyName("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 手机号码。中国大陆合法手机号，长度11位，不含国家代码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名，长度不超过64，姓名中不含",","/u0001"，"|","&","^","\\"
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 产品码，标记商户接入的具体产品；直接使用每个接口入参中示例值即可
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，长度64位以内字符串，仅限字母数字下划线组合。该标识作为业务调用的唯一标识，商户要保证其业务唯一性，使用相同transaction_id的查询，芝麻在一段时间内（一般为1天）返回首次查询结果，超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// wifi的物理地址。支持格式如下：xx:xx:xx:xx:xx:xx，xx-xx-xx-xx-xx-xx，xxxxxxxxxxxx，x取值范围[0,9]之间的整数及A，B，C，D，E，F
        /// </summary>
        [JsonPropertyName("wifimac")]
        public string Wifimac { get; set; }
    }
}
