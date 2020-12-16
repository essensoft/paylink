using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeCreateModel Data Structure.
    /// </summary>
    public class AlipayTradeCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝的店铺编号
        /// </summary>
        [JsonPropertyName("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 对交易或商品的描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [JsonPropertyName("business_params")]
        public BusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 买家的支付宝唯一用户号（2088开头的16位纯数字）
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝账号，和buyer_id不能同时为空
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割  注，与enable_pay_channels互斥  <a href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>
        /// </summary>
        [JsonPropertyName("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 可打折金额.  参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  如果该值未传入，但传入了【订单总金额】，【不可打折金额】则该值默认为【订单总金额】-【不可打折金额】
        /// </summary>
        [JsonPropertyName("discountable_amount")]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 可用渠道,用户只能在指定渠道范围内支付，多个渠道以逗号分割  注，与disable_pay_channels互斥  渠道列表：https://docs.open.alipay.com/common/wifww7
        /// </summary>
        [JsonPropertyName("enable_pay_channels")]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 外部指定买家
        /// </summary>
        [JsonPropertyName("ext_user_info")]
        public ExtUserInfo ExtUserInfo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式，其它说明详见：“商品明细说明”
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [JsonPropertyName("logistics_detail")]
        public LogisticsDetail LogisticsDetail { get; set; }

        /// <summary>
        /// 商户原始订单号，最大长度限制32位
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户操作员编号
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 销售产品码。 如果签约的是当面付快捷版，则传OFFLINE_PAYMENT; 其它支付宝当面付产品传FACE_TO_FACE_PAYMENT； 不传默认使用FACE_TO_FACE_PAYMENT；
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 收货人及地址信息
        /// </summary>
        [JsonPropertyName("receiver_address_info")]
        public ReceiverAddressInfo ReceiverAddressInfo { get; set; }

        /// <summary>
        /// 描述分账信息，json格式。
        /// </summary>
        [JsonPropertyName("royalty_info")]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。  如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 描述结算信息，json格式，详见结算参数说明
        /// </summary>
        [JsonPropertyName("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 二级商户信息,当前只对特殊银行机构特定场景下使用此字段
        /// </summary>
        [JsonPropertyName("sub_merchant")]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// 商品标题/交易标题/订单标题/订单关键字等。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  如果同时传入了【打折金额】，【不可打折金额】，【订单总金额】三者，则必须满足如下条件：【订单总金额】=【打折金额】+【不可打折金额】
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额.  不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  如果该值未传入，但传入了【订单总金额】,【打折金额】，则该值默认为【订单总金额】-【打折金额】
        /// </summary>
        [JsonPropertyName("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }
    }
}
