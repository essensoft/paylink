using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ParamModel Data Structure.
    /// </summary>
    public class ParamModel : AlipayObject
    {
        /// <summary>
        /// 是否开启取餐柜（false：否，true：是）
        /// </summary>
        [JsonPropertyName("cabinet_enabled")]
        public bool CabinetEnabled { get; set; }

        /// <summary>
        /// 账单金额位数
        /// </summary>
        [JsonPropertyName("carry_rule")]
        public string CarryRule { get; set; }

        /// <summary>
        /// 就餐模式（  takeMeal：取餐模式（默认）；  foodDelivery：送餐模式  ）
        /// </summary>
        [JsonPropertyName("dining_mode")]
        public string DiningMode { get; set; }

        /// <summary>
        /// KDS显示模式（singleDish：单菜，mergingOrder：并单）
        /// </summary>
        [JsonPropertyName("kds_display_mode")]
        public string KdsDisplayMode { get; set; }

        /// <summary>
        /// 是否开启KDS（false：否，true：是）
        /// </summary>
        [JsonPropertyName("kds_enabled")]
        public bool KdsEnabled { get; set; }

        /// <summary>
        /// 是否开启KDS语音叫号（false：否，true：是）
        /// </summary>
        [JsonPropertyName("kds_voice_call_enabled")]
        public bool KdsVoiceCallEnabled { get; set; }

        /// <summary>
        /// 是否支持一单多柜（false：否，true：是）
        /// </summary>
        [JsonPropertyName("multi_cabinet_per_order_allowed")]
        public bool MultiCabinetPerOrderAllowed { get; set; }

        /// <summary>
        /// 是否开通饿了么（false：否；true：是）
        /// </summary>
        [JsonPropertyName("open_ele")]
        public bool OpenEle { get; set; }

        /// <summary>
        /// 异常操作原因（false：否；true：是）
        /// </summary>
        [JsonPropertyName("reason_flag")]
        public bool ReasonFlag { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 是否有桌台（false:否；true:是）
        /// </summary>
        [JsonPropertyName("table_flag")]
        public bool TableFlag { get; set; }

        /// <summary>
        /// 金额尾数规则（  yuan：元；  horn：角；  cent：分（默认）  ）
        /// </summary>
        [JsonPropertyName("tail_number_rule")]
        public string TailNumberRule { get; set; }

        /// <summary>
        /// 外卖是否自动接单（false：否；true：是）
        /// </summary>
        [JsonPropertyName("takeout_auto_receipt")]
        public bool TakeoutAutoReceipt { get; set; }
    }
}
