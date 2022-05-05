using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfraestructure.bb
{
    public static class Binaryreader
    {
        public static object GetValue<T>(this BinaryReader read, TypeCode tipo)
        {

            switch (tipo)
            {

                case TypeCode.Boolean: { return read.ReadBoolean(); }
                case TypeCode.Byte: { return read.ReadByte(); }
                case TypeCode.Char: { return read.ReadChar(); }
                case TypeCode.Decimal: { return read.ReadDecimal(); }
                case TypeCode.Double: { return read.ReadDouble(); }
                case TypeCode.Single: { return read.ReadSingle(); }
                case TypeCode.UInt64: { return read.ReadUInt64(); }
                case TypeCode.Int16: { return read.ReadInt16(); }
                case TypeCode.Int32: { return read.ReadInt32(); }
                case TypeCode.Int64: { return read.ReadUInt64(); }
                case TypeCode.String: { return read.ReadString(); }
                default: { return read.Read(); }
            }

        }
    }
}
