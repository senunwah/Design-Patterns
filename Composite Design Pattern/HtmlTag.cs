using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern
{
    abstract class HtmlTag
    {
        public abstract string GetTagName();
        public abstract void SetStartTag(string tag);
        public abstract void SetEndTag(string tag);
        public abstract void SetTagBody(string tagBody);
        public abstract void AddChildTag(HtmlTag htmlTag);
        public abstract void RemoveChildTag(HtmlTag htmlTag);
        public abstract List<HtmlTag> GetChildren();
        public abstract void GenerateHtml();
    }
}
