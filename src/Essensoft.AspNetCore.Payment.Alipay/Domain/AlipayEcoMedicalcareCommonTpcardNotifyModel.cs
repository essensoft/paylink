using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMedicalcareCommonTpcardNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMedicalcareCommonTpcardNotifyModel : AlipayObject
    {
        /// <summary>
        /// 模板样式信息中的底部动作
        /// </summary>
        [JsonProperty("action_info")]
        public List<MedicalSvTpCardActionInfo> ActionInfo { get; set; }

        /// <summary>
        /// 模板样式信息中的内容信息
        /// </summary>
        [JsonProperty("body_info")]
        public List<MedicalSvTpCardBodyInfo> BodyInfo { get; set; }

        /// <summary>
        /// 业务扩展参数json格式
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 模板样式信息中的头部信息
        /// </summary>
        [JsonProperty("header_info")]
        public MedicalSvTpCardHeadInfo HeaderInfo { get; set; }

        /// <summary>
        /// 通知时间  注意：通知时间确定card即时显示还是预定未来某个时间显示  通知时间不能早于当前时间
        /// </summary>
        [JsonProperty("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 操作类型：  CREATE_UPDATE表示创建并更新通知信息；  DELETE表示删除通知信息
        /// </summary>
        [JsonProperty("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 通知业务模板样式编码，根据业务增加会增加模板类型  sv_remind_reg 预约挂号  sv_remind_clinic 诊间缴费  sv_remind_answer 问诊首次答复  sv_remind_report 报告已出  sv_remind_vaccine 疫苗接种  sv_app_doctors_say 名医说
        /// </summary>
        [JsonProperty("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 第三方唯一序列号，创建后不能修改，需要保证在商户端不重复。
        /// </summary>
        [JsonProperty("third_no")]
        public string ThirdNo { get; set; }

        /// <summary>
        /// 支付宝用户ID,可以通过 获取会员信息产品 获取支付宝用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
