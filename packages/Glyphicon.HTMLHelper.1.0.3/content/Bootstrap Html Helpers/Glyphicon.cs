using System.Runtime.InteropServices;

namespace System.Web.Mvc.Html
{
    public static partial class HtmlHelpers
    {
        /// <summary>
        /// This HTML Helper class will generate 'span' tags with Bootstrap's Glyphicon CSS classes.
        /// </summary>
        /// <param name="icon">The CSS class for the icon to be added. Get the full list of available Glyphicons at http://getbootstrap.com/components/#glyphicons. </param>
        /// <returns>Returns the icon as string.</returns>
        public static String GlyphiconFor(string icon)
        {
            var span = new TagBuilder("span");

            span.AddCssClass("glyphicon glyphicon-" + icon);

            return new TagBuilder(span.ToString(TagRenderMode.Normal)).TagName;
        }

        /// <summary>
        /// This HTML Helper class will generate 'span' tags with Bootstrap's Glyphicon CSS classes.
        /// </summary>
        /// <param name="icon">The CSS class for the icon to be added. Get the full list of available Glyphicons at http://getbootstrap.com/components/#glyphicons.</param>
        /// <param name="white">True: renders the white icon version. False: Renders the default icon version.</param>
        /// <param name="events">Custom properties to be added to the tag. Separate them using the equals (=) sign.</param>
        /// <returns></returns>
        public static String GlyphiconFor(string icon, bool white, [Optional] params string[] events)
        {
            // Creates the tag.
            var span = new TagBuilder("span");

            // Adds the Bootstrap's Glyphicon CSS classes.
            span.AddCssClass("glyphicon glyphicon-" + icon);

            // Check for the white render icon CSS parameter.
            if (white)
            {
                span.AddCssClass("glyphicon-white");
            }
            
            // Adds the custom attributes from the HelperMethods.HTMLHelper package.
            Helpers.AddAtrributes(span, events);

            // Returns the tag.
            return new TagBuilder(span.ToString(TagRenderMode.Normal)).TagName;
        }
    }
}