using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern
{
    class HtmlParentElement : HtmlTag
    {
        private string tagname;
        private string startTag;
        private string endTag;
        private List<HtmlTag> childrenTag;

        public HtmlParentElement(string Tagname)
        {
            this.tagname = Tagname;
            this.startTag = "";
            this.endTag = "";
            this.childrenTag = new List<HtmlTag>();
        }

        public override string GetTagName()
        {
            return tagname;
        }
     
        public override void SetStartTag(string tag)
        {
            this.startTag = tag;
        }
       
        public override void SetEndTag(string tag)
        {
            this.endTag = tag;
        }

        public override void AddChildTag(HtmlTag htmlTag)
        {
            this.childrenTag.Add(htmlTag);
        }

        public override void RemoveChildTag(HtmlTag htmltag)
        {
            this.childrenTag.Remove(htmltag);
        }

        public override List<HtmlTag> GetChildren()
        {
            return childrenTag;
        }

        public override void GenerateHtml()
        {
            Console.WriteLine(startTag);
            foreach (HtmlTag tag in childrenTag)
            {
                tag.GenerateHtml();
            }
            Console.WriteLine(endTag);

            
        }

        public override void SetTagBody(string TagBody)
        {
            return;
        }

    }
}
