namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    /// <summary>
    /// 从响应字符串中提取到的待验签原始内容
    /// </summary>
    public class SignSourceData
    {
        /// <summary>
        /// 待验签原始内容
        /// </summary>
        public string SourceData { get; set; }

        /// <summary>
        /// 待验签原始内容在响应字符串中的起始位置
        /// </summary>
        public int BeginIndex { get; set; }

        /// <summary>
        /// 待验签原始内容在响应字符串中的结束位置
        /// </summary>
        public int EndIndex { get; set; }
    }
}
