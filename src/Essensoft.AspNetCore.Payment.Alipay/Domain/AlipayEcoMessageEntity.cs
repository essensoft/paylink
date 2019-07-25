using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMessageEntity Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMessageEntity : AlipayObject
    {
        /// <summary>
        /// (certificate_type/certificate_number/用户名字) 或者 alipay_user_id  必须有一个不为空。两个都不为空则以alipay_user_id为准
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 入驻城市服务的服务编码
        /// </summary>
        [JsonProperty("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 证件号码.(certificate_type/certificate_number/certificate_username) 或者 alipay_user_id 必须有一个不为空。两个都不为空则以alipay_user_id为准.  该字段为敏感字段，须做md5处理后传输。示例中值的明文为310101198011110010.
        /// </summary>
        [JsonProperty("certificate_number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证件类型, 01表示身份证.(certificate_type/certificate_number/certificate_username) 或者 alipay_user_id 必须有一个不为空。两个都不为空则以alipay_user_id为准.
        /// </summary>
        [JsonProperty("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 证件用户名字.(certificate_type/certificate_number/certificate_username) 或者 alipay_user_id 必须有一个不为空。两个都不为空则以alipay_user_id为准.
        /// </summary>
        [JsonProperty("certificate_username")]
        public string CertificateUsername { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 消息参数信息，json格式字符串.   该字段与msg_type对应，不同类型的消息需要传不同的参数信息，详情参考接口补充说明.
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 行业类型. 1=社保，2=公积金，3=交警
        /// </summary>
        [JsonProperty("industry_type")]
        public long IndustryType { get; set; }

        /// <summary>
        /// 消息类型. 1=动账.2=账单.3=缴费.4=办件进度.5=证件到期.6=违章提醒.  更多请参考接口补充说明
        /// </summary>
        [JsonProperty("msg_type")]
        public long MsgType { get; set; }

        /// <summary>
        /// 消息跳转url
        /// </summary>
        [JsonProperty("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// identity字段：值为不大于64位的保证唯一的字符串；该字段用于保证消息唯一性，防止消息重复推送，相当于业务流水号，由接入方自行生成
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
