using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvertPurchaseModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionAdvertPurchaseModel : AlipayObject
    {
        /// <summary>
        /// 渠道ID
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 外部用户唯一标识(用于生成校验码，只有白名单ISV才可不填)
        /// </summary>
        [JsonPropertyName("out_unique_id")]
        public string OutUniqueId { get; set; }

        /// <summary>
        /// 校验码（只有白名单ISV才可不填）    生成地址：    http://pin.aliyun.com/get_img  参数：    sessionid-外部用户唯一标识(和上面的out_unique_id保持一致)    identity-固定值，请输入kbadvert    type-验证码图片类型  【type取值说明】    type - 内容 - 尺寸    default - 4位数字&大小写 - 100x30    number - 6位纯数字 - 100x30    150_40 - 4位数字&大小写 - 150x40    请求示例：http://pin.aliyun.com/get_img?sessionid=13000000000&identity=kbadvert&type=default    验证码校验地址示例：http://pin.aliyun.com/check_code?sessionid=13000000000&identity=kbadvert&code=PNRT
        /// </summary>
        [JsonPropertyName("security_code")]
        public string SecurityCode { get; set; }

        /// <summary>
        /// 推广参与打标(无实际业务作用，后期可供ISV分析不同渠道的推广效能)
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 参与主键列表  trigger_identify_type=advert所有值都必须是广告ID
        /// </summary>
        [JsonPropertyName("trigger_identifies")]
        public List<string> TriggerIdentifies { get; set; }

        /// <summary>
        /// 参与主键类型  advert-广告ID  delivery_id-外投ID（通过koubei.advert.delivery.discount.batchquery接口获取的外投ID）
        /// </summary>
        [JsonPropertyName("trigger_identify_type")]
        public string TriggerIdentifyType { get; set; }

        /// <summary>
        /// 用户领取券策略  FIRST_CAN_PURCHASE：第一个可领  ALL_PURCHASE：领取所有（默认）
        /// </summary>
        [JsonPropertyName("trigger_strategy")]
        public string TriggerStrategy { get; set; }

        /// <summary>
        /// 用户身份主键  user_identify_type=phone-值必须是用户手机号
        /// </summary>
        [JsonPropertyName("user_identify")]
        public string UserIdentify { get; set; }

        /// <summary>
        /// 用户身份主键类型  phone-手机号  user_id - 支付宝账户ID
        /// </summary>
        [JsonPropertyName("user_identify_type")]
        public string UserIdentifyType { get; set; }
    }
}
