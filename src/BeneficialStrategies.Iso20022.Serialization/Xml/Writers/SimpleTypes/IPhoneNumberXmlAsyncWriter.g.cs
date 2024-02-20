﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for PhoneNumber.  ISO2002 ID# _YXvFB9p-Ed-ak6NoX_4Aeg_-1045927120.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// The collection of information which identifies a specific phone or FAX number as defined by telecom services.|It consists of a &quot;+&quot; followed by the country code (from 1 to 3 characters) then a &quot;-&quot; and finally, any combination of numbers, &quot;(&quot;, &quot;)&quot;, &quot;+&quot; and &quot;-&quot; (up to 30 characters).
    /// </summary>
    public interface IPhoneNumberXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}