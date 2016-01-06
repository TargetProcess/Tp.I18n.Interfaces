using System;
using System.Collections.Generic;

namespace Tp.I18n
{
    public interface IFormattedMessage : IEquatable<IFormattedMessage>
    {
        string Token { get; }
        IDictionary<string, object> Data { get; }
        string Value { get; }
    }
}