namespace Essensoft.AspNetCore.Payment.LcswPay.Utility
{
    /// <summary>
    /// 利楚商务扫呗支付参数信息
    /// </summary>
    public class LcswPayParaInfo
    {
        /// <summary>
        /// 构建参数信息实例
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <param name="value">参数值</param>
        /// <param name="required">是否必传参数</param>
        public LcswPayParaInfo(string name,string value,bool required = true)
        {
            ParaName = name;
            ParaValue = value;
            IsRequired = required;
        }
        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParaName { get; private set; }
        /// <summary>
        /// 参数值
        /// </summary>
        public string ParaValue { get; private set; }
        /// <summary>
        /// 是否必传参数
        /// </summary>
        public bool IsRequired { get; private set; }
    }
}
