using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm.Logic
{
    public static class DataReaderExtensions
    {
        public static int GetInt32Safe(this IDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(int) : reader.GetInt32(ordinal);
        }

        public static string GetStringSafe(this IDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? string.Empty : reader.GetString(ordinal);
        }

        public static decimal GetDecimalSafe(this IDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? default(decimal) : reader.GetDecimal(ordinal);
        }
        public static byte[] GetBytesSafe(this IDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? null : (byte[])reader[columnName];
        }
    }
}
