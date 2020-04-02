using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FixProblemDTO Data Structure.
    /// </summary>
    public class FixProblemDTO : AlipayObject
    {
        /// <summary>
        /// 问题的唯一id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 问题类型的一级分类
        /// </summary>
        [JsonPropertyName("problem_level_1")]
        public string ProblemLevel1 { get; set; }

        /// <summary>
        /// 问题类型的二级分类
        /// </summary>
        [JsonPropertyName("problem_level_2")]
        public string ProblemLevel2 { get; set; }

        /// <summary>
        /// 问题类型的三级分类
        /// </summary>
        [JsonPropertyName("problem_level_3")]
        public string ProblemLevel3 { get; set; }
    }
}
