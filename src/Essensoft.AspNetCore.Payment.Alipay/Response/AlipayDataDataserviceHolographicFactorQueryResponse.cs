using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceHolographicFactorQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceHolographicFactorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 参数中文名称:身份证号  是否唯一：否  参数作用/应用场景：查询人脉因子和多头因子必备的用户三要素之一  枚举值：无  如何获取：商户传递给上数，上数传递到openapi  特殊说明：无
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 参数中文名称:用户手机号  是否唯一：否  参数作用/应用场景：查询人脉因子和多头因子必备的用户三要素之一  枚举值：无  如何获取：商户传递给上数，上数传递到openapi  特殊说明：无
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 参数中文名称:多头因子map打平成json的字符串  是否唯一：否  参数作用/应用场景：返回给上数商户全息报告中的多头因子  枚举值：无  如何获取：信用中台运行模型产生  特殊说明：无
        /// </summary>
        [JsonPropertyName("muti_loan_factor_map")]
        public string MutiLoanFactorMap { get; set; }

        /// <summary>
        /// 参数中文名称:人脉因子map打平成json字符串  是否唯一：否  参数作用/应用场景：返回给上数商户全息报告中的人脉因子  枚举值：无  如何获取：信用中台运行模型产生  特殊说明：无
        /// </summary>
        [JsonPropertyName("rsm_factor_map")]
        public string RsmFactorMap { get; set; }

        /// <summary>
        /// 参数中文名称:用户姓名  是否唯一：否  参数作用/应用场景：查询人脉因子和多头因子必备的用户三要素之一  枚举值：无  如何获取：商户传递给上数，上数传递到openapi  特殊说明：无
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
