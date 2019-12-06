using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsPerson Data Structure.
    /// </summary>
    public class InsPerson : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 干系人地址区县编码
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 投保参数;标准json格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 证件上名称;如果渠道账号字段没填则必填
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码;如果渠道账号字段没填则必填
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型;如果渠道账号字段没填则必填   100:居民身份证;102:护照;103:军官证;104:士兵证;105:港澳居民往来内地通行证;106:台湾同胞往来大陆通行证;109:警官证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 渠道账号对应的uid;如果证件类型字段没填则必填
        /// </summary>
        [JsonPropertyName("channel_user_id")]
        public string ChannelUserId { get; set; }

        /// <summary>
        /// 渠道账号来源;1:支付宝账号 2:淘宝账号;如果证件类型字段没填则必填
        /// </summary>
        [JsonPropertyName("channel_user_source")]
        public string ChannelUserSource { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 性别;M:男 F:女
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 1:卖家；2:支付人;
        /// </summary>
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 张三
        /// </summary>
        [JsonPropertyName("pronounce_name")]
        public string PronounceName { get; set; }

        /// <summary>
        /// 支付宝会员ID;如果是投保人则必填
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
