using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentCreateModel Data Structure.
    /// </summary>
    public class ZhimaMerchantOrderRentCreateModel : AlipayObject
    {
        /// <summary>
        /// 借用用户的收货地址，可选字段。推荐商户传入此值，会将此手机号码与用户身份信息进行匹配验证，防范欺诈风险。
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 此字段已废弃，请商户参考expiry_time字段。  借用周期，必须是正整数
        /// </summary>
        [JsonPropertyName("borrow_cycle")]
        public string BorrowCycle { get; set; }

        /// <summary>
        /// 此字段已废弃，请商户参考expiry_time字段。  借用周期单位：  HOUR:小时  DAY:天
        /// </summary>
        [JsonPropertyName("borrow_cycle_unit")]
        public string BorrowCycleUnit { get; set; }

        /// <summary>
        /// 物品借用地点的描述，便于用户知道物品是在哪里借的。可为空
        /// </summary>
        [JsonPropertyName("borrow_shop_name")]
        public string BorrowShopName { get; set; }

        /// <summary>
        /// 商户订单创建的起始借用时间，格式：YYYY-MM-DD HH:MM:SS。如果不传入或者为空，则认为订单创建起始时间为调用此接口时的时间。
        /// </summary>
        [JsonPropertyName("borrow_time")]
        public string BorrowTime { get; set; }

        /// <summary>
        /// 借用用户的真实身份证号，非必填字段。但name和cert_no必须同时非空，或者同时为空，一旦传入会对用户身份进行校验。
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 信用业务服务，默认为空，商户入驻信用借还时，特定场景下由芝麻信用借还分配后传入即可，商户自助接入流程里不需要传入该字段，否则会对该字段进行合法性校验
        /// </summary>
        [JsonPropertyName("credit_biz")]
        public string CreditBiz { get; set; }

        /// <summary>
        /// 押金，金额单位：元。  注：不允许免押金的用户按此金额支付押金；当物品丢失时，赔偿金额不得高于该金额。
        /// </summary>
        [JsonPropertyName("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 是否支持当借用用户信用不够（不准入）时，可让用户支付押金借用:   Y:支持  N:不支持  注：支付押金的金额等同于deposit_amount
        /// </summary>
        [JsonPropertyName("deposit_state")]
        public string DepositState { get; set; }

        /// <summary>
        /// 到期时间，请根据实际业务合理设置该值，不允许为空，格式：YYYY-MM-DD HH:MM:SS，是指最晚归还时间，表示借用用户如果超过此时间还未完结订单（未归还物品或者未支付租金）将会进入逾期状态，芝麻会给借用用户发送催收提醒；需要晚于borrow_time。
        /// </summary>
        [JsonPropertyName("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// 扩展信息。商户发起借用服务时的扩展信息字段，格式：json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 物品名称,最长不能超过14个汉字
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 回调到商户的url地址
        /// </summary>
        [JsonPropertyName("invoke_return_url")]
        public string InvokeReturnUrl { get; set; }

        /// <summary>
        /// 商户请求状态上下文。商户发起借用服务时，需要在借用结束后返回给商户的参数，格式：json
        /// </summary>
        [JsonPropertyName("invoke_state")]
        public string InvokeState { get; set; }

        /// <summary>
        /// 商户访问蚂蚁的对接模式：  WINDOWS：支付宝服务窗。  目前是固定值，有新增类型会同步到文档上
        /// </summary>
        [JsonPropertyName("invoke_type")]
        public string InvokeType { get; set; }

        /// <summary>
        /// 借用用户的手机号码，可选字段。推荐商户传入此值，会将此手机号码与用户身份信息进行匹配验证，防范欺诈风险。
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 借用用户的真实姓名，非必填字段。但name和cert_no必须同时非空，或者同时为空，一旦传入会对用户身份进行校验。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 废弃，使用蚂蚁开放平台应用中的网关地址
        /// </summary>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 外部订单号，需要唯一，由商户传入，芝麻内部会做幂等控制，格式为：yyyyMMddHHmmss+随机数
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 信用借还的产品码，传入固定值：w1010100000000002858
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 租金，租金+租金单位组合才具备实际的租金意义。  >0.00元，代表有租金  =0.00元，代表无租金，免费借用  注：参数传值必须>=0，传入其他值会报错参数非法
        /// </summary>
        [JsonPropertyName("rent_amount")]
        public string RentAmount { get; set; }

        /// <summary>
        /// 租金信息描述 ,长度不超过14个汉字，只用于页面展示给C端用户，除此之外无其他意义。
        /// </summary>
        [JsonPropertyName("rent_info")]
        public string RentInfo { get; set; }

        /// <summary>
        /// 租金的结算方式，非必填字段，默认是支付宝租金结算支付  merchant：表示商户自行结算，信用借还不提供租金支付能力；  alipay：表示使用支付宝支付功能，给用户提供租金代扣及赔偿金支付能力；
        /// </summary>
        [JsonPropertyName("rent_settle_type")]
        public string RentSettleType { get; set; }

        /// <summary>
        /// 租金单位，租金+租金单位组合才具备实际的租金意义。  取值定义如下：  DAY_YUAN:元/天  HOUR_YUAN:元/小时  YUAN:元  YUAN_ONCE: 元/次
        /// </summary>
        [JsonPropertyName("rent_unit")]
        public string RentUnit { get; set; }
    }
}
