using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardUpdateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardUpdateModel : AlipayObject
    {
        /// <summary>
        /// 需要修改的最新卡信息
        /// </summary>
        [JsonPropertyName("card_info")]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 扩展信息(暂时无用)
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 注意：此字段已废弃，卡面样式以模板中的定义为准。  会员卡卡面展示样式  参考：展示位置详情参考"商户会员卡->快速接入文档->第四步"   备注：mcard_style_info与card_info下的template_id不能同时更新
        /// </summary>
        [JsonPropertyName("mcard_style_info")]
        public McardStylInfo McardStyleInfo { get; set; }

        /// <summary>
        /// 卡信息变更通知消息  1、在列表中定义的消息，才会发送给用户，消息格式一定。  2、根据卡信息变更情况，一次可发送多个消息
        /// </summary>
        [JsonPropertyName("notify_messages")]
        public List<McardNotifyMessage> NotifyMessages { get; set; }

        /// <summary>
        /// 标识业务发生的时间
        /// </summary>
        [JsonPropertyName("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 支付宝业务卡号，即开卡接口返回结果中的card_info.biz_card_no
        /// </summary>
        [JsonPropertyName("target_card_no")]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型  BIZ_CARD：支付宝业务卡号
        /// </summary>
        [JsonPropertyName("target_card_no_type")]
        public string TargetCardNoType { get; set; }
    }
}
