using Markdown.Classes;
using Markdown.Interfaces;

namespace Markdown
{
    public class MDProcessor
    {
        public IRenderer renderer = new Renderer();
        public IParser parser = new Parser();

        public string MdToHTML(string text)
        {
            List<Token> tokens = parser.ParseMD(text);
            return renderer.RenderHTML(tokens);
        }
    }
}
