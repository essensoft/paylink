using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderCreateandpayModel Data Structure.
    /// </summary>
    public class AlipayMerchantOrderCreateandpayModel : AlipayObject
    {
        /// <summary>
        /// 不同的业务类型有不同的状态推进逻辑，同时对于支付的驱动有不同的处理方法。如阿里云的现金支付不需要订单驱动，阿里云的纯积分支付需要等待代扣成功消息才算支付成功。
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 买家身份
        /// </summary>
        [JsonPropertyName("buyer")]
        public UserIdentity Buyer { get; set; }

        /// <summary>
        /// 业务扩展参数（键值对列表，有重复的键后者覆盖前者，建议唯一，以免出现不可预期的结果），比如在阿里云购买场景下可以传[{"ext_key":"aliyun_order_id","ext_value":"20196478824390"}]
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品信息，包括alipay商品skuId、购买数量等信息
        /// </summary>
        [JsonPropertyName("goods_infos")]
        public List<GoodsInformation> GoodsInfos { get; set; }

        /// <summary>
        /// 订单金额，比如[{"type":"MONEY","amount":88.66},{"type":"FAMILY_POINT","amount":2000}]，代表订单中所有商品需要支付的总金额是88.66元+2000家庭积分。
        /// </summary>
        [JsonPropertyName("order_amount")]
        public List<PriceInformation> OrderAmount { get; set; }

        /// <summary>
        /// 外部业务号，用于幂等控制，64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付请求，比如下面的请求代表在这次下单中支付2000家庭积分[{"request_no":"2019678438","action":"PAY","amount":{"type":"FAMILY_POINT","amount":2000}}]，如果是现金单位元。之所以是一个list是为了支持多笔支付，支付失败重试请不要更换request_no
        /// </summary>
        [JsonPropertyName("payment_request")]
        public List<PaymentInformation> PaymentRequest { get; set; }

        /// <summary>
        /// 卖家身份
        /// </summary>
        [JsonPropertyName("seller")]
        public UserIdentity Seller { get; set; }

        /// <summary>
        /// service_type是基于biz_scene的，biz_scene+service_type唯一标识了一个业务场景
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}
