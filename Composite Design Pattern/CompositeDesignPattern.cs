using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern
{
    class CompositeDesignPattern
    {
        static void Main(string[] args)
        {
            HtmlTag parentTag = new HtmlParentElement("<html>");
            parentTag.SetStartTag("<html>");
            parentTag.SetEndTag("</html>");

            HtmlTag pl = new HtmlParentElement("<html>");
            pl.SetStartTag("<body>");
            pl.SetEndTag("</body>");

            parentTag.AddChildTag(pl);

            HtmlTag child1 = new HtmlElement("<p>");
            child1.SetStartTag("<p>");
            child1.SetEndTag("</p>");
            child1.SetTagBody("Testing html tag library");
            pl.AddChildTag(child1);

            child1 = new HtmlElement("<p>");
            child1.SetStartTag("<p>");
            child1.SetEndTag("</p>");
            child1.SetTagBody("Paragraph 2");
            pl.AddChildTag(child1);

            parentTag.GenerateHtml();

            Console.Read();
        }
    }
}
