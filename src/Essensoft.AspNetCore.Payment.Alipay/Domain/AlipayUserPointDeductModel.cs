using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPointDeductModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPointDeductModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁会员平台上的权益所对应的编号
        /// </summary>
        [JsonProperty("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 格式为yyyy-MM-dd HH:mm:ss ，业务操作时间用于对账，不传则以调用请求的当前时间计算
        /// </summary>
        [JsonProperty("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务大类，表明此次调用的来源，若无需要则不传。
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务流水号，会用于幂等性校验，所以请保证每次请求的业务流水号的唯一性
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 扣减积分时，该字段用于补充描述积分扣减的场景，将会拼在积分扣减记录的标题中进行展示，若无特殊需求则不要传该参数。明文长度不要超过32个中文汉字。
        /// </summary>
        [JsonProperty("prod_title")]
        public string ProdTitle { get; set; }

        /// <summary>
        /// 业务子类型，表明业务来源实际操作的业务分类，若无需要则不传。
        /// </summary>
        [JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
