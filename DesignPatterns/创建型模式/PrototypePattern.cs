using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPatterns_PrototypePattern
{
    class PrototypePattern : ICloneable
    {
        public object Clone()
        {
            //浅复制，引用类型的对象指向不会产生改变
            return this.MemberwiseClone();
        }
    }

    class PrototypePattern_Deep : ICloneable
    {
        public object Clone()
        {
            //通过Json序列化反序列化创建新的类或者下面的方式
            using (var ms = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                return binaryFormatter.Deserialize(ms);
            }
        }
    }
}
