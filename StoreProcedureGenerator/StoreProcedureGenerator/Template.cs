using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProcedureGenerator
{
    [Serializable]
    public class Template
    {
        public string TemplateName { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string[] TemplateCode { get; set; }
    }
}
