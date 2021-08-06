using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenContentIotCouponQueryResponse.
    /// </summary>
    public class AlipayOpenContentIotCouponQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 加密后的下一步rpc操作信息，用于客户编排操作流程
        /// </summary>
        [JsonPropertyName("btn_act")]
        public string BtnAct { get; set; }

        /// <summary>
        /// 活动ID，用于后续的领券确认动作，来源于商家在B站的配置
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 组件模板类型，取值来自于业务方自定义，目前只有CommonDataH5一种
        /// </summary>
        [JsonPropertyName("component_template")]
        public string ComponentTemplate { get; set; }

        /// <summary>
        /// 加密后的营销组件内容，数据来源于mrchpromoprod
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 活动具体类型，定义来源于mrchpromoprod
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 返回的券信息是否为空，用于流程编排时的决策节点判断。为true时，可以进行领券操作。
        /// </summary>
        [JsonPropertyName("nonempty_coupon_list")]
        public bool NonemptyCouponList { get; set; }

        /// <summary>
        /// 发券类型，来自于mrchpromoprod，枚举值包括ITEM_DISCOUNT_VOUCHER、GLOBAL_FIX_VOUCHER、GLOBAL_DISCOUNT_VOUCHER、ITEM_FIX_VOUCHER、ITEM_SPECIAL_VOUCHER共5种
        /// </summary>
        [JsonPropertyName("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 加密后的服务端查询到的店铺信息，数据来源于商家平台mif
        /// </summary>
        [JsonPropertyName("shop_info")]
        public string ShopInfo { get; set; }

        /// <summary>
        /// 发券信息
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 加密后的语音播报信息，数据来源于mrchpromoprod
        /// </summary>
        [JsonPropertyName("voice_broadcast")]
        public string VoiceBroadcast { get; set; }
    }
}
