using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern
{
    class HtmlElement : HtmlTag
    {
        private string tagName;
        private string startTag;
        private string endTag;
        private string tagBody;

        public HtmlElement(string tagName)
        {
            this.tagName = tagName;
            this.tagBody = "";
            this.startTag = "";
            this.endTag = "";
        }

        public override string GetTagName()
        {
            return tagName;
        }

        public override void SetStartTag(string tag)
        {
            this.startTag = tag;
        }

        public override void SetEndTag(string tag)
        {
            this.endTag = tag;
        }

        public override void SetTagBody(string tagBody)
        {
            this.tagBody = tagBody;
        }

        public override void GenerateHtml()
        {
            Console.WriteLine(startTag + "" + tagBody + "" + endTag);
        }

        public override void AddChildTag(HtmlTag htmlTag)
        {
            return;
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {
            return;
        }

        public override List<HtmlTag> GetChildren()
        {
            return null;
        }

    }
}
