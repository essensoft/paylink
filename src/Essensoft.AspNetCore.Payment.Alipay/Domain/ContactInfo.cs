using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContactInfo Data Structure.
    /// </summary>
    public class ContactInfo : AlipayObject
    {
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 商户联系人业务标识枚举，表示商户联系人的职责。异议处理接口人:02;商户关键联系人:06;数据反馈接口人:11;服务联动接口人:08
        /// </summary>
        [JsonProperty("tag")]
        public List<string> Tag { get; set; }

        /// <summary>
        /// 联系人类型，取值范围：LEGAL_PERSON：法人；CONTROLLER：实际控制人；AGENT：代理人；OTHER：其他
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
