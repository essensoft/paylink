using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayTradePayModel Data Structure.
    /// </summary>
    public class AlipayTradePayModel : AlipayObject
    {
        /// <summary>
        /// 支付模式类型,若值为ENJOY_PAY_V2表示当前交易允许走先享后付2.0垫资
        /// </summary>
        [JsonPropertyName("advance_payment_type")]
        public string AdvancePaymentType { get; set; }

        /// <summary>
        /// 代扣业务需要传入协议相关信息
        /// </summary>
        [JsonPropertyName("agreement_params")]
        public AgreementParams AgreementParams { get; set; }

        /// <summary>
        /// 支付宝的店铺编号
        /// </summary>
        [JsonPropertyName("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 支付授权码，25~30开头的长度为16~24位的数字，实际字符串长度以开发者获取的付款码长度为准。 周期扣款（CYCLE_PAY_AUTH ）场景必填，传入用户签约号 agreement_no。 支付宝预授权（PRE_AUTH_ONLINE）、新当面资金授权（PRE_AUTH）场景不填，需替换为 auth_no 传入资金授权订单号。
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 预授权确认模式，授权转交易请求中传入，适用于预授权转交易业务使用，目前只支持PRE_AUTH(预授权产品码)  COMPLETE：转交易支付完成结束预授权，解冻剩余金额; NOT_COMPLETE：转交易支付完成不结束预授权，不解冻剩余金额
        /// </summary>
        [JsonPropertyName("auth_confirm_mode")]
        public string AuthConfirmMode { get; set; }

        /// <summary>
        /// 支付宝的资金授权订单号，预授权转交易场景必填。目前仅支持 支付宝预授权（PRE_AUTH_ONLINE）、新当面资金授权（PRE_AUTH）场景使用。
        /// </summary>
        [JsonPropertyName("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [JsonPropertyName("business_params")]
        public BusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 买家的支付宝用户 ID，若为空，则从传入的码值信息中获取用户 ID 新当面资金授权场景必填。
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 禁用支付渠道,多个渠道以逗号分割，如同时禁用信用支付类型和积分，则disable_pay_channels="credit_group,point"
        /// </summary>
        [JsonPropertyName("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果该值未传入，但传入了【订单总金额】和【不可打折金额】，则该值默认为【订单总金额】-【不可打折金额】
        /// </summary>
        [JsonPropertyName("discountable_amount")]
        public string DiscountableAmount { get; set; }

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
        /// 订单包含的商品列表信息，json格式。
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 是否异步支付，传入true时，表明本次期望走异步支付，会先将支付请求受理下来，再异步推进。商户可以通过交易的异步通知或者轮询交易的状态来确定最终的交易结果
        /// </summary>
        [JsonPropertyName("is_async_pay")]
        public bool IsAsyncPay { get; set; }

        /// <summary>
        /// 商户的原始订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户操作员编号。 新当面资金授权场景必填。
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户订单号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则返回给商户时会回传该参数。支付宝只会在同步返回（包括跳转回商户网站）和异步通知时将该参数原样返回。本参数必须进行UrlEncode之后才可以发送给支付宝。
        /// </summary>
        [JsonPropertyName("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 产品码，默认 FACE_TO_FACE_PAYMENT（当面付），枚举支持： PRE_AUTH_ONLINE：支付宝预授权。 PRE_AUTH：新当面资金授权。 CYCLE_PAY_AUTH ：周期扣款。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠明细参数，通过此属性补充营销参数
        /// </summary>
        [JsonPropertyName("promo_params")]
        public PromoParam PromoParams { get; set; }

        /// <summary>
        /// 返回查询选项，商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。如：["fund_bill_list","voucher_detail_list","discount_goods_detail"]
        /// </summary>
        [JsonPropertyName("query_options")]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 收单机构(例如银行）的标识，填写该机构在支付宝的pid。只在机构间联场景下传递该值。
        /// </summary>
        [JsonPropertyName("request_org_pid")]
        public string RequestOrgPid { get; set; }

        /// <summary>
        /// 描述分账信息，json格式，其它说明详见分账说明
        /// </summary>
        [JsonPropertyName("royalty_info")]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 支付场景。条码支付场景固定为：bar_code。 周期扣款后续代扣时必填，固定为 deduct_pay； 新当面资金授权场景固定为 bar_code。 支付宝预授权景无需传入。 
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 新当面资金授权场景必填。
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 商户指定的结算币种，支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [JsonPropertyName("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 描述结算信息，json格式，详见结算参数说明
        /// </summary>
        [JsonPropertyName("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 商户门店编号。 新当面资金授权场景必填。
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 间连受理商户信息体，当前只对特殊银行机构特定场景下使用此字段
        /// </summary>
        [JsonPropertyName("sub_merchant")]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// 商品标题/交易标题/订单标题/订单关键字等。  注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 商户传入终端设备相关信息，具体值要和支付宝约定
        /// </summary>
        [JsonPropertyName("terminal_params")]
        public string TerminalParams { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 当面付场景默认超时时间为3h，且最大时间不超过 3h。若当面付场景设置timeout_express>3h，接口不报错，但是订单将在3小时关闭。
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  如果同时传入【可打折金额】和【不可打折金额】，该参数可以不用传入；  如果同时传入了【可打折金额】，【不可打折金额】，【订单总金额】三者，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 标价币种,  total_amount 对应的币种单位。支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [JsonPropertyName("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。如果该值未传入，但传入了【订单总金额】和【可打折金额】，则该值默认为【订单总金额】-【可打折金额】
        /// </summary>
        [JsonPropertyName("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }
    }
}
