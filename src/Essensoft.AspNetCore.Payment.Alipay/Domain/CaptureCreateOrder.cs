using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CaptureCreateOrder Data Structure.
    /// </summary>
    public class CaptureCreateOrder : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 合约体系： IARCORE - ipay合约中心 MYBKARCORE - 网商产品中心 ARCORE - 主站合约 中心 OTHER - 其他合约中心
        /// </summary>
        [JsonPropertyName("ar_source")]
        public string ArSource { get; set; }

        /// <summary>
        /// 业务扩展类型 当前大量的业务系统采取复用产品码的方案，需要额外的业务识别才能够明确业务
        /// </summary>
        [JsonPropertyName("business_recognize_ext")]
        public MapParameter BusinessRecognizeExt { get; set; }

        /// <summary>
        /// 请款金额
        /// </summary>
        [JsonPropertyName("capture_amount")]
        public MultiCurrencyMoneyOpenApi CaptureAmount { get; set; }

        /// <summary>
        /// 请款时间（yyyymmdd）
        /// </summary>
        [JsonPropertyName("capture_date")]
        public string CaptureDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<MapParameter> ExtInfo { get; set; }

        /// <summary>
        /// 核算所属机构
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 请款MID
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 请款PID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 外部业务请求号，用于幂等控制
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 产品体系： IPTCORE -ipay产品中心 MYBKPTCORE - 网商产品中心 PTCORE - 主站产品中心 AFC - 金融云产品中心
        /// </summary>
        [JsonPropertyName("pd_source")]
        public string PdSource { get; set; }

        /// <summary>
        /// 调用方系统名称
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用户体系： ICIF - ipay用户体系 MYBKCIF - 网商银行用户体系 CIF - 主站用户体系 UC - 金融云用户体系
        /// </summary>
        [JsonPropertyName("user_source")]
        public string UserSource { get; set; }
    }
}
