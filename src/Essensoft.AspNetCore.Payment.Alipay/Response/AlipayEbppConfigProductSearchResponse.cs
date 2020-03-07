using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppConfigProductSearchResponse.
    /// </summary>
    public class AlipayEbppConfigProductSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 出账机构简称例如杭州电力的简称为HZELECTRIC
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构英文简称
        /// </summary>
        [JsonPropertyName("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 错误码，查询失败的返回码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息描述，如参数不合法
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 输入域模型列表inputFieldList
        /// </summary>
        [JsonPropertyName("input_field_list")]
        public List<InputFieldModel> InputFieldList { get; set; }

        /// <summary>
        /// 是否成功，true或者false
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }
    }
}
