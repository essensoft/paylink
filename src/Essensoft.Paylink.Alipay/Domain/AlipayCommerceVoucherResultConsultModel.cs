using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceVoucherResultConsultModel Data Structure.
    /// </summary>
    public class AlipayCommerceVoucherResultConsultModel : AlipayObject
    {
        /// <summary>
        /// isv的商户pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 咨询商品信息
        /// </summary>
        [JsonPropertyName("item_consult_list")]
        public ItemConsultRequest ItemConsultList { get; set; }

        /// <summary>
        /// 核销门店的pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 订单金额（如同时享受商户自有优惠请先扣除后传入），单位为元，最多2位小数
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
