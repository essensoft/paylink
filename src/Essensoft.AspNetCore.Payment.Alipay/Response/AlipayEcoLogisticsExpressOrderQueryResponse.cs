using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoLogisticsExpressOrderQueryResponse.
    /// </summary>
    public class AlipayEcoLogisticsExpressOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 接单类型，已接单状态时必填  courier_accept：快递员接单，  site_accept：快递站接单
        /// </summary>
        [JsonPropertyName("accept_type")]
        public string AcceptType { get; set; }

        /// <summary>
        /// 取消原因，已取消状态时必填
        /// </summary>
        [JsonPropertyName("cancel_cause")]
        public string CancelCause { get; set; }

        /// <summary>
        /// 快递员支付宝帐号，快递员接单时选填
        /// </summary>
        [JsonPropertyName("courier_alipay_account")]
        public string CourierAlipayAccount { get; set; }

        /// <summary>
        /// 员工号，快递员接单时必填
        /// </summary>
        [JsonPropertyName("courier_emp_num")]
        public string CourierEmpNum { get; set; }

        /// <summary>
        /// 身份证，快递员接单时选填
        /// </summary>
        [JsonPropertyName("courier_id_card")]
        public string CourierIdCard { get; set; }

        /// <summary>
        /// 快递员手机号，快递员接单时必填
        /// </summary>
        [JsonPropertyName("courier_mobile")]
        public string CourierMobile { get; set; }

        /// <summary>
        /// 快递员姓名，快递员接单时必填
        /// </summary>
        [JsonPropertyName("courier_name")]
        public string CourierName { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 运费险理赔金额（元）
        /// </summary>
        [JsonPropertyName("fare_claims_amount")]
        public string FareClaimsAmount { get; set; }

        /// <summary>
        /// 订单最后更新时间
        /// </summary>
        [JsonPropertyName("last_modified_time")]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// 物流机构编码，参照物流机构编码文档，<a href="https://expressprod.oss-cn-hangzhou.aliyuncs.com/docs/%E5%AF%84%E4%BB%B6%E5%B9%B3%E5%8F%B0-%E7%89%A9%E6%B5%81%E6%9C%BA%E6%9E%84%E7%BC%96%E7%A0%81%E6%96%87%E6%A1%A3.xlsx">点此下载</a>。
        /// </summary>
        [JsonPropertyName("logis_merch_code")]
        public string LogisMerchCode { get; set; }

        /// <summary>
        /// 订单总金额（元）
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 寄件平台订单号，系统唯一
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态  waiting_accept:待接单，  accepted:已接单，待取件，  collected:已取件  canceled:已取消
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付状态  non_pay:未支付  payed:已支付  pay_failed:支付失败
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 产品类型变更原因。
        /// </summary>
        [JsonPropertyName("product_type_change_reason")]
        public string ProductTypeChangeReason { get; set; }

        /// <summary>
        /// 产品类型编码，取值如下：  STANDARD：标准快递。这是寄件平台默认支持的产品分类，如有其他产品分类的支持需求，可以发送邮件至xxx@alipay.com联系。
        /// </summary>
        [JsonPropertyName("product_type_code")]
        public string ProductTypeCode { get; set; }

        /// <summary>
        /// 站点所在区县编码，快递站点接单时必填。采用国家标准编码，详见国家统计局数据，<a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/2016.xls?spm=a219a.7395905.0.0.IwSSLe&file=2016.xls">点此下载</a>。
        /// </summary>
        [JsonPropertyName("site_area_code")]
        public string SiteAreaCode { get; set; }

        /// <summary>
        /// 快递站点编号，快递站点接单时必填
        /// </summary>
        [JsonPropertyName("site_code")]
        public string SiteCode { get; set; }

        /// <summary>
        /// 站点投诉电话，快递站点接单时选填
        /// </summary>
        [JsonPropertyName("site_complain_tel")]
        public string SiteComplainTel { get; set; }

        /// <summary>
        /// 站点所在详细地址，快递站点接单时必填
        /// </summary>
        [JsonPropertyName("site_detail_addr")]
        public string SiteDetailAddr { get; set; }

        /// <summary>
        /// 站点负责人手机号，快递站点接单时必填
        /// </summary>
        [JsonPropertyName("site_leader_mobile")]
        public string SiteLeaderMobile { get; set; }

        /// <summary>
        /// 站点负责人，快递站点接单时必填
        /// </summary>
        [JsonPropertyName("site_leader_name")]
        public string SiteLeaderName { get; set; }

        /// <summary>
        /// 快递站点名称，快递站点接单时必填
        /// </summary>
        [JsonPropertyName("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 支付宝交易金额（元）
        /// </summary>
        [JsonPropertyName("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号，已支付状态必填
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 运单号，已取件状态时必填
        /// </summary>
        [JsonPropertyName("way_bill_no")]
        public string WayBillNo { get; set; }
    }
}
