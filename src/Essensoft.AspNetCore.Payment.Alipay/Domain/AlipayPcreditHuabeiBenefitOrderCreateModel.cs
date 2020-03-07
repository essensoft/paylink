using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiBenefitOrderCreateModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiBenefitOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝业务单据号，在scene=BLUE_ARROW时候，必填，且值为先享协议号
        /// </summary>
        [JsonPropertyName("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务自定义参数，例如权益账务相关数据通过该字段传递  [      {        "key1": "value1"      },      {        "key2": "value2"      }    ]
        /// </summary>
        [JsonPropertyName("biz_param")]
        public List<KeyValuePair> BizParam { get; set; }

        /// <summary>
        /// 商户端业务发生时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 是否需要多次触发。权益打包和多次触发场景会有为true，默认为false
        /// </summary>
        [JsonPropertyName("need_repeat")]
        public bool NeedRepeat { get; set; }

        /// <summary>
        /// 权益商品id
        /// </summary>
        [JsonPropertyName("out_goods_id")]
        public string OutGoodsId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。支付宝侧用来做请求的幂等
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 权益商品sku_id，如果此项为空，会发放out_goods_id里面对应的所有sku
        /// </summary>
        [JsonPropertyName("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商户请求场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 是否立即触发发放。默认为false。蓝箭项目里面需要将此项设置为true
        /// </summary>
        [JsonPropertyName("trigger_send")]
        public bool TriggerSend { get; set; }
    }
}
