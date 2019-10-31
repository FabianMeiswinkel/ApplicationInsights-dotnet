﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Metrics
{
    using System;
    using Microsoft.ApplicationInsights.Channel;
    using Microsoft.ApplicationInsights.DataContracts;

    internal class RequestResponseCodeDimensionExtractor : IDimensionExtractor
    {
        public int MaxValues { get; set; }
        public string DefaultValue { get; set; } = MetricTerms.Autocollection.Common.PropertyValues.Unknown;

        public string Name { get; set; } = MetricTerms.Autocollection.Request.PropertyNames.ResultCode;

        public string ExtractDimension(ITelemetry item)
        {
            var req = item as RequestTelemetry;
            if (req != null)
            {
                return req.ResponseCode;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
