using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataAutoScoreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAutoScoreQueryModel : AlipayObject
    {
        /// <summary>
        /// 投保地区码，参考《城市列表（含区县）v0307.xlsx》
        /// </summary>
        [JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 业务单号，唯一标识一次业务操作，与业务操作绑定。例如：A用户投保时进行车险分查询，然后发现输错了证件号码，用户修改证件号码进行二次查询，此时业务单号不用发生变化，但是UUID需要重新生成，标识【同一次业务操作，但不同的一次请求】
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型参考如下  UNDERWRITING：核保  PRICING：定价  PROMOTION：优惠  CLAIM：理赔  CUSTOMER_SERVICE：客服
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonProperty("car_frame_no")]
        public string CarFrameNo { get; set; }

        /// <summary>
        /// 车牌号，新车车牌号为空，旧车车牌号需符合行业标准
        /// </summary>
        [JsonProperty("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 姓名，须与证件上名称一致
        /// </summary>
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 投保支持证件类型参考：  IDENTITY_CARD：身份证  备注：目前仅支持身份证类型
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 扩展信息，标准JSON格式
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 人员角色 优先级为 车主>被保人>投保人  CAR_OWNER：车主  INSURED：被保险人  APPLICANT：投保人
        /// </summary>
        [JsonProperty("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 枚举定义如下，默认不传该参数为标准分查询    STANDARD：标准分   EXCLUSIVE：专属分
        /// </summary>
        [JsonProperty("score_type")]
        public string ScoreType { get; set; }

        /// <summary>
        /// 请求发起时通过程序生成标准UUID，每一次请求都需要变化。JAVA：UUID.randomUUID().toString()
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
