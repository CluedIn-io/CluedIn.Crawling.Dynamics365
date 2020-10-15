using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using CluedIn.Core;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public abstract class DynamicsModel
    {
        private IDataReader _reader;
        private HashSet<int> ColumnsRead = new HashSet<int>();

        public Dictionary<string, object> Custom { get; set; } = new Dictionary<string, object>();

        public DynamicsModel() { }

        public DynamicsModel(IDataReader reader)
        {
            _reader = reader;
        }

        public string GetStringValue(string columnName)
        {
            int? idx = Enumerable.Range(0, _reader.FieldCount).FirstOrDefault(i => string.Equals(_reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase));
            if (idx.HasValue)
            {
                ColumnsRead.Add(idx.Value);
                return _reader[columnName].ToString();
            }
            else
            {
                return default;
            }
        }

        public T GetValue<T>(string columnName)
        {
            int? idx = Enumerable.Range(0, _reader.FieldCount).FirstOrDefault(i => string.Equals(_reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase));
            if (idx.HasValue)
            {
                ColumnsRead.Add(idx.Value);
                return _reader[columnName].ToString().TryParse<T>();
            }
            else
            {
                return default;
            }
        }

        public void AddCustomMappings()
        {
            var properties = GetType().GetProperties().Select(propertyInfo => propertyInfo.Name);
            Enumerable.Range(0, _reader.FieldCount).ForEach(idx =>
            {
                if (!ColumnsRead.Contains(idx))
                {
                    Custom.Add(_reader.GetName(idx), _reader.GetValue(idx));
                }
            });
        }

    }

    internal static class ParsingExtension
    {
        public static T TryParse<T>(this string text, T defaultValue = default)
        {
            // Get specific converter for the type
            var converter = TypeDescriptor.GetConverter(typeof(T));
            // If there is a converter and conversion is valid
            if (converter?.IsValid(text) == true)
            {
                return (T)converter.ConvertFromInvariantString(text);
            }
            else
            {
                return defaultValue;
            }
        }
    }

}
