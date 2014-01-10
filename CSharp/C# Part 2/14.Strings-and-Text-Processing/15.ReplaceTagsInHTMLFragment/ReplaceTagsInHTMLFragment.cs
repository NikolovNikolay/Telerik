/*Write a program that replaces in a HTML
 * document given as string all the tags
 * <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

using System;

class ReplaceTagsInHTMLFragment
{
    static void Main()
    {
        string fragment = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        int index = 0;

        fragment = fragment.Replace("<a href=\"", "[URL=");
        fragment = fragment.Replace("\">","]");
        fragment = fragment.Replace("</a>", "/URL]");
        Console.WriteLine(fragment);
    }
}
