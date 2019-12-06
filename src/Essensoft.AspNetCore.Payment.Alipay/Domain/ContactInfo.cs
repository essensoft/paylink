using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonPropertyName("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 手机号。必填与否参见外层对象描述，无特别说明认为是非必填
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 商户联系人业务标识枚举，表示商户联系人的职责。异议处理接口人:02;商户关键联系人:06;数据反馈接口人:11;服务联动接口人:08
        /// </summary>
        [JsonPropertyName("tag")]
        public List<string> Tag { get; set; }

        /// <summary>
        /// 联系人类型，取值范围：LEGAL_PERSON：法人；CONTROLLER：实际控制人；AGENT：代理人；OTHER：其他
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
