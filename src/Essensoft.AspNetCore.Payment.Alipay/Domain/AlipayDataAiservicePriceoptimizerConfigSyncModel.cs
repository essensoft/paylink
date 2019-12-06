using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiservicePriceoptimizerConfigSyncModel Data Structure.
    /// </summary>
    public class AlipayDataAiservicePriceoptimizerConfigSyncModel : AlipayObject
    {
        /// <summary>
        /// 内部接口版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 操作的内容，存json； 接入方需要沟通具体传入的参数和对应的含义，并以key-value格式传入。
        /// </summary>
        [JsonPropertyName("op_content")]
        public string OpContent { get; set; }

        /// <summary>
        /// 操作类型,如 config_modify:修改配置
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 产品类型，如 online_car:网约车 card50:50元储值卡
        /// </summary>
        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 标识业务场景 single_pay:单次支付定价  stored_value_card:储值卡
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 接入方名称,不同业务方的区分
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 渠道 alipay_tinyapp:支付宝小程序 app:app客户端
        /// </summary>
        [JsonPropertyName("trade_channel")]
        public string TradeChannel { get; set; }
    }
}
