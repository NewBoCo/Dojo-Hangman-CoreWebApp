#pragma checksum "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f718aabc6675b0fe4485114145c4cc03aff836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(hangman.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(hangman.Pages.Pages_Index), null)]
namespace hangman.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\_ViewImports.cshtml"
using hangman;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f718aabc6675b0fe4485114145c4cc03aff836", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef747b2fffa0c1369623cc0ca8ff9e6118c692e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/wopr.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "12", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "8", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "6", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "StartGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "MakeGuess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 33, true);
            WriteLiteral("\r\n<h1>Hangman Game</h1>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 12 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
 if (String.IsNullOrEmpty(ViewData["PlayerName"].ToString()))
{

#line default
#line hidden
            BeginContext(170, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(174, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "577e1c7765c949a3b88f8bf66e080e3f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(209, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(213, 1380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5287c5d35564c328548cc4acd5790b7", async() => {
                BeginContext(262, 654, true);
                WriteLiteral(@"

        <h2>Game Setup</h2>
        <div class=""form-group row"">
            <label for=""playerName"" class=""col-sm-5 col-form-label-lg"">
               Your name: 
            </label>
            <div class=""col-sm-7"">
                <input type=""text"" name=""playerName"" value="""" class=""form-control""/>
            </div>
        </div>
         <div class=""form-group row"">
            <label for=""maxGuesses"" class=""col-sm-5 col-form-label-lg"">
               How many guesses do you need? 
            </label>
            <div class=""col-sm-7"">
                <select name=""maxGuesses"" class=""form-control"">
                    ");
                EndContext();
                BeginContext(916, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a94014ede8db4057a90e5cf1b0c5f226", async() => {
                    BeginContext(944, 31, true);
                    WriteLiteral("12 (Easy: I\'m too young to die)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(984, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1006, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093dd29fc0814349b5d04c3c24f624aa", async() => {
                    BeginContext(1025, 23, true);
                    WriteLiteral("10 (Hey, not too rough)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1057, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1079, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9296f1c89c64e369a64734f699889af", async() => {
                    BeginContext(1097, 18, true);
                    WriteLiteral("8 (Hurt me plenty)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1124, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1146, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82721f9679304c05bc32445810a04efe", async() => {
                    BeginContext(1164, 14, true);
                    WriteLiteral("6 (Ultra-Hard)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1187, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1209, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b0ab6ab0a4e4a41aa04930ee0943925", async() => {
                    BeginContext(1227, 14, true);
                    WriteLiteral("4 (Nightmare!)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1250, 336, true);
                WriteLiteral(@"
                </select>
            </div>
         </div>
        <div class=""row"">
            <div class=""col-sm-5"">
                &nbsp;
            </div>
            <div class=""col-sm-7"">
                <input type=""submit"" class=""btn btn-primary"" value=""Play Hangman!"" />
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1593, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"

}
else
{


#line default
#line hidden
            BeginContext(1611, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1619, "\"", 1662, 3);
            WriteAttributeValue("", 1627, "alert", 1627, 5, true);
            WriteAttributeValue(" ", 1632, "alert-", 1633, 7, true);
#line 55 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
WriteAttributeValue("", 1639, ViewData["alertClass"], 1639, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1663, 28, true);
            WriteLiteral(" role=\"alert\">\r\n        <h2>");
            EndContext();
            BeginContext(1692, 19, false);
#line 56 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 19, true);
            WriteLiteral("</h2>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1738, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(1747, 22, false);
#line 60 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
   Write(ViewData["MaskedWord"]);

#line default
#line hidden
            EndContext();
            BeginContext(1769, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 62 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
     if (Convert.ToInt16(ViewData["GuessesRemaining"])>0)
    {
        


#line default
#line hidden
            BeginContext(1856, 9, true);
            WriteLiteral("         ");
            EndContext();
            BeginContext(1867, 54, true);
            WriteLiteral(" <h3>Guess a letter:</h3>\r\n        <p> (you have only ");
            EndContext();
            BeginContext(1922, 28, false);
#line 67 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
                      Write(ViewData["GuessesRemaining"]);

#line default
#line hidden
            EndContext();
            BeginContext(1950, 30, true);
            WriteLiteral(" guesses left!)</p>\r\n         ");
            EndContext();
            BeginContext(1980, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91e25ca5e96347098078180307b0a17a", async() => {
                BeginContext(2029, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 69 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
         foreach (char letter in Model.UnguessedLetters())
        {

#line default
#line hidden
                BeginContext(2102, 77, true);
                WriteLiteral("            <input type=\"submit\" class=\"btn btn-default\" name=\"guessedLetter\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2179, "\"", 2194, 1);
#line 71 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
WriteAttributeValue("", 2187, letter, 2187, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2195, 6, true);
                WriteLiteral(" /> \r\n");
                EndContext();
#line 72 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2212, 9, true);
                WriteLiteral("         ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2228, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2242, 32, true);
            WriteLiteral("     <h3>Guessed letters:</h3>\r\n");
            EndContext();
#line 77 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
      foreach (char letter in Model.GuessedLetters())
        {
         

#line default
#line hidden
#line 79 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
          if (ViewData["SecretWord"].ToString().ToUpper().IndexOf(letter.ToString().ToUpper())>0)
         {

#line default
#line hidden
            BeginContext(2451, 58, true);
            WriteLiteral("              <input type=\"button\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2509, "\"", 2524, 1);
#line 81 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
WriteAttributeValue("", 2517, letter, 2517, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2525, 6, true);
            WriteLiteral(" /> \r\n");
            EndContext();
#line 82 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
         }
         else
         {

#line default
#line hidden
            BeginContext(2570, 57, true);
            WriteLiteral("              <input type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2627, "\"", 2642, 1);
#line 85 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
WriteAttributeValue("", 2635, letter, 2635, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2643, 6, true);
            WriteLiteral(" /> \r\n");
            EndContext();
#line 86 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
         }

#line default
#line hidden
#line 86 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
          

        }

#line default
#line hidden
            BeginContext(2681, 12, true);
            WriteLiteral("    <hr />\r\n");
            EndContext();
            BeginContext(2697, 83, true);
            WriteLiteral("    <p>\r\n        <a class=\"btn btn-primary\" href=\"/\">Start Over</a>\r\n        </p>\r\n");
            EndContext();
            BeginContext(2786, 8, true);
            WriteLiteral("<hr />\r\n");
            EndContext();
            BeginContext(2796, 173, true);
            WriteLiteral("    <button class=\"btn btn-primary\" type=\"button\" data-toggle=\"collapse\" data-target=\"#cheat\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n   Cheat\r\n  </button>\r\n");
            EndContext();
            BeginContext(2971, 88, true);
            WriteLiteral("<div class=\"collapse\" id=\"cheat\">\r\n  <div class=\"card card-body\">\r\n        Secret word: ");
            EndContext();
            BeginContext(3060, 22, false);
#line 108 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
                Write(ViewData["SecretWord"]);

#line default
#line hidden
            EndContext();
            BeginContext(3082, 20, true);
            WriteLiteral("\r\n  </div>\r\n</div>\r\n");
            EndContext();
#line 111 "G:\OneDrive\Repos\Dojo-Hangman-CoreWebApp\hangman\Pages\Index.cshtml"
}   

#line default
#line hidden
            BeginContext(3108, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
