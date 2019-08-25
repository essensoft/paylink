using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInstcardCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInstcardCreateandpayModel : AlipayObject
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 对交易或者商品的描述
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部下单时间。 格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 支付行业：  医院：HOSPITAL  药店：STORE
        /// </summary>
        [JsonProperty("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 外部机构业务上是否允许这笔单订单使用医保支付  允许使用：T  不允许使用：F
        /// </summary>
        [JsonProperty("is_insurance")]
        public string IsInsurance { get; set; }

        /// <summary>
        /// 医保卡机构内部ID号
        /// </summary>
        [JsonProperty("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 医保机构的编号
        /// </summary>
        [JsonProperty("medical_card_inst_id")]
        public string MedicalCardInstId { get; set; }

        /// <summary>
        /// 医疗机构名称
        /// </summary>
        [JsonProperty("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 医疗机构编码(医保局分配)
        /// </summary>
        [JsonProperty("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 商户订单号，64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复。
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 患者证件号码
        /// </summary>
        [JsonProperty("patient_card_no")]
        public string PatientCardNo { get; set; }

        /// <summary>
        /// 患者证件类型
        /// </summary>
        [JsonProperty("patient_card_type")]
        public string PatientCardType { get; set; }

        /// <summary>
        /// 患者手机号
        /// </summary>
        [JsonProperty("patient_mobile")]
        public string PatientMobile { get; set; }

        /// <summary>
        /// 患者姓名  患者姓名&患者证件和医保卡信息全部匹配才能使用医保，否则认为套保嫌疑不允许医保只能自费
        /// </summary>
        [JsonProperty("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 如果需要医保支付这个字段必传。业务报文，报文中可包含多条业务数据
        /// </summary>
        [JsonProperty("request_content")]
        public string RequestContent { get; set; }

        /// <summary>
        /// 支付场景，取值：REGISTRATION(挂号)  TREATMENT(诊间)  HOSPITALIZATION(住院)  COMMON(非医院类)
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID，如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonProperty("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [JsonProperty("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，不能小于0，精确到小数点后2位。
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
