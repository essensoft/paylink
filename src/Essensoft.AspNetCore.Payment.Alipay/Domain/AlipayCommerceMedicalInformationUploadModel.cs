using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInformationUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInformationUploadModel : AlipayObject
    {
        /// <summary>
        /// 支付授权码
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 支付场景（默认为条形码）  条码支付，取值：bar_code  声波支付，取值：wave_code  二维码支付，取值qr_code
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 上报明细：  挂号场景：挂号科室名  线下药店：药品名称
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 业务扩展参数  系统商编号:sys_service_provider_id  该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部生成时间。 格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 上报行业：  药店：STORE
        /// </summary>
        [JsonProperty("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 是否医保业务  是：T  不是：F
        /// </summary>
        [JsonProperty("is_insurance")]
        public string IsInsurance { get; set; }

        /// <summary>
        /// 医保卡卡机构内部ID号
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
        /// 场景，取值：REGISTRATION(挂号)
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
        /// 主题
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 金额，单位元
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
