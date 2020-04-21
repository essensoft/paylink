using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestShieldResultSyncModel Data Structure.
    /// </summary>
    public class KoubeiQualityTestShieldResultSyncModel : AlipayObject
    {
        /// <summary>
        /// 口碑加购单号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 节点执行结果
        /// </summary>
        [JsonPropertyName("check_result_list")]
        public List<CheckResultList> CheckResultList { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号，在ISV点餐对接中，特指POS侧订单ID，在接单回执中由ISV给到口碑； 特别说明： 在首次点菜场景中，推单信息中此参数为空；在加菜场景中，此参数不为空；
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付类型。 ADVANCE_PAYMENT：先付； AFTER_PAYMENT：后付；
        /// </summary>
        [JsonPropertyName("pay_style")]
        public string PayStyle { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
