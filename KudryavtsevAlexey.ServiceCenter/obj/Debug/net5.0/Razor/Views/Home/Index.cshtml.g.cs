#pragma checksum "C:\Users\Lenovo\source\repos\KudryavtsevAlexey.ServiceCenter\KudryavtsevAlexey.ServiceCenter\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bfa4b0943166368335155f02ca9a4a335ef44b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\KudryavtsevAlexey.ServiceCenter\KudryavtsevAlexey.ServiceCenter\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\KudryavtsevAlexey.ServiceCenter\KudryavtsevAlexey.ServiceCenter\Views\_ViewImports.cshtml"
using KudryavtsevAlexey.ServiceCenter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\KudryavtsevAlexey.ServiceCenter\KudryavtsevAlexey.ServiceCenter\Views\_ViewImports.cshtml"
using KudryavtsevAlexey.ServiceCenter.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\KudryavtsevAlexey.ServiceCenter\KudryavtsevAlexey.ServiceCenter\Views\_ViewImports.cshtml"
using KudryavtsevAlexey.ServiceCenter.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\KudryavtsevAlexey.ServiceCenter\KudryavtsevAlexey.ServiceCenter\Views\_ViewImports.cshtml"
using KudryavtsevAlexey.ServiceCenter.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfa4b0943166368335155f02ca9a4a335ef44b0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213c9c8a7fa7e3a75d3f9c253cdf99c009e7f410", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid hello"">
	<div class=""hello__body"">
		<div class=""hello__header"">
			Hi, Welcome to our service center website!
		</div>
		<div class=""hello__text"">
			Here you can check the status of the repair of your device, and also get acquainted with our company
		</div>
	</div>
</div>

<div class=""about"">
	<div class=""about__body"">
		<div class=""about__header-main"">
			<h3>
				<span>
					More about our company:
				</span>
			</h3>
		</div>
		<div class=""about__item"">
			<div class=""about__header"">
				<h3>
					<span>
						Our mission is high quality service
					</span>
				</h3>
			</div>
			<div class=""about__description"">
				We provide professional and uninterrupted service to users of computer equipment from the world's leading manufacturers
			</div>
		</div>
		<div class=""about__item"">
			<div class=""about__header"">
				<h3>
					<span>
						The features that make SC unique in the service market are:
					</span>
				</h3>
			</div>
			<div class=""about__description"">
				<ul cl");
            WriteLiteral(@"ass=""list-group list-group-numbered"">
					<li class=""list-group-item"">
						SC is a federal-level company with dozens of its own service divisions in Russia
					</li>
					<li class=""list-group-item"">
						SC is a company that works specifically in the IT industry, we do not service household appliances and electronics in the broad sense of the word, but specialize only in the repair of high-tech devices that are part of the Information Technology segment
					</li>
					<li class=""list-group-item"">
						SC is an exclusively service company, we are professionally engaged in the only type of business - repair and maintenance of complex computer equipment
					</li>
				</ul>
			</div>
		</div>
		<div class=""about__item"">
			<div class=""about__header"">
				<h3>
					<span>
						Our advantages:
					</span>
				</h3>
			</div>
			<div class=""about__description"">
				<ul class=""list-group list-group-numbered"">
					<li class=""list-group-item"">
						A Russian brand that has existed since 2005, which is trus");
            WriteLiteral(@"ted by a large circle of global manufacturers of computer and office equipment and is widely known in the market
					</li>
					<li class=""list-group-item"">
						Own service centers are located throughout Russia, from Kaliningrad to Vladivostok
					</li>
					<li class=""list-group-item"">
						Centralized management system for all service centers based on a single proprietary information system
					</li>
					<li class=""list-group-item"">
						Several hundred professional engineers with the necessary certificates and permits to carry out work of any complexity
					</li>
					<li class=""list-group-item"">
						A wide network of partner service centers, providing geographic service coverage of those regions and cities where there are no SC own service centers
					</li>
					<li class=""list-group-item"">
						Impeccable provision of all manufacturers' requirements for the organization of maintenance and repair of each type of equipment
					</li>
					<li class=""list-group-item"">
						Uninterrupted contro");
            WriteLiteral(@"l and monitoring of all repair events throughout the SC service network in on-line mode
					</li>
					<li class=""list-group-item"">
						Powerful logistics complex in Moscow, providing centralized storage and shipment of spare parts to all our own and partner service centers
					</li>
				</ul>
			</div>
		</div>
		<div class=""about__item"">
			<div class=""about__header"">
				<h3>
					<span>
						SC offers manufacturers of computer and office equipment:
					</span>
				</h3>
			</div>
			<div class=""about__description"">
				<ul class=""list-group list-group-numbered"">
					<li class=""list-group-item"">
						Solution of the entire range of issues related to the organization of service maintenance and repair of computer and office equipment throughout Russia
					</li>
					<li class=""list-group-item"">
						Construction of logistics processes in terms of storage and movement of spare parts for computer and office equipment, including import and export of specialized products
					</li>
					<li class=""list");
            WriteLiteral(@"-group-item"">
						Customer information support by our own call-center, including the organization of dedicated channels for the ""hot line""
					</li>
					<li class=""list-group-item"">
						Mode of operation in the form of ""one window"", when all issues are resolved through a dedicated manager
					</li>
					<li class=""list-group-item"">
						The ability to provide any reports on the work performed, the movement of material values, etc.
					</li>
					<li class=""list-group-item"">
						Assistance in organizing face-to-face trainings and technical seminars at the company's classroom in Moscow
					</li>
					<li class=""list-group-item"">
						Participation in tenders for the supply of equipment to large customers as a service company of the federal level
					</li>
					<li class=""list-group-item"">
						Offsite customer service; - organization of service maintenance of equipment for corporate clients
					</li>
					<li class=""list-group-item"">
						Disposal of defective assemblies, components and faulty ");
            WriteLiteral("equipment\n\t\t\t\t\t</li>\n\t\t\t\t</ul>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591