using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodBillSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodBillSyncModel : AlipayObject
    {
        /// <summary>
        /// 网商申请单号(必须S结尾)  资产转让后资产持有人同步账单时必填
        /// </summary>
        [JsonProperty("app_seq_no")]
        public string AppSeqNo { get; set; }

        /// <summary>
        /// 账单列表
        /// </summary>
        [JsonProperty("bill_list")]
        public List<SceneProdBillDetail> BillList { get; set; }

        /// <summary>
        /// 客户姓名  资产转让后资产持有人同步账单时必填
        /// </summary>
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码  资产转让后资产持有人同步账单时必填
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 支用号  资产转让后资产持有人同步账单时必填
        /// </summary>
        [JsonProperty("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 扩展字段，用于适配不同机构的特殊要求
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [JsonProperty("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部平台订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，比如支付宝userid
        /// </summary>
        [JsonProperty("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
