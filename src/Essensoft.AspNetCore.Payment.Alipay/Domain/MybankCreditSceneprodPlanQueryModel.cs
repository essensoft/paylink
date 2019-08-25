using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodPlanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodPlanQueryModel : AlipayObject
    {
        /// <summary>
        /// 数据来源渠道，从服务窗调用开放平台接口的是OPENAPI, 手机端为APP，天猫调用是TMALL
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 客户信息来源，该字段会写入到客户签署的网商合约中
        /// </summary>
        [JsonProperty("customer_channel")]
        public string CustomerChannel { get; set; }

        /// <summary>
        /// 扩展参数,针对不同的平台特殊业务场景，将需要的参数填入改字段，目前针对直租业务有以下参数：itemprice 车辆价格，lastprop 车辆残值率,extintamt 基础服务包+增值服务包，loantenor 贷款期数，creditamtprop 授信额度比例调整值；
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [JsonProperty("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码，通过该场景码确定需要验证的参数内容，以及返回的贷款方案的格式
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 本次请求流水号，全局唯一
        /// </summary>
        [JsonProperty("seq_no")]
        public string SeqNo { get; set; }

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
