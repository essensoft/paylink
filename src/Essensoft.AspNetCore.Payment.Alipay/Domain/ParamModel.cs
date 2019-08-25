using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ParamModel Data Structure.
    /// </summary>
    [Serializable]
    public class ParamModel : AlipayObject
    {
        /// <summary>
        /// 是否开启取餐柜（false：否，true：是）
        /// </summary>
        [JsonProperty("cabinet_enabled")]
        public bool CabinetEnabled { get; set; }

        /// <summary>
        /// 账单金额位数
        /// </summary>
        [JsonProperty("carry_rule")]
        public string CarryRule { get; set; }

        /// <summary>
        /// 就餐模式（  takeMeal：取餐模式（默认）；  foodDelivery：送餐模式  ）
        /// </summary>
        [JsonProperty("dining_mode")]
        public string DiningMode { get; set; }

        /// <summary>
        /// KDS显示模式（singleDish：单菜，mergingOrder：并单）
        /// </summary>
        [JsonProperty("kds_display_mode")]
        public string KdsDisplayMode { get; set; }

        /// <summary>
        /// 是否开启KDS（false：否，true：是）
        /// </summary>
        [JsonProperty("kds_enabled")]
        public bool KdsEnabled { get; set; }

        /// <summary>
        /// 是否开启KDS语音叫号（false：否，true：是）
        /// </summary>
        [JsonProperty("kds_voice_call_enabled")]
        public bool KdsVoiceCallEnabled { get; set; }

        /// <summary>
        /// 是否支持一单多柜（false：否，true：是）
        /// </summary>
        [JsonProperty("multi_cabinet_per_order_allowed")]
        public bool MultiCabinetPerOrderAllowed { get; set; }

        /// <summary>
        /// 是否开通饿了么（false：否；true：是）
        /// </summary>
        [JsonProperty("open_ele")]
        public bool OpenEle { get; set; }

        /// <summary>
        /// 异常操作原因（false：否；true：是）
        /// </summary>
        [JsonProperty("reason_flag")]
        public bool ReasonFlag { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 是否有桌台（false:否；true:是）
        /// </summary>
        [JsonProperty("table_flag")]
        public bool TableFlag { get; set; }

        /// <summary>
        /// 金额尾数规则（  yuan：元；  horn：角；  cent：分（默认）  ）
        /// </summary>
        [JsonProperty("tail_number_rule")]
        public string TailNumberRule { get; set; }

        /// <summary>
        /// 外卖是否自动接单（false：否；true：是）
        /// </summary>
        [JsonProperty("takeout_auto_receipt")]
        public bool TakeoutAutoReceipt { get; set; }
    }
}
