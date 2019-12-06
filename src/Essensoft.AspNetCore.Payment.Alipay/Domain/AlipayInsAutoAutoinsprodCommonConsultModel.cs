using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodCommonConsultModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodCommonConsultModel : AlipayObject
    {
        /// <summary>
        /// 业务内容  具体内容按照业务类型对应的key值传输
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 业务场景码  AUTO_GET_CAR_MODEL_LIST 获取车型列表  AUTO_GET_COMPANY_LIST_IN_SERVICE 获取可报价机构列表  AUTO_ SEND_MOBILE_MSG_FOR_BEIJING 发送北京验证码请求  AUTO_VERIFY_MOBILE_MSG_FOR_BEIJING 验证北京验证码请求  AUTO_GET_DELIVER_GROUP 获取保单配送地区分组  AUTO_GET_CHECK_CODE_BEFORE_PAY 下单之前获取中保信验证码  AUTO_ VERIFY_CHECK_CODE_BEFORE_PAY_FOR 下单之前验证中保信验证码
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }
    }
}
