using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SiData Data Structure.
    /// </summary>
    [Serializable]
    public class SiData : AlipayObject
    {
        /// <summary>
        /// 唯一定位一次报文请求，由商户生成， 确保唯一
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝处理完请求后，当前页面跳转到商户网站里指定页面的http路径，业务详情url。
        /// </summary>
        [JsonProperty("service_return_url")]
        public string ServiceReturnUrl { get; set; }

        /// <summary>
        /// 目标人扩展信息,Json值
        /// </summary>
        [JsonProperty("target_extend_params")]
        public string TargetExtendParams { get; set; }

        /// <summary>
        /// 目标人证件号
        /// </summary>
        [JsonProperty("target_idcard")]
        public string TargetIdcard { get; set; }

        /// <summary>
        /// 目标人证件类型  证件类型  身份证：01   等
        /// </summary>
        [JsonProperty("target_idcard_type")]
        public string TargetIdcardType { get; set; }

        /// <summary>
        /// 目标人手机号
        /// </summary>
        [JsonProperty("target_mobile")]
        public string TargetMobile { get; set; }

        /// <summary>
        /// 社会保障卡卡号
        /// </summary>
        [JsonProperty("target_sicard_no")]
        public string TargetSicardNo { get; set; }

        /// <summary>
        /// 支付宝用户ID,可以通过获取会员信息产品 获取支付宝用户ID  证件信息和userid同时存在以userid为主  target_user_id>target_idcard
        /// </summary>
        [JsonProperty("target_user_id")]
        public string TargetUserId { get; set; }

        /// <summary>
        /// 目标人证件姓名
        /// </summary>
        [JsonProperty("target_user_name")]
        public string TargetUserName { get; set; }

        /// <summary>
        /// 模板数据
        /// </summary>
        [JsonProperty("template_data")]
        public string TemplateData { get; set; }

        /// <summary>
        /// 业务类型对应的模板编号：联调时需要咨询技术
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 场景数据的类型的版本,默认1.0
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }
    }
}
