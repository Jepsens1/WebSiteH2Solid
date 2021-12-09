using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteH2Solid
{
    class Manager
    {
        IReader reader;

        public Manager(IReader _reader)
        {
            reader = _reader;
        }
        public string ShowContent()
        {
            return reader.Read();
        }
    }
}
