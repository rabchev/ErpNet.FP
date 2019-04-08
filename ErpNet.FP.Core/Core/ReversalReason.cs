﻿using System.Runtime.Serialization;

namespace ErpNet.FP.Core
{
    /// <summary>
    /// Reversal Reason
    /// </summary>
    public enum ReversalReason
    {
        [EnumMember(Value = "operator-error")]
        OperatorError = 1,
        /// <summary>
        /// Goods claim or goods return
        /// </summary>
        [EnumMember(Value = "goods-return")]
        GoodsReturn = 2
    }
}